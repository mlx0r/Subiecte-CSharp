

namespace GoodFood;

public partial class VizualizareComanda : Form
{
    public VizualizareComanda()
    {
        InitializeComponent();
        afisareComanda();
    }
    private const string headerElimina = "Elimina";
    private const string headerCantitate = "Cantitate";
    private void afisareComanda()
    {
        var comanda = UserLogged.Current.ArticoleComandate;

        dgvVizComanda.Columns.Add("colNume", "Nume Produs");
        dgvVizComanda.Columns.Add("colKcal", "Kcal");
        dgvVizComanda.Columns.Add("colPret", "Pret");
        dgvVizComanda.Columns.Add("colCantitate", "Cantitate");
        DataGridViewButtonColumn colBtnElim = new()
        {
            Name = "colElimina",
            HeaderText = "Elimina",
            UseColumnTextForButtonValue = true,
            Text = "Elimina"
        };
        dgvVizComanda.Columns.Add(colBtnElim);
        dgvVizComanda.ReadOnly = true;
        dgvVizComanda.AllowUserToAddRows = false;
        foreach (var articol in comanda)
        {
            var nume = articol.MeniuArticol.Denumire;
            var kcal = articol.MeniuArticol.Kcal;
            var pret = articol.MeniuArticol.Pret;
            var cantitate = articol.Cantitate;

            dgvVizComanda.Rows.Add(nume, kcal, pret, cantitate);
        }
        textBoxKcalViz.Text = UserLogged.Current.Kcal.ToString();
        refreshTotaluri();
    }


    private void dgvVizComanda_CellEliminaClick(DataGridViewCellEventArgs e)
    {
        var colCantitate = getColumnByText(dgvVizComanda, headerCantitate);
        if (colCantitate == null)
        {
            return;
        }

        var cantitateRaw = dgvVizComanda.Rows[e.RowIndex].Cells[colCantitate.Index].Value;
        if (!int.TryParse(cantitateRaw?.ToString(), out var cantitate))
        {
            cantitate = 0;
        }
        cantitate--;

        dgvVizComanda.Rows[e.RowIndex].Cells[colCantitate.Index].Value = cantitate;
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



    private void refreshTotaluri()
    {
        var colPret = getColumnByText(dgvVizComanda, "pret")!;
        var colKcal = getColumnByText(dgvVizComanda, "kcal")!;

        int sumKcal = 0;
        int sumPret = 0;
        foreach (DataGridViewRow row in dgvVizComanda.Rows)
        {
            int.TryParse(row.Cells["colCantitate"].Value?.ToString(), out var cantitate);
            int kcal = (int)row.Cells[colKcal.Index].Value!;
            int pret = (int)row.Cells[colPret.Index].Value!;
            sumKcal += cantitate * kcal;
            sumPret += cantitate * pret;
        }

        textBoxTotalKcalViz.Text = sumKcal.ToString();
        textBoxTotalPretViz.Text = sumPret.ToString();
    }



    private void dgvVizComanda_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex != getColumnByText(dgvVizComanda, headerCantitate)?.Index)
        {
            return;
        }

        refreshTotaluri();
    }

    private void dgvVizComanda_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        if (e.ColumnIndex == getColumnByText(dgvVizComanda, "colCantitate")!.Index)
        {
            MessageBox.Show("Cantitate invalida", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void dgvVizComanda_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        DataGridViewColumn? currColumn = null;
        foreach (DataGridViewColumn col in dgvVizComanda.Columns)
        {
            if (col.Index == e.ColumnIndex)
            {
                currColumn = col;
            }
        }
        if (currColumn?.HeaderText != "Elimina")
        {
            return;
        }

        dgvVizComanda_CellEliminaClick(e);
    }
}
