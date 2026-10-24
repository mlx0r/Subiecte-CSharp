using Microsoft.Data.SqlClient;
using System.Data;

namespace Croaziera;

public partial class FormVizualizareTraseu : Form
{
    private List<string> listaPorturiDesen;
    private FormVizualizareTraseu()
    {
        InitializeComponent();
    }

    public FormVizualizareTraseu(List<string> listaPorturi)
    {
        InitializeComponent();
        listaPorturiDesen = listaPorturi;
        pictureBoxMareaNeagra.Paint += pictureBoxMareaNeagra_Paint;
        //pictureBoxMareaNeagra.Invalidate(); // ? 
    }

    private void deseneazaLinie(Graphics g, Point start, Point final)
    {
        var pen = new Pen(Color.Red);
        g.DrawLine(pen, start, final);

    }

    private List<(string NumePort, int PozitieX, int PozitieY)> ObtineCoordonatePorturi()
    {
        const string selectareCoordonate = "SELECT Nume_Port, Pozitie_X, Pozitie_Y FROM Porturi";

        string connString = Utils.GetConnectionString();

        DataTable dataTableCoordonate = new();

        SqlConnection conn = new();
        SqlCommand cmd = new();
        SqlDataAdapter adapter = new();

        conn.ConnectionString = connString;
        cmd.Connection = conn;
        cmd.CommandText = selectareCoordonate;
        adapter.SelectCommand = cmd;

        conn.Open();
        adapter.Fill(dataTableCoordonate);
        conn.Close();
        List<(string NumePort, int PozitieX, int PozitieY)> rez = [];

        foreach (DataRow randCoordonate in dataTableCoordonate.Rows)
        {
            // a != null ? a : b 
            // <=>
            // a ?? b
            if (!int.TryParse(randCoordonate["Pozitie_X"].ToString(), out var pozX))
            {
                pozX = -1;
            }

            if (!int.TryParse(randCoordonate["Pozitie_Y"].ToString(), out var pozY))
            {
                pozY = -1;
            }
            rez.Add((randCoordonate["Nume_Port"].ToString() ?? string.Empty, pozX, pozY));
        }
        return rez;
    }

    private void FormVizualizareTraseu_Load(object sender, EventArgs e)
    {

    }

    private void pictureBoxMareaNeagra_Paint(object sender, PaintEventArgs e)
    {
        var coordonate = ObtineCoordonatePorturi().ToDictionary(x => x.NumePort, x => new Point(x.PozitieX, x.PozitieY));
        for (int i = 0; i < listaPorturiDesen.Count - 1; i++)
        {
            var portStart = listaPorturiDesen[i];
            var portFinal = listaPorturiDesen[i + 1];
            deseneazaLinie(e.Graphics, coordonate[portStart], coordonate[portFinal]);
        }
        pictureBoxMareaNeagra.Paint += pictureBoxMareaNeagra_Paint;
    }

    private void buttonRevenireAuth_Click(object sender, EventArgs e)
    {
        this.Hide();
        FormAutentificare form = new();
        form.Show();
    }
}
