using Microsoft.Data.SqlClient;
using System.Data;

namespace Bursa;

public partial class FormBursa : Form
{
    private enum Coloane
    {
        Denumire,
        NumarActiuni,
        ValoareActiuneInitial,
        ValoareActiuneMomentana,
        ValoareCrescutMomentan,
        TotalValoareInitial,
        TotalValoareMomentana,
        ProfitPierdereMomentana,
        ProfitPierdereTotal
    }

    public FormBursa()
    {
        InitializeComponent();
        dataGridView1.Hide();
        populateColumns();
    }

    private void populateColumns()
    {
        string[] columnNames =
        [
            "Denumire",
            "Numar actiuni",
            "Valoare actiune INITIAL",
            "Valoare actiune momentana",
            "Valoare cu care a crescut sau scazut actiunea momentan",
            "Total valoare initial",
            "Total valoare momentana",
            "Profit / Pierdere momentana",
            "Profit / Pierdere total"
        ];
        dataGridView1.Columns.Clear();
        foreach (var columnName in columnNames)
        {
            //var column = new DataGridViewTextBoxColumn();
            //column.HeaderText = columnName;
            var column = new DataGridViewTextBoxColumn
            {
                HeaderText = columnName
            };
            dataGridView1.Columns.Add(column);
        }
    }

    private void utilizatorMenu_MouseEnter(object sender, EventArgs e)
    {
        utilizatorMenu.ShowDropDown();
    }

    private DataTable? getData(string selectCommand)
    {
        try
        {
            string connectionString = 
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rares\\source\\repos\\Subiecte-CSharp\\2014\\Bursa\\Bursa\\Database1.mdf;Integrated Security=True;Connect Timeout=30";

            var dataAdapter = new SqlDataAdapter(selectCommand, connectionString);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
            return null;
        }
    }
    
    private void actiunileMeleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        const string command = "SELECT Denumire, NrActiuni, Valoare FROM ListaBursa";
        var dbTable = getData(command);
        if (dbTable == null)
        {
            return;
        }

        var gridViewTable = new DataTable();
        var randCurent = 0;
        dataGridView1.RowCount = dbTable.Rows.Count;
        foreach (DataRow dbRow in dbTable.Rows)
        {
            var denumire = dbRow[0];
            int.TryParse(dbRow[1].ToString(), out var nrActiuni);
            int.TryParse(dbRow[2].ToString(), out var valoare);

            dataGridView1[(int) Coloane.Denumire, randCurent].Value = denumire;
            dataGridView1[(int) Coloane.NumarActiuni, randCurent].Value = nrActiuni;
            dataGridView1[(int) Coloane.ValoareActiuneInitial, randCurent].Value = valoare;
            dataGridView1[(int) Coloane.ValoareActiuneMomentana, randCurent].Value = valoare;
            dataGridView1[(int) Coloane.ValoareCrescutMomentan, randCurent].Value = "";
            dataGridView1[(int) Coloane.TotalValoareInitial, randCurent].Value = nrActiuni * valoare;
            dataGridView1[(int) Coloane.TotalValoareMomentana, randCurent].Value = "";
            dataGridView1[(int) Coloane.ProfitPierdereMomentana, randCurent].Value = "";
            dataGridView1[(int) Coloane.ProfitPierdereTotal, randCurent].Value = "";

            randCurent++;
        }
        dataGridView1.Show();
    }
}
