namespace Bursa;

using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.Common;
using System.Drawing.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public partial class FormBursa : Form
{
    public FormBursa()
    {
        InitializeComponent();
        dataGridView1.Hide();
    }

    private void utilizatorMenu_MouseEnter(object sender, EventArgs e)
    {
        utilizatorMenu.ShowDropDown();
    }
    private BindingSource bindingsource1 = new BindingSource();
    private void getData(string selectCommand)
    {
        try
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rares\\source\\repos\\Subiecte-CSharp\\2014\\Bursa\\Bursa\\Database1.mdf;Integrated Security=True;Connect Timeout=30";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private string command = "SELECT Denumire, NrActiuni, Valoare FROM ListaBursa";
    private void actiunileMeleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        getData(command);
        dataGridView1.Show();

    }
}
