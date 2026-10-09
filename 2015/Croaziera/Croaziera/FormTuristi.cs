using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Croaziera
{
    public partial class FormTuristi : Form
    {
        public FormTuristi()
        {
            InitializeComponent();
            populeazaDataGridViewCroaziereTuristi(0);
        }

        private void redenumireHeader(string headerText, string headerInlocuit)
        {
            dataGridViewCroaziereTuristi.Columns[headerText].HeaderText = $"{headerInlocuit}";
        }
        private void conversieIDNume(DataTable dataTableCroaziere, DataTable dataTablePorturi)
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
            DataTable dataTable = new DataTable();
            DataTable dataTablePort = new DataTable();

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            conn.ConnectionString = connString;
            cmd.Connection = conn;
            adapter.SelectCommand = cmd;

            cmd.CommandText = selectarePorturi;
            adapter.Fill(dataTablePort);

            cmd.CommandText = sortareCroaziere;
            cmd.Parameters.Clear();
            if (nrZile > 0)
            {
                cmd.Parameters.AddWithValue("@zileCroaziera", nrZile);
            }
            adapter.Fill(dataTable);

            conversieIDNume(dataTable, dataTablePort);

            dataGridViewCroaziereTuristi.DataSource = dataTable;

            dataGridViewCroaziereTuristi.Columns["ID_Croaziera"].Visible = false;
            redenumireHeader("Tip_Croaziera", "ID");
            redenumireHeader("Lista_Porturi", "Circuit");
            redenumireHeader("Data_Start", "Data start");
            redenumireHeader("Data_Final", "Data final");
        }

        private void comboBoxNrZile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zile = comboBoxNrZile.SelectedItem.ToString();
            string[] tipCroaziera = zile.Split(' ');
            int numarZile = int.Parse(tipCroaziera[0]);
            populeazaDataGridViewCroaziereTuristi(numarZile);
        }
    }
}
