using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Croaziera;

    public partial class FormListaCroaziere : Form
    {
        public FormListaCroaziere()
        {
            InitializeComponent();
        }

        private void buttonInchidereLista_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAutentificare FormInit = new FormAutentificare();
            FormInit.Show();
        }
    }

