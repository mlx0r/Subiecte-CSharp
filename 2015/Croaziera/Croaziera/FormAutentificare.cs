namespace Croaziera;

public partial class FormAutentificare : Form
{
    public FormAutentificare()
    {
        InitializeComponent();
    }

    private void buttonAutentificare_Click(object sender, EventArgs e)
    {
        var utilizator = textBoxUtilizator.Text;
        var parola = textBoxParola.Text;
        if (utilizator == "Administrator" && parola == "agentie2015")
        {
            this.Hide();
            FormAdministrare formAdmin = new();
            formAdmin.Show();
        }
        else if (utilizator == "Turist" && parola == "oti2015")
        {
            this.Hide();
            FormTuristi formTurist = new();
            formTurist.Show();
        }
        else
        {
            MessageBox.Show("Utilizator sau parola incorecta!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxUtilizator_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            textBoxParola.Focus();
        }
    }

    private void textBoxParola_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            buttonAutentificare.PerformClick();
        }
    }
}

