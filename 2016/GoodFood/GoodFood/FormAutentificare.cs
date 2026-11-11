using Microsoft.Data.SqlClient;

namespace GoodFood;

public partial class FormAutentificare : Form
{
    public FormAutentificare()
    {
        InitializeComponent();
    }

    private void buttonIntraInCont_Click(object sender, EventArgs e)
    {
        if (!esteValidUserul())
        {
            MessageBox.Show("Email sau parola incorecta!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            
        }
        var email = textBoxEmail.Text;
        //var user = new UserLogged();
        UserLogged.Current.Email = email;
        obtineDateDB();
        var formOptiuni = new FormOptiuni();
        this.Hide();
        formOptiuni.Show();
    }
    private void obtineDateDB()
    {
        var conn = new SqlConnection
        {
            ConnectionString = Utils.ConnStr
        };
        conn.Open();
        var cmd = new SqlCommand
        {
            CommandText = "SELECT kcal_zilnice FROM Clienti WHERE email=@email",
            Connection = conn
        };
        cmd.Parameters.AddWithValue("@email", UserLogged.Current.Email);
        var kcal = cmd.ExecuteScalar();
        UserLogged.Current.Kcal = Convert.ToInt32(kcal);
    }
    private bool esteValidUserul()
    {
        var email = textBoxEmail.Text;
        var pass = textBoxPass.Text;
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
        {
            MessageBox.Show("Introduceti atat un email cat si o parola");
            return false;
        }

        var conn = new SqlConnection
        {
            ConnectionString = Utils.ConnStr
        };
        conn.Open();
        var cmd = new SqlCommand
        {
            CommandText = "SELECT COUNT(*) FROM Clienti WHERE email=@email AND parola=@parola",
            Connection = conn
        };
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@parola", pass);
       
        var existaUseri = (int)cmd.ExecuteScalar();
        if(existaUseri != 1)
        {
            return false;
        }
        
        return true;
    }

    private void FormAutentificare_Load(object sender, EventArgs e)
    {

    }
}
