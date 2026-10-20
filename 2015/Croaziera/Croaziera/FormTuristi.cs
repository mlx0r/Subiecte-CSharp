using Microsoft.Data.SqlClient;
using System.Data;

namespace Croaziera
{
    public partial class FormTuristi : Form
    {
        public FormTuristi()
        {
            InitializeComponent();
            var croaziere = obtineCroaziere();
            PopulareViewCroaziere(croaziere);
        }

        private void RedenumireHeader(string headerText, string headerInlocuit)
        {
            dataGridViewCroaziereTuristi.Columns[headerText]?.HeaderText = $"{headerInlocuit}";
        }

        private void ConversieIDNume(DataTable dataTableCroaziere, DataTable dataTablePorturi)
        {
            foreach (DataRow randCroaziera in dataTableCroaziere.Rows)
            {
                string id = randCroaziera["Lista_Porturi"].ToString() ?? "";
                string[] listaId = id.Split(',');
                string circuitConvertit = "";
                string numePort = "";

                for (int i = 0; i < listaId.Length; i++)
                {
                    foreach (DataRow randPort in dataTablePorturi.Rows)
                    {
                        if (randPort["ID_Port"].ToString() == listaId[i])
                        {
                            numePort = randPort["Nume_Port"].ToString()!;
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
        
        private void PopulareViewCroaziere(List<Croaziera> croaziere)
        {
            const string headerIdCroaziera = "ID_Croaziera";
            const string  headerTipCroaziera = "Tip_Croaziera";
            const string headerListaPorturi = "Lista_Porturi";
            const string headerDataStart = "Data_start";
            const string headerDataFinal = "Data_final";
            const string headerPret = "Pret";
            const string headerNrPasageri = "Nr_Pasageri";
      
            DataTable dtCroaziere = new();
            dtCroaziere.Columns.Add(new DataColumn(headerIdCroaziera, typeof(int)));
            dtCroaziere.Columns.Add(new DataColumn(headerTipCroaziera, typeof(int)));
            dtCroaziere.Columns.Add(new DataColumn(headerListaPorturi, typeof(string)));
            dtCroaziere.Columns.Add(new DataColumn(headerDataStart, typeof(string)));
            dtCroaziere.Columns.Add(new DataColumn(headerDataFinal, typeof(string)));
            dtCroaziere.Columns.Add(new DataColumn(headerPret, typeof(int)));
            dtCroaziere.Columns.Add(new DataColumn(headerNrPasageri, typeof(int)));
            
            

            foreach (var c in croaziere)
            {
                DataRow dr = dtCroaziere.NewRow();
                dr[headerIdCroaziera] = c.Id;
                dr[headerListaPorturi] = string.Join(',', c.ListaPorturiCuNumePorturi());
                dr[headerTipCroaziera] = c.Tip;
                dr[headerNrPasageri] = c.NrPasageri;
                dr[headerPret] = c.Pret;
                dr[headerDataStart] = c.Start.HasValue ? c.Start.ToString() : "";
                dr[headerDataFinal] = c.Final.HasValue ? c.Final.ToString() : "";
                dtCroaziere.Rows.Add(dr);
            }

            dataGridViewCroaziereTuristi.DataSource = dtCroaziere;

            dataGridViewCroaziereTuristi.Columns[headerIdCroaziera]!.Visible = false;
        }
        
        private List<Croaziera> obtineCroaziere()
        {
            const string sortareCroaziere = "SELECT * FROM Croaziere ORDER BY Tip_Croaziera ASC, ID_Croaziera ASC";
            using SqlConnection conn = new()
            {
                ConnectionString = Utils.GetConnectionString()
            };
            SqlCommand cmd = new()
            {
                CommandText = sortareCroaziere,
                Connection = conn
            };
            DataTable dataTable = new();
            SqlDataAdapter adapter = new()
            {
                SelectCommand = cmd
            };
            adapter.Fill(dataTable);
            
            var croaziere = new List<Croaziera>();

            foreach (DataRow row in dataTable.Rows)
            {
                var croaziera = creeazaCroaziera(row);
                croaziere.Add(croaziera);
            }

            return croaziere;
        }

        private Croaziera creeazaCroaziera(DataRow row)
        {
            var porturiListaNumereCuVirgula = row.Field<string>("Lista_Porturi") ?? "";
            var porturiNumereStr = porturiListaNumereCuVirgula.Split(",");
            var porturi = new List<int>();
            foreach (var portString in porturiNumereStr)
            {
                var portNumar = int.Parse(portString);
                porturi.Add(portNumar);
            }

            return new Croaziera
            {
                Id = row.Field<int>("ID_Croaziera"),
                Final = row.Field<DateTime?>("Data_Final"),
                Start = row.Field<DateTime?>("Data_Start"),
                ListaPorturi = porturi,
                Pret = row.Field<int>("Pret"),
                NrPasageri = row.Field<int>("Nr_Pasageri"),
                Tip = row.Field<int>("Tip_Croaziera")
            };
        }

        private List<Croaziera> obtineCroaziereCuNrZile(int nrZile)
        {
            const string sortareCroaziere = "SELECT * FROM Croaziere WHERE Tip_Croaziera = @zileCroaziera ORDER BY ID_Croaziera ASC";
            using SqlConnection conn = new()
            {
                ConnectionString = Utils.GetConnectionString()
            };
            SqlCommand cmd = new()
            {
                CommandText = sortareCroaziere,
                Connection = conn
            };
            cmd.Parameters.AddWithValue("@zileCroaziera", nrZile);
            DataTable dataTable = new();
            SqlDataAdapter adapter = new()
            {
                SelectCommand = cmd
            };
            adapter.Fill(dataTable);
            var croaziere = new List<Croaziera>();

            foreach (DataRow row in dataTable.Rows)
            {
                var croaziera = creeazaCroaziera(row);
                croaziere.Add(croaziera);
            }

            return croaziere;
        }

        private List<(int IdPort, string NumePort)> obtinePorturi()
        {
            var selectarePorturi = "SELECT ID_Port, Nume_Port FROM Porturi";
            var connString = Utils.GetConnectionString();
            DataTable dataTablePort = new();

            using SqlConnection conn = new();
            SqlCommand cmd = new();
            SqlDataAdapter adapter = new();

            conn.ConnectionString = connString;
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;
            conn.Open();
            cmd.CommandText = selectarePorturi;
            adapter.Fill(dataTablePort);
            List<(int IdPort, string NumePort)> rez = [];
            foreach (DataRow row in dataTablePort.Rows)
            {
                var port = (int.Parse(row["ID_Port"].ToString()!), row["Nume_Port"].ToString()!);
                rez.Add(port);
            }

            return rez;
        }

        private void comboBoxNrZile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zile = comboBoxNrZile.SelectedItem!.ToString()!;
            string[] tipCroaziera = zile.Split(' ');
            int numarZile = int.Parse(tipCroaziera[0]);
            var dtCroaziere = obtineCroaziereCuNrZile(numarZile);
            PopulareViewCroaziere(dtCroaziere);
        }

        private void buttonValidare_Click(object sender, EventArgs e)
        {
            // TODO: validarea croazierei + harta cu traseul croazierei validate

            string traseu = dataGridViewCroaziereTuristi.CurrentCell?.Value?.ToString() ?? "";
            string[] listaTraseu = traseu.Split(',');

            var coordonatePorturi = ObtineCoordonatePorturi();
            
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

    }
}
