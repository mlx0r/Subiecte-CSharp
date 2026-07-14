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
                labelEroare.Text = "Va rugam sa introduceti un nume!";
                formularValid = false;
            }
            if(string.IsNullOrEmpty(textBoxPrenume.Text))
            {
                labelEroare.Text = "Va rugam sa introduceti un prenume!";
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
                labelEroare.Text = "Operatia de adaugare s-a finalizat cu success";
            }
        }
    }
}
