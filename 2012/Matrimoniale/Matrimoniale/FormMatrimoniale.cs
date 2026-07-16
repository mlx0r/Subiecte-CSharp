namespace Matrimoniale;


public partial class FormMatrimoniale : Form
{
    public FormMatrimoniale()
    {
        InitializeComponent();
        comboBoxSex.SelectedIndex = 0;
    }

    private void buttonAdaugarePers_Click(object sender, EventArgs e)
    {
        var esteValid = Validare(out var mesajEroare);
        if (!esteValid)
        {
            labelEroare.Text = mesajEroare;
            return;
        }
        var persoana = new Persoana(textBoxNume.Text, textBoxPrenume.Text, textBoxOcupatie.Text, comboBoxSex.Text, numericUpDownVarsta.Value);
        AdaugarePersoana(persoana);

        //if (formularValid)
        //{
        //    labelEroare.Text = "Operatia de adaugare s-a finalizat cu succes";
        //}
    }

    private bool Validare(out string mesajEroare)
    {
        if (string.IsNullOrEmpty(textBoxNume.Text) ||
            string.IsNullOrEmpty(textBoxPrenume.Text) ||
            string.IsNullOrEmpty(textBoxOcupatie.Text) ||
            string.IsNullOrEmpty(comboBoxSex.Text)
        )
        {
            mesajEroare = "Date invalide. Verificati campurile incomplete.";
            return false;
        }
        if (string.IsNullOrEmpty(textBoxPrenume.Text))
        {
            mesajEroare = "";
            return false;
        }

        if (areCifra(textBoxNume.Text))
        {
            mesajEroare = "Numele poate contine doar litere!";
            return false;
        }
        if (areCifra(textBoxPrenume.Text))
        {
            mesajEroare = "Prenumele poate contine doar litere!";
            return false;
        }
        if (numericUpDownVarsta.Value < 18)
        {
            mesajEroare = "Trebuie sa aveti cel putin 18 ani pentru a va inregistra";
            return false;
        }

        mesajEroare = "";
        return true;
    }

    private void AdaugarePersoana(Persoana persoana)
    {
        MessageBox.Show(
            $"Am adaugat persoana {persoana.Nume} {persoana.Prenume} cu succes",
            "Persoana adaugata",
            MessageBoxButtons.OK, 
            MessageBoxIcon.Information);
    }

    private bool areCifra(string s)
    {
        foreach (char c in s)
        {
            if (char.IsDigit(c))
                return true;
        }
        return false;
    }
}

