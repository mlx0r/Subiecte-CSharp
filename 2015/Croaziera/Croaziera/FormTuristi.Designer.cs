namespace Croaziera
{
    partial class FormTuristi
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
            labelCroaziera = new Label();
            comboBoxNrZile = new ComboBox();
            dataGridViewCroaziereTuristi = new DataGridView();
            labelPerioadaVoiaj = new Label();
            labelDataStart = new Label();
            labelDataFinal = new Label();
            buttonValidare = new Button();
            dateTimePickerStart = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCroaziereTuristi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCroaziera
            // 
            labelCroaziera.AutoSize = true;
            labelCroaziera.Location = new Point(11, 36);
            labelCroaziera.Margin = new Padding(2, 0, 2, 0);
            labelCroaziera.Name = "labelCroaziera";
            labelCroaziera.Size = new Size(147, 15);
            labelCroaziera.TabIndex = 0;
            labelCroaziera.Text = "Selectati tipul de croaziera:";
            // 
            // comboBoxNrZile
            // 
            comboBoxNrZile.FormattingEnabled = true;
            comboBoxNrZile.Items.AddRange(new object[] { "3 zile", "5 zile", "8 zile" });
            comboBoxNrZile.Location = new Point(162, 33);
            comboBoxNrZile.Margin = new Padding(2);
            comboBoxNrZile.Name = "comboBoxNrZile";
            comboBoxNrZile.Size = new Size(129, 23);
            comboBoxNrZile.TabIndex = 1;
            comboBoxNrZile.Text = "3 zile";
            comboBoxNrZile.SelectedIndexChanged += comboBoxNrZile_SelectedIndexChanged;
            // 
            // dataGridViewCroaziereTuristi
            // 
            dataGridViewCroaziereTuristi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCroaziereTuristi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCroaziereTuristi.Location = new Point(8, 70);
            dataGridViewCroaziereTuristi.Margin = new Padding(2);
            dataGridViewCroaziereTuristi.Name = "dataGridViewCroaziereTuristi";
            dataGridViewCroaziereTuristi.RowHeadersWidth = 62;
            dataGridViewCroaziereTuristi.Size = new Size(864, 496);
            dataGridViewCroaziereTuristi.TabIndex = 2;
            // 
            // labelPerioadaVoiaj
            // 
            labelPerioadaVoiaj.AutoSize = true;
            labelPerioadaVoiaj.Location = new Point(14, 13);
            labelPerioadaVoiaj.Margin = new Padding(2, 0, 2, 0);
            labelPerioadaVoiaj.Name = "labelPerioadaVoiaj";
            labelPerioadaVoiaj.Size = new Size(146, 15);
            labelPerioadaVoiaj.TabIndex = 3;
            labelPerioadaVoiaj.Text = "Stabiliti perioada voiajului:";
            // 
            // labelDataStart
            // 
            labelDataStart.AutoSize = true;
            labelDataStart.Location = new Point(14, 49);
            labelDataStart.Margin = new Padding(2, 0, 2, 0);
            labelDataStart.Name = "labelDataStart";
            labelDataStart.Size = new Size(63, 15);
            labelDataStart.TabIndex = 4;
            labelDataStart.Text = "Data start: ";
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Location = new Point(17, 89);
            labelDataFinal.Margin = new Padding(2, 0, 2, 0);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(60, 15);
            labelDataFinal.TabIndex = 5;
            labelDataFinal.Text = "Data final:";
            // 
            // buttonValidare
            // 
            buttonValidare.Location = new Point(67, 110);
            buttonValidare.Margin = new Padding(2);
            buttonValidare.Name = "buttonValidare";
            buttonValidare.Size = new Size(123, 26);
            buttonValidare.TabIndex = 6;
            buttonValidare.Text = "Validare";
            buttonValidare.UseVisualStyleBackColor = true;
            buttonValidare.Click += buttonValidare_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "dd MMMM yyyy";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(81, 49);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(162, 23);
            dateTimePickerStart.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(81, 83);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(166, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelPerioadaVoiaj);
            panel1.Controls.Add(buttonValidare);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(labelDataStart);
            panel1.Controls.Add(dateTimePickerStart);
            panel1.Controls.Add(labelDataFinal);
            panel1.Location = new Point(877, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 141);
            panel1.TabIndex = 9;
            // 
            // FormTuristi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 577);
            Controls.Add(panel1);
            Controls.Add(dataGridViewCroaziereTuristi);
            Controls.Add(comboBoxNrZile);
            Controls.Add(labelCroaziera);
            Margin = new Padding(2);
            Name = "FormTuristi";
            Text = "FormTuristi";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCroaziereTuristi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCroaziera;
        private ComboBox comboBoxNrZile;
        private DataGridView dataGridViewCroaziereTuristi;
        private Label labelPerioadaVoiaj;
        private Label labelDataStart;
        private Label labelDataFinal;
        private Button buttonValidare;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
    }
}