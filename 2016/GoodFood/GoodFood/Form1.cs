namespace GoodFood
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            FormInregistrare formInregistrare = new FormInregistrare();
            formInregistrare.Show();
            this.Hide();
        }

        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            FormAutentificare formAutentificare = new FormAutentificare();
            formAutentificare.Show();
            this.Hide();
        }
    }
}
