namespace Matrimoniale
{
    public partial class FormMatrimoniale : Form
    {
        public FormMatrimoniale()
        {
            InitializeComponent();
            comboBoxSex.SelectedIndex = 0;
        }

        private void buttonAdaugarePers_Click(object sender, EventArgs e)
        {
            bool formularValid = true;
            labelEroare.Text = "";
            if (string.IsNullOrEmpty(textBoxNume.Text))
            {
                labelEroare.Text = "Date invalide. Verificati campurile incomplete.";
                formularValid = false;
            }
            if(string.IsNullOrEmpty(textBoxPrenume.Text))
            {
                labelEroare.Text = "Date invalide. Verificati campurile incomplete.";
                formularValid = false;
            }
            if(string.IsNullOrEmpty(numericUpDownVarsta.Text))
            {
                labelEroare.Text = "Date invalide. Verificati campurile incomplete.";
                formularValid = false;
            }
            if(string.IsNullOrEmpty(comboBoxSex.Text))
            {
                labelEroare.Text = "Date invalide. Verificati campurile incomplete.";
                formularValid = false;
            }
            if(string.IsNullOrEmpty(textBoxOcupatie.Text))
            {
                labelEroare.Text = "Date invalide. Verificati campurile incomplete.";
                formularValid = false;
            }
            
            bool areCifInNume = false;
            foreach (char caracter in textBoxNume.Text)
            {
                if (char.IsDigit(caracter))
                {
                    areCifInNume = true;
                    formularValid = false;
                    break;
                }
            }
            if (areCifInNume)
            {
                labelEroare.Text = "Numele poate contine doar litere!";
            }

            bool areCifInPrenume = false;
            foreach (char caracter in textBoxPrenume.Text)
            {
                if (char.IsDigit(caracter))
                {
                    areCifInPrenume = true;
                    formularValid = false;
                    break;
                }
            }
            if (areCifInPrenume)
            {
                labelEroare.Text = "Prenumele poate contine doar litere!";
            }
            if(formularValid)
            {
                if(numericUpDownVarsta.Value < 18)
                {
                    labelEroare.Text = "Trebuie sa aveti cel putin 18 ani pentru a va inregistra";
                    formularValid = false;
                }
            }

            if(formularValid)
            {
                labelEroare.Text = "Operatia de adaugare s-a finalizat cu succes";
            }
        }
    }
}
