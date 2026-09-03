using Microsoft.Data.SqlClient;

namespace GoodFood;

public partial class FormInregistrare : Form
{
    public FormInregistrare()
    {
        InitializeComponent();
    }

    private void buttonCreareCont_Click(object sender, EventArgs e)
    {
        if (!adaugareContInDB())
        {
            return;
        }

        var formAut = new FormAutentificare();
        this.Hide();
        formAut.Show();
    }

    private bool adaugareContInDB()
    {
        var nume = textBoxNume.Text;
        var prenume = textBoxPrenume.Text;
        var adresa = textBoxAdresa.Text;
        var parola = textBoxParola.Text;
        var reParola = textBoxParola.Text;
        var email = textBoxEmail.Text;

        var eroare = Validare(nume, prenume, adresa, parola, reParola, email);
        if (eroare != null)
        {
            MessageBox.Show(eroare, "Inregistrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        CreareUserInDb(nume, prenume, adresa, parola, email);
        return true;
    }

    private void CreareUserInDb(string nume, string prenume, string adresa, string parola, string email)
    {
        if (ExistaEmailInDB(email))
        {
            MessageBox.Show(
                "Email-ul este deja in utilizare", "Eroare",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        InserareUser(nume, prenume, adresa, parola, email);
    }

    private void InserareUser(string nume, string prenume, string adresa, string parola, string email)
    {
        var conn = new SqlConnection
        {
            ConnectionString = Utils.ConnStr
        };
        conn.Open();

        var cmd = new SqlCommand
        {
            CommandText =
            """
            insert into Clienti (parola, nume, prenume, adresa, email)
            values (@parola, @nume, @prenume, @adresa, @email)
            """,
            Connection = conn
        };
        cmd.Parameters.AddWithValue("@parola", parola);
        cmd.Parameters.AddWithValue("@nume", nume);
        cmd.Parameters.AddWithValue("@prenume", prenume);
        cmd.Parameters.AddWithValue("@adresa", adresa);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.ExecuteNonQuery();
    }

    private bool ExistaEmailInDB(string email)
    {
        var conn = new SqlConnection
        {
            ConnectionString = Utils.ConnStr
        };
        conn.Open();

        var cmd = new SqlCommand
        {
            CommandText = "SELECT COUNT(*) FROM Clienti WHERE email = @email",
            Connection = conn,

        };
        cmd.Parameters.AddWithValue("@email", email);
        var useriCuAcestEmail = (int)cmd.ExecuteScalar();
        return useriCuAcestEmail != 0;
    }

    private string? Validare(string nume, string prenume, string adresa, string parola, string reParola, string email)
    {
        string[] inputs = [nume, prenume, adresa, parola, reParola, email];
        foreach (string camp in inputs)
        {
            if (string.IsNullOrWhiteSpace(camp))
            {
                return "Introdu o valoare in toate campurile";
            }
        }
        if (parola != reParola)
        {
            return "Parolele trebuie sa fie identice";
        }
        // validare email - sa continta @; si macar un caracter la stanga @-ului; la dreapta @-ului un '.' ce separa doua stringuri de macar 1 caracter;
        const string eroareEmail = "Email invalid";
        if (!email.Contains("@"))
        {
            return eroareEmail;
        }
        var tokens = email.Split("@", StringSplitOptions.RemoveEmptyEntries);
        if (tokens.Length != 2)
        {
            return eroareEmail;
        }
        int indexPunct = tokens[1].IndexOf('.');
        if (indexPunct == -1 || indexPunct == 0 || indexPunct == tokens[1].Length - 1)
        {
            return eroareEmail;
        }

        return null;
    }
}
