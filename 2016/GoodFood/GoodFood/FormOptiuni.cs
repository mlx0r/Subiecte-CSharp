using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoodFood;

public partial class FormOptiuni : Form
{
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
    public class Meniu
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public int Pret { get; set; }
        public int Kcal { get; set; }
        public int Felul { get; set; }
    };
    List<Meniu> extrageMeniuriDinFisier()
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
        const string headerCantitate = "Cantitate";
        DataGridViewTextBoxColumn colCantitate = new()
        {
            HeaderText = headerCantitate,
            ReadOnly = false,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                NullValue = "0"
            }
        };
        dgvMeniuri.Columns.Add(colCantitate);
        DataGridViewButtonColumn colBtnAdauga = new()
        {
            UseColumnTextForButtonValue = true,
            Text = "Adauga",
            HeaderText = "Adauga"
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
    }
}
