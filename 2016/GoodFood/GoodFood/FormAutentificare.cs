using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GoodFood
{
    public partial class FormAutentificare : Form
    {
        public FormAutentificare()
        {
            InitializeComponent();
        }

        private void buttonIntraInCont_Click(object sender, EventArgs e)
        {
            if(valideazaUtilizator())
            {
                FormOptiuni formOptiuni = new FormOptiuni();
                this.Hide();
                formOptiuni.Show();
            }
            else
            {
                MessageBox.Show("Email sau parola incorecta!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool valideazaUtilizator()
        {
            // testing purposes -- return true;
        }
    }
}
