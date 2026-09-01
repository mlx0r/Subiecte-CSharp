using Microsoft.Data.SqlClient;

namespace Croaziera;

public partial class FormAdministrare : Form
{
    private List<Point> Coordonate = [];
    // private List<List<int>> Distante;
    int[,] Distante = new int[14, 14];


    private List<string> numePorturi =
    [
        "Constanta",
        "Varna",
        "Burgas",
        "Istambul",
        "Kozlu",
        "Samsun",
        "Batumi",
        "Sokhumi",
        "Soci",
        "Anapa",
        "Yalta",
        "Sevastopol",
        "Odessa"
    ];
    private List<Port> Porturi;
    private const int NumarTotalPorturi = 13;
    public FormAdministrare()
    {
        InitializeComponent();
        GetBasePath();
    }

    private void buttonListaCroaziere_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormListaCroaziere formCroaziere = new FormListaCroaziere();
        formCroaziere.Show();
    }

    private void buttonInitCoordonate_Click(object sender, EventArgs e)
    {
        Coordonate = [];
        MessageBox.Show("Da cate un click pe fiecare port, incepand din Constanta si terminand cu Odessa", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);

        resetProgress();
    }

    private void pictureBoxMareaNeagra_MouseClick(object sender, MouseEventArgs e)
    {
        Coordonate.Add(e.Location);
        bool esteUltimul = Coordonate.Count == NumarTotalPorturi;
        string nrPunct = esteUltimul ? "ultimul punct" : $"punctul nr. {Coordonate.Count}";
        updateProgress(Coordonate.Count);
    }

    private void resetProgress()
    {
        panelInitCoordonateProgress.Visible = true;
        labelProgressCurent.Text = $"0 / {NumarTotalPorturi}";
        progressBar1.Value = 0;
        progressBar1.Minimum = 0;
        progressBar1.Maximum = 13;
    }
    private void updateProgress(int nrCurentPorturi)
    {
        progressBar1.Value = nrCurentPorturi;
        labelProgressCurent.Text = $"{nrCurentPorturi} / {NumarTotalPorturi}";
    }

    private void buttonSaveCoordonate_Click(object sender, EventArgs e)
    {
        if (Coordonate.Count != NumarTotalPorturi)
        {
            return;
        }
        Porturi = [];

        for (int i = 0; i < NumarTotalPorturi; i++)
        {
            var port = new Port(i + 1, numePorturi[i], Coordonate[i]);
            Porturi.Add(port);
        }
        salveazaPorturiInDB(Porturi);
        panelInitCoordonateProgress.Visible = false;
    }

    private void salveazaPorturiInDB(List<Port> porturi)
    {

        deleteTabelDB("Porturi");

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={GetBasePath()}\\CroazieraDB.mdf;Integrated Security=True";
        using var connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        connection.Open();

        for (int i = 0; i < NumarTotalPorturi; i++)
        {
            var port = porturi[i];
            var insertCmd = new SqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO Porturi (Nume_Port, Pozitie_X, Pozitie_Y) VALUES (@NumePort, @PozitieX, @PozitieY)"
            };
            insertCmd.Parameters.AddWithValue("@NumePort", port.Nume);
            insertCmd.Parameters.AddWithValue("@PozitieX", port.Pozitie.X);
            insertCmd.Parameters.AddWithValue("@PozitieY", port.Pozitie.Y);

            insertCmd.ExecuteNonQuery();
        }
    }

    private void salveazaDistanteInDB()
    {
        deleteTabelDB("Distante");

        string pathFisier = GetBasePath() + "\\" + "Harta_Distantelor.txt";
        string[] linii = File.ReadAllLines(pathFisier);

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={GetBasePath()}\\CroazieraDB.mdf;Integrated Security=True";
        using var connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        connection.Open();

        for (int i = 0; i < linii.Length; i++)
        {
            string[] valori = linii[i].Split(' ');

            for (int j = 0; j < valori.Length; j++)
            {
                var insertCmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText =
                        "INSERT INTO Distante (ID_Port, ID_Port_Destinatie, Nume_Port_Destinatie, Distanta) VALUES (@IDPort, @IDDest, @NumeDest, @Distanta)"
                };

                int portStart = i + 1;
                insertCmd.Parameters.AddWithValue("@IDPort", portStart);
                int portDestinatie = j + 1;
                insertCmd.Parameters.AddWithValue("@IDDest", portDestinatie);
                insertCmd.Parameters.AddWithValue("@NumeDest", Porturi[j].Nume);
                int distanta = int.Parse(valori[j]);
                insertCmd.Parameters.AddWithValue("@Distanta", distanta);

                insertCmd.ExecuteNonQuery();

                Distante[portStart, portDestinatie] = distanta;
            }
        }
    }

    private string GetBasePath()
    {
        var currDir = Directory.GetCurrentDirectory();
        var basePath = Directory.GetParent(currDir).Parent.Parent.FullName;
        return basePath;
    }

    private void deleteTabelDB(string Tabel)
    {
        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={GetBasePath()}\\CroazieraDB.mdf;Integrated Security=True";
        using var connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        connection.Open();

        var delCmd = new SqlCommand
        {
            Connection = connection,
            CommandText = $"DELETE FROM {Tabel}"
        };
        delCmd.ExecuteNonQuery();
    }

    private void buttonActualizareDist_Click(object sender, EventArgs e)
    {
        salveazaDistanteInDB();
    }

    private void buttonGenCroaziere_Click(object sender, EventArgs e)
    {
        deleteTabelDB("Croaziere");

        List<int> tipuri = [3, 5, 8];
        List<Croaziera> croaziere = [];
        int id = 1;
        for(int i = 1; i <= 13; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                var traseu = Traseu(i, j);
                var pret = pretCroaziera(traseu);
                var croaziera = new Croaziera
                {
                    Id = id++,
                    Tip = tipuri[j],
                    ListaPorturi = traseu,
                    Start = new DateTime(2026, 1, 1),
                    Final = new DateTime(2026, 1, 1),
                    Pret = pret,
                    NrPasageri = 0
                };
                croaziere.Add(croaziera);
            }
        }

        foreach (var croaziera in croaziere)
        {
            salveazaCroaziera(croaziera);
        }
    }

    private void salveazaCroaziera(Croaziera croaziera)
    {
        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={GetBasePath()}\\CroazieraDB.mdf;Integrated Security=True";
        using var connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        connection.Open();

        var insertCmd = new SqlCommand
        {
            Connection = connection,
            CommandText = @"INSERT INTO Croaziere (ID_Croaziera, Tip_Croaziera, Lista_Porturi, Data_Start, Data_Final, Pret, Nr_Pasageri) VALUES 
                                  (@IdCroaziera, @TipCroaziera, @ListaPorturi, @DataStart, @DataFinal, @Pret, @NrPasageri)"
        };

        insertCmd.Parameters.AddWithValue("@IdCroaziera", croaziera.Id);
        insertCmd.Parameters.AddWithValue("@TipCroaziera", croaziera.Tip);
        insertCmd.Parameters.AddWithValue("@ListaPorturi", string.Join(",", croaziera.ListaPorturi));
        insertCmd.Parameters.AddWithValue("@DataStart", croaziera.Start);
        insertCmd.Parameters.AddWithValue("@DataFinal", croaziera.Final);
        insertCmd.Parameters.AddWithValue("@Pret", croaziera.Pret);
        insertCmd.Parameters.AddWithValue("@NrPasageri", croaziera.NrPasageri);

        insertCmd.ExecuteNonQuery();
    }

    private int pretCroaziera(List<int> traseu)
    {
        int pretTotal = 0;
        for(int i = 0; i < traseu.Count - 1; i++)
        {
            pretTotal += Distante[traseu[i], traseu[i + 1]] * 2;
        }

        return pretTotal;
    }

    private List<int> Traseu(int portStart, int nrZile)
    {
        List<int> listaPorturi = [];
        listaPorturi.Add(portStart);

        for(int i = 1; i < nrZile; i++)
        {
            listaPorturi.Add(Next(portStart, i));
        }
        listaPorturi.Add(portStart);
        return listaPorturi;
    }

    private int Next(int start, int decalaj)
    {
        if(start + decalaj == NumarTotalPorturi)
        {
            return NumarTotalPorturi;
        }
        return (start + decalaj) % NumarTotalPorturi;
    }
}
