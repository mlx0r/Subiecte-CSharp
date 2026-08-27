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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            buttonInchidereLista = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelSelectieCroaziera
            // 
            labelSelectieCroaziera.AutoSize = true;
            labelSelectieCroaziera.Location = new Point(111, 33);
            labelSelectieCroaziera.Name = "labelSelectieCroaziera";
            labelSelectieCroaziera.Size = new Size(221, 25);
            labelSelectieCroaziera.TabIndex = 0;
            labelSelectieCroaziera.Text = "Selectati tipul de croaziera:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "3 zile", "5 zile", "8 zile" });
            comboBox1.Location = new Point(422, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "5 zile";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(840, 272);
            dataGridView1.TabIndex = 2;
            // 
            // buttonInchidereLista
            // 
            buttonInchidereLista.Location = new Point(845, 393);
            buttonInchidereLista.Name = "buttonInchidereLista";
            buttonInchidereLista.Size = new Size(214, 34);
            buttonInchidereLista.TabIndex = 3;
            buttonInchidereLista.Text = "Inchidere";
            buttonInchidereLista.UseVisualStyleBackColor = true;
            buttonInchidereLista.Click += buttonInchidereLista_Click;
            // 
            // FormListaCroaziere
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 450);
            Controls.Add(buttonInchidereLista);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(labelSelectieCroaziera);
            Name = "FormListaCroaziere";
            Text = "FormListaCroaziere";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSelectieCroaziera;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button buttonInchidereLista;
    }
}