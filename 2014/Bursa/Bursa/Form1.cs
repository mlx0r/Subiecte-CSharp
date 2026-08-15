using Microsoft.Data.SqlClient;
using System.Data;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

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
    private Timer TimerImprospatare;
    public FormBursa()
    {
        InitializeComponent();
        dataGridView1.Hide();
        populateColumns();
        TimerImprospatare = new Timer();
        TimerImprospatare.Tick += reimprospatare;
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
        dataGridView1.Columns.Add(new DataGridViewButtonColumn
        {
            HeaderText = "Operatii"
        });
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
        dataGridView1.ReadOnly = true;
        foreach (DataRow dbRow in dbTable.Rows)
        {
            var denumire = dbRow[0];
            int.TryParse(dbRow[1].ToString(), out var nrActiuni);
            int.TryParse(dbRow[2].ToString(), out var valoare);

            dataGridView1[(int)Coloane.Denumire, randCurent].Value = denumire;
            dataGridView1[(int)Coloane.NumarActiuni, randCurent].Value = nrActiuni;
            dataGridView1[(int)Coloane.ValoareActiuneInitial, randCurent].Value = valoare;
            dataGridView1[(int)Coloane.ValoareActiuneMomentana, randCurent].Value = valoare;
            dataGridView1[(int)Coloane.ValoareCrescutMomentan, randCurent].Value = "";
            dataGridView1[(int)Coloane.TotalValoareInitial, randCurent].Value = nrActiuni * valoare;
            dataGridView1[(int)Coloane.TotalValoareMomentana, randCurent].Value = "";
            dataGridView1[(int)Coloane.ProfitPierdereMomentana, randCurent].Value = "";
            dataGridView1[(int)Coloane.ProfitPierdereTotal, randCurent].Value = "";
            dataGridView1[9, randCurent].Value = "Editare";

            randCurent++;
        }
        dataGridView1.Rows[0].ReadOnly = false;
        dataGridView1[0, 0].ReadOnly = false;
        dataGridView1.Show();
    }

    // private int CountImprospatare = 1;

    private void reimprospatare(object? sender, EventArgs e)
    {
        const string command = "SELECT Denumire, NrActiuni, Valoare FROM ListaBursa";
        var dbTable = getData(command);
        var randCurent = 0;
        var val = new Random();
        int modificare = val.Next(-5, 5);
        dataGridView1.RowCount = dbTable.Rows.Count;
        foreach (DataRow dbRow in dbTable.Rows)
        {
            int.TryParse(dbRow[1].ToString(), out var nrActiuni);
            int.TryParse(dbRow[2].ToString(), out var valoare);
            dataGridView1[(int)Coloane.ValoareCrescutMomentan, randCurent].Value = modificare;
            dataGridView1[(int)Coloane.ValoareActiuneMomentana, randCurent].Value = valoare + modificare;
            dataGridView1[(int)Coloane.TotalValoareMomentana, randCurent].Value = nrActiuni * (valoare + modificare);
            dataGridView1[(int)Coloane.ProfitPierdereMomentana, randCurent].Value = nrActiuni * modificare;
            dataGridView1[(int)Coloane.ProfitPierdereTotal, randCurent].Value = (nrActiuni * (valoare + modificare)) - (nrActiuni * valoare);
            randCurent++;
            modificare = val.Next(-5, 5);
        }
        // MessageBox.Show($"Sunt la a {CountImprospatare++}-a improspatare");
    }

    private void buttonDeschideBursa_Click(object sender, EventArgs e)
    {
        TimerImprospatare.Enabled = true;
        TimerImprospatare.Interval = (int)numericUpDownRataImprospatare.Value;
    }

    private void buttonInchideBursa_Click(object sender, EventArgs e)
    {
        TimerImprospatare.Enabled = false;
    }
}
