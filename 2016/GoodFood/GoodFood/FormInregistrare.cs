using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GoodFood
{
    public partial class FormInregistrare : Form
    {
        public FormInregistrare()
        {
            InitializeComponent();
        }

        private void buttonCreareCont_Click(object sender, EventArgs e)
        {
            adaugareContInDB();
            FormAutentificare formAut = new FormAutentificare();
            this.Hide();
            formAut.Show();
        }

        private void adaugareContInDB()
        {
            
        }
    }
}
