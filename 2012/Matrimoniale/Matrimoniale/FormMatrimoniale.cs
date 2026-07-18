using Microsoft.Data.SqlClient;

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
        var conn = new SqlConnection();
        try
        {
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\CUG\\source\\repos\\Subiecte-CSharp\\2012\\Matrimoniale\\Matrimoniale\\DatabaseMatrimoniale.mdf;Integrated Security=True;Connect Timeout=30";
            conn.Open();

            var command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO Clienti (Nume, Prenume, Ocupatie, Varsta, Sex) VALUES ('"
                + persoana.Nume + "', '" + persoana.Prenume + "', '" + persoana.Ocupatie + "', " + persoana.Varsta + ", '" + persoana.Sex + 

                "') ";
            // ExecuteNonQuery pt orice comanda ce nu este un select
            command.ExecuteNonQuery();
            // INSERT INTO CLIENTI (NUME, PRENUME, OCUPATIE, VARSTA, SEX) VALUES (
            // 'Ionescu', 'Alin', 'Avocat', 24, 'M')

            MessageBox.Show(
           $"Am adaugat persoana {persoana.Nume} {persoana.Prenume} cu succes",
           "Persoana adaugata",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
            "Eroare in inserarea persoanei. " + ex.Message,
            "Eroare",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }
        finally
        {
            conn.Close();
        }


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

