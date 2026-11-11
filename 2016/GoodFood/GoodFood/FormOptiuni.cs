using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoodFood;

public partial class FormOptiuni : Form
{
    private const string headerCantitate = "Cantitate";
    private const string headerAdauga = "Adauga";
    public FormOptiuni()
    {
        InitializeComponent();
    }

    private void buttonCalcKcal_Click(object sender, EventArgs e)
    {
        int valAni = int.Parse(textBoxAni.Text);
        int valInaltime = int.Parse(textBoxInaltime.Text);
        int valGreutate = int.Parse(textBoxGreutate.Text);

        int suma = valAni + valInaltime + valGreutate;

        textBoxNecesarKcal.ReadOnly = true;

        if (suma < 250)
        {
            textBoxNecesarKcal.Text = "1800";
        }
        if (suma >= 250 && suma <= 275)
        {
            textBoxNecesarKcal.Text = "2200";
        }
        if (suma > 275)
        {
            textBoxNecesarKcal.Text = "2500";
        }
    }

    private List<Meniu> extrageMeniuriDinFisier()
    {

        var lines = File.ReadAllLines("meniu.txt");
        var meniuri = new List<Meniu>();
        for (int i = 1; i < lines.Length; i++)
        {
            var line = lines[i];
            if (lines[i] == "")
            {
                continue;
            }
            var tokens = line.Split(';');
            var meniu = new Meniu()
            {
                Id = int.Parse(tokens[0]),
                Denumire = tokens[1],
                Descriere = tokens[2],
                Pret = int.Parse(tokens[3]),
                Kcal = int.Parse(tokens[4]),
                Felul = int.Parse(tokens[5])
            };
            meniuri.Add(meniu);
        }
        return meniuri;
    }

    private void tabPageComanda_Click(object sender, EventArgs e)
    {

    }

    private void tabControlOptiuni_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControlOptiuni.SelectedTab == tabPageComanda)
        {
            afiseazaMeniuri();
        }
    }

    private void afiseazaMeniuri()
    {
        List<Meniu> listaMeniuri = extrageMeniuriDinFisier();
        dgvMeniuri.DataSource = listaMeniuri;
        dgvMeniuri.ReadOnly = false;

        DataGridViewTextBoxColumn colCantitate = new()
        {
            Name = headerCantitate,
            HeaderText = headerCantitate,
            ReadOnly = false,
            ValueType = typeof(int),
            CellTemplate = new DataGridViewTextBoxCell
            {
                Value = 0,
                ValueType = typeof(int)
            },
            //DefaultCellStyle = new DataGridViewCellStyle
            //{
            //    NullValue = "0"
            //}
        };
        dgvMeniuri.Columns.Add(colCantitate);
        DataGridViewButtonColumn colBtnAdauga = new()
        {
            Name = headerAdauga,
            UseColumnTextForButtonValue = true,
            Text = headerAdauga,
            HeaderText = headerAdauga
        };
        dgvMeniuri.Columns.Add(colBtnAdauga);
        foreach (DataGridViewColumn col in dgvMeniuri.Columns)
        {
            if (col.HeaderText == headerCantitate)
            {
                continue;
            }
            col.ReadOnly = true;
        }
        foreach (DataGridViewRow row in dgvMeniuri.Rows)
        {
            row.Cells[headerCantitate].Value = 0;
        }
        textBoxKcal.Text = UserLogged.Current.Kcal.ToString();
    }


    private void dgvMeniuri_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridViewColumn? currColumn = null;
        foreach (DataGridViewColumn col in dgvMeniuri.Columns)
        {
            if (col.Index == e.ColumnIndex)
            {
                currColumn = col;
            }
        }
        if (currColumn?.HeaderText != headerAdauga)
        {
            return;
        }

        dgvMeniuri_CellAdaugaClick(e);
    }

    private void dgvMeniuri_CellAdaugaClick(DataGridViewCellEventArgs e)
    {
        var colCantitate = getColumnByText(dgvMeniuri, headerCantitate);
        if (colCantitate == null)
        {
            return;
        }

        var cantitateRaw = dgvMeniuri.Rows[e.RowIndex].Cells[colCantitate.Index].Value;
        if (!int.TryParse(cantitateRaw?.ToString(), out var cantitate))
        {
            cantitate = 0;
        }
        cantitate++;

        dgvMeniuri.Rows[e.RowIndex].Cells[colCantitate.Index].Value = cantitate;
        refreshTotaluri();
    }

    private static DataGridViewColumn? getColumnByText(DataGridView dgv, string text)
    {
        foreach (DataGridViewColumn col in dgv.Columns)
        {
            if (string.Equals(col.HeaderText, text, StringComparison.OrdinalIgnoreCase))
            {
                return col;
            }
        }

        return null;
    }

    private void dgvMeniuri_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex != getColumnByText(dgvMeniuri, headerCantitate)?.Index)
        {
            return;
        }

        refreshTotaluri();
    }

    private void refreshTotaluri()
    {
        var colPret = getColumnByText(dgvMeniuri, "pret")!;
        var colKcal = getColumnByText(dgvMeniuri, "kcal")!;

        int sumKcal = 0;
        int sumPret = 0;
        foreach (DataGridViewRow row in dgvMeniuri.Rows)
        {
            int.TryParse(row.Cells[headerCantitate].Value?.ToString(), out var cantitate);
            int kcal = (int)row.Cells[colKcal.Index].Value!;
            int pret = (int)row.Cells[colPret.Index].Value!;
            sumKcal += cantitate * kcal;
            sumPret += cantitate * pret;
        }

        textBoxTotalKcal.Text = sumKcal.ToString();
        textBoxPretTotal.Text = sumPret.ToString();
    }

    private void dgvMeniuri_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        if (e.ColumnIndex == getColumnByText(dgvMeniuri, headerCantitate)!.Index)
        {
            MessageBox.Show("Cantitate invalida", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonComanda_Click(object sender, EventArgs e)
    {
        var articole = new List<ArticolComanda>();
        var idToCantitate = new Dictionary<int, int>();

        var colId = getColumnByText(dgvMeniuri, "Id")!;
        var colCantitate = getColumnByText(dgvMeniuri, headerCantitate)!;
        foreach (DataGridViewRow row in dgvMeniuri.Rows)
        {
            int id = (int)row.Cells[colId.Index].Value!;
            int cantitate = (int)row.Cells[colCantitate.Index].Value!;

            idToCantitate[id] = cantitate;
        }

        var meniuri = (List<Meniu>) dgvMeniuri.DataSource!;
        foreach (var meniu in meniuri)
        {
            if (idToCantitate[meniu.Id] == 0)
            {
                continue;
            }

            articole.Add(new ArticolComanda
            {
                MeniuArticol = meniu,
                Cantitate = idToCantitate[meniu.Id]
            });
        }
        UserLogged.Current.ArticoleComandate = articole;
        var formVizualizare = new VizualizareComanda();
        this.Hide();
        formVizualizare.Show();
        
    }
}
