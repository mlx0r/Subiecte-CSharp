namespace Croaziera;
using Microsoft.Data.SqlClient;

public partial class FormAutentificare : Form
{
    public FormAutentificare()
    {
        InitializeComponent();
    }

    private void buttonAutentificare_Click(object sender, EventArgs e)
    {
        string utilizator = textBoxUtilizator.Text;
        string parola = textBoxParola.Text;
        if (utilizator == "Administrator" && parola == "agentie2015")
        {
            this.Hide();
            FormAdministrare formAdmin = new FormAdministrare();
            formAdmin.Show();
        }
        else if(utilizator == "Turisti" && parola == "oti2015")
        {
            this.Hide();
            FormTuristi formTurist = new FormTuristi();
            formTurist.Show();
        }
        else
        {
            MessageBox.Show("Utilizator sau parola incorecta!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}

