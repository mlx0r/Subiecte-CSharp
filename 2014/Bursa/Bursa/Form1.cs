namespace Bursa
{
    public partial class FormBursa : Form
    {
        public FormBursa()
        {
            InitializeComponent();
        }

        private void FormBursa_Load(object sender, EventArgs e)
        {

        }
        private void utilizatorMenu_MouseEnter(object sender, EventArgs e)
        {
            utilizatorMenu.ShowDropDown();
        }
    }
}
