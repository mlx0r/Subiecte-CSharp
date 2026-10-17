using Microsoft.Data.SqlClient;
using System.Data;

namespace Croaziera
{
    public partial class FormTuristi : Form
    {
        public FormTuristi()
        {
            InitializeComponent();
            populeazaDataGridViewCroaziereTuristi(0);
        }

        private void RedenumireHeader(string headerText, string headerInlocuit)
        {
            dataGridViewCroaziereTuristi.Columns[headerText].HeaderText = $"{headerInlocuit}";
        }

        private void ConversieIDNume(DataTable dataTableCroaziere, DataTable dataTablePorturi)
        {
            foreach (DataRow randCroaziera in dataTableCroaziere.Rows)
            {
                string id = randCroaziera["Lista_Porturi"].ToString();
                string[] listaId = id.Split(',');
                string circuitConvertit = "";
                string numePort = "";

                for (int i = 0; i < listaId.Length; i++)
                {
                    foreach (DataRow randPort in dataTablePorturi.Rows)
                    {
                        if (randPort["ID_Port"].ToString() == listaId[i])
                        {
                            numePort = randPort["Nume_Port"].ToString();
                            break;
                        }
                    }
                    if (i == 0)
                    {
                        circuitConvertit = numePort;
                        continue;
                    }
                    circuitConvertit = circuitConvertit + ", " + numePort;
                }
                randCroaziera["Lista_Porturi"] = circuitConvertit;
            }
        }
        private void populeazaDataGridViewCroaziereTuristi(int nrZile)
        {
            string sortareCroaziere = "SELECT * FROM Croaziere ORDER BY Tip_Croaziera ASC, ID_Croaziera ASC";
            if (nrZile > 0)
            {
                sortareCroaziere = "SELECT * FROM Croaziere WHERE Tip_Croaziera = @zileCroaziera ORDER BY ID_Croaziera ASC";
            }
            string selectarePorturi = "SELECT ID_Port, Nume_Port FROM Porturi";
            string connString = Utils.GetConnectionString();
            DataTable dataTable = new();
            DataTable dataTablePort = new();

            SqlConnection conn = new();
            SqlCommand cmd = new();
            SqlDataAdapter adapter = new();

            conn.ConnectionString = connString;
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;
            conn.Open();

            cmd.CommandText = selectarePorturi;
            adapter.Fill(dataTablePort);
            conn.Close();

            cmd.CommandText = sortareCroaziere;
            
            if (nrZile > 0)
            {
                cmd.Parameters.AddWithValue("@zileCroaziera", nrZile);
            }
            adapter.Fill(dataTable);

            ConversieIDNume(dataTable, dataTablePort);

            dataGridViewCroaziereTuristi.DataSource = dataTable;

            dataGridViewCroaziereTuristi.Columns["ID_Croaziera"].Visible = false;
            RedenumireHeader("Tip_Croaziera", "ID");
            RedenumireHeader("Lista_Porturi", "Circuit");
            RedenumireHeader("Data_Start", "Data start");
            RedenumireHeader("Data_Final", "Data final");
        }

        private void comboBoxNrZile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zile = comboBoxNrZile.SelectedItem.ToString();
            string[] tipCroaziera = zile.Split(' ');
            int numarZile = int.Parse(tipCroaziera[0]);
            populeazaDataGridViewCroaziereTuristi(numarZile);
        }

        private void buttonValidare_Click(object sender, EventArgs e)
        {
            //TO-DO: validarea croazierei + harta cu traseul croazierei validate
            
            string traseu = dataGridViewCroaziereTuristi.CurrentCell.Value.ToString();
            string[] listaTraseu = traseu.Split(',');
            string selectareCoordonate = "SELECT Pozitie_X, Pozitie_Y FROM Porturi";

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
            foreach(string port in listaTraseu)
            {
                string portCurent = port;
                
                foreach(DataRow randCoordonate in dataTableCoordonate.Rows)
                {
                    if (randCoordonate["Nume_Port"].ToString() == portCurent)
                    {
                        int pozX = int.Parse(randCoordonate["Pozitie_X"].ToString());
                        int pozY = int.Parse(randCoordonate["Pozitie_Y"].ToString());
                        //de creeat liniile intre coordonate
                    }
                }
            }
        }
    }
}
