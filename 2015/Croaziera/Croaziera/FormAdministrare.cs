using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Collections.Specialized;

namespace Croaziera;

public partial class FormAdministrare : Form
{
    private List<Point> Coordonate = [];
    private List<List<int>> Distante;
    
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
        Distante = [];
        for (int i = 0; i <= NumarTotalPorturi; i++)
        {
            Distante.Add([]);
        }
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

        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={GetBasePath()}\\CroazieraDB.mdf;Integrated Security=True";
        using var connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        connection.Open();
        var delCmd = new SqlCommand();
        delCmd.Connection = connection;
        delCmd.CommandText = "DELETE FROM Porturi";
        delCmd.ExecuteNonQuery();
        for (int i = 0; i < NumarTotalPorturi; i++)
        {
            var port = porturi[i];
            var insertCmd = new SqlCommand();
            insertCmd.Connection = connection;
            insertCmd.CommandText = "INSERT INTO Porturi (Nume_Port, Pozitie_X, Pozitie_Y) VALUES (@NumePort, @PozitieX, @PozitieY)";
            insertCmd.Parameters.AddWithValue("@NumePort", port.Nume);
            insertCmd.Parameters.AddWithValue("@PozitieX", port.Pozitie.X);
            insertCmd.Parameters.AddWithValue("@PozitieY", port.Pozitie.Y);

            insertCmd.ExecuteNonQuery();
        }
    }

    private void salveazaDistanteInDB()
    {
        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={GetBasePath()}\\CroazieraDB.mdf;Integrated Security=True";
        using var connection = new SqlConnection();
        connection.ConnectionString = connectionString;
        connection.Open();

        var delCmd = new SqlCommand();
        delCmd.Connection = connection;
        delCmd.CommandText = "DELETE FROM Distante";
        delCmd.ExecuteNonQuery();
        string pathFisier = GetBasePath() + "\\" + "Harta_Distantelor.txt";
        string[] linii = File.ReadAllLines(pathFisier);

        for (int i = 0; i < linii.Length; i++)
        {
            string[] valori = linii[i].Split(' ');

            for (int j = 0; j < valori.Length; j++)
            {
                var insertCmd = new SqlCommand();
                insertCmd.Connection = connection;
                insertCmd.CommandText =
                    "INSERT INTO Distante (ID_Port, ID_Port_Destinatie, Nume_Port_Destinatie, Distanta) VALUES (@IDPort, @IDDest, @NumeDest, @Distanta)";

                int portStart = i + 1;
                insertCmd.Parameters.AddWithValue("@IDPort", portStart);
                int portDestinatie = j + 1;
                insertCmd.Parameters.AddWithValue("@IDDest", portDestinatie);
                insertCmd.Parameters.AddWithValue("@NumeDest", Porturi[j].Nume);
                int distanta = int.Parse(valori[j]);
                insertCmd.Parameters.AddWithValue("@Distanta", distanta);

                insertCmd.ExecuteNonQuery();

                Distante[portStart][portDestinatie] = distanta;
            }
        }
    }

    private string GetBasePath()
    {
        var currDir = Directory.GetCurrentDirectory();
        var basePath = Directory.GetParent(currDir).Parent.Parent.FullName;
        return basePath;
    }

    private void buttonActualizareDist_Click(object sender, EventArgs e)
    {
        salveazaDistanteInDB();
    }

    private void buttonGenCroaziere_Click(object sender, EventArgs e)
    {
        List<int> tipuri = [3, 5, 8];
        List<Croaziera> croaziere = [];
        int id = 1;
        for(int i = 1; i <= 13; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                var traseu = Traseu(i, j);
                var pret = pretCroaziera(traseu);
                var croaziera = new Croaziera(
                    id++, 
                    tipuri[j],
                    traseu,
                    DateTime.MinValue, DateTime.MinValue, pret, 0);
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
        // TODO: INSERT CROAZIERA
    }

    private int pretCroaziera(List<int> traseu)
    {
        int pretTotal = 0;
        for(int i = 0; i < traseu.Count - 1; i++)
        {
            pretTotal += Distante[traseu[i]][traseu[i + 1]] * 2;
        }

        return pretTotal;
    }

    private List<int> Traseu(int portStart, int nrZile)
    {
        List<int> listaPorturi = [];
        listaPorturi.Add(portStart);

        for(int i = 1; i < nrZile; i++)
        {
            listaPorturi.Add(next(portStart, i));
        }
        listaPorturi.Add(portStart);
        return listaPorturi;
    }

    private int next(int start, int decalaj)
    {
        if(start + decalaj == NumarTotalPorturi)
        {
            return NumarTotalPorturi;
        }
        return (start + decalaj) % NumarTotalPorturi;
    }
}
