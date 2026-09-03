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

        var formOptiuni = new FormOptiuni();
        this.Hide();
        formOptiuni.Show();
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
        // TODO: COUNT(*) PT users cu matching email si pw
        var cmd = new SqlCommand
        {
            CommandText = ""
        };
        
        return true;
    }

    private void FormAutentificare_Load(object sender, EventArgs e)
    {

    }
}
