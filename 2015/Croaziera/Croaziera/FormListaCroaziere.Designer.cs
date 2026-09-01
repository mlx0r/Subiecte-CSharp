namespace Croaziera
{
    partial class FormListaCroaziere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelSelectieCroaziera = new Label();
            comboBoxTipCroaziera = new ComboBox();
            dataGridView1 = new DataGridView();
            buttonInchidereLista = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelSelectieCroaziera
            // 
            labelSelectieCroaziera.AutoSize = true;
            labelSelectieCroaziera.Location = new Point(78, 20);
            labelSelectieCroaziera.Margin = new Padding(2, 0, 2, 0);
            labelSelectieCroaziera.Name = "labelSelectieCroaziera";
            labelSelectieCroaziera.Size = new Size(147, 15);
            labelSelectieCroaziera.TabIndex = 0;
            labelSelectieCroaziera.Text = "Selectati tipul de croaziera:";
            // 
            // comboBoxTipCroaziera
            // 
            comboBoxTipCroaziera.FormattingEnabled = true;
            comboBoxTipCroaziera.Items.AddRange(new object[] { "3 zile", "5 zile", "8 zile" });
            comboBoxTipCroaziera.Location = new Point(295, 20);
            comboBoxTipCroaziera.Margin = new Padding(2, 2, 2, 2);
            comboBoxTipCroaziera.Name = "comboBoxTipCroaziera";
            comboBoxTipCroaziera.Size = new Size(129, 23);
            comboBoxTipCroaziera.TabIndex = 1;
            comboBoxTipCroaziera.Text = "3 zile";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 55);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(588, 163);
            dataGridView1.TabIndex = 2;
            // 
            // buttonInchidereLista
            // 
            buttonInchidereLista.Location = new Point(592, 236);
            buttonInchidereLista.Margin = new Padding(2, 2, 2, 2);
            buttonInchidereLista.Name = "buttonInchidereLista";
            buttonInchidereLista.Size = new Size(150, 20);
            buttonInchidereLista.TabIndex = 3;
            buttonInchidereLista.Text = "Inchidere";
            buttonInchidereLista.UseVisualStyleBackColor = true;
            buttonInchidereLista.Click += buttonInchidereLista_Click;
            // 
            // FormListaCroaziere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 270);
            Controls.Add(buttonInchidereLista);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxTipCroaziera);
            Controls.Add(labelSelectieCroaziera);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormListaCroaziere";
            Text = "FormListaCroaziere";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSelectieCroaziera;
        private ComboBox comboBoxTipCroaziera;
        private DataGridView dataGridView1;
        private Button buttonInchidereLista;
    }
}