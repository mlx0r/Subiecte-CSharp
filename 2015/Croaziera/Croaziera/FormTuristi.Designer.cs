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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            labelPerioadaVoiaj = new Label();
            labelDataStart = new Label();
            labelDataFinal = new Label();
            buttonValidare = new Button();
            dateTimePickerStart = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelCroaziera
            // 
            labelCroaziera.AutoSize = true;
            labelCroaziera.Location = new Point(107, 46);
            labelCroaziera.Name = "labelCroaziera";
            labelCroaziera.Size = new Size(221, 25);
            labelCroaziera.TabIndex = 0;
            labelCroaziera.Text = "Selectati tipul de croaziera:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "3 zile", "5 zile", "8 zile" });
            comboBox1.Location = new Point(395, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "3 zile";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(750, 264);
            dataGridView1.TabIndex = 2;
            // 
            // labelPerioadaVoiaj
            // 
            labelPerioadaVoiaj.AutoSize = true;
            labelPerioadaVoiaj.Location = new Point(800, 76);
            labelPerioadaVoiaj.Name = "labelPerioadaVoiaj";
            labelPerioadaVoiaj.Size = new Size(218, 25);
            labelPerioadaVoiaj.TabIndex = 3;
            labelPerioadaVoiaj.Text = "Stabiliti perioada voiajului:";
            // 
            // labelDataStart
            // 
            labelDataStart.AutoSize = true;
            labelDataStart.Location = new Point(800, 163);
            labelDataStart.Name = "labelDataStart";
            labelDataStart.Size = new Size(98, 25);
            labelDataStart.TabIndex = 4;
            labelDataStart.Text = "Data start: ";
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Location = new Point(800, 245);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(91, 25);
            labelDataFinal.TabIndex = 5;
            labelDataFinal.Text = "Data final:";
            // 
            // buttonValidare
            // 
            buttonValidare.Location = new Point(874, 317);
            buttonValidare.Name = "buttonValidare";
            buttonValidare.Size = new Size(176, 44);
            buttonValidare.TabIndex = 6;
            buttonValidare.Text = "Validare";
            buttonValidare.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "dd MMMM yyyy";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(897, 163);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(229, 31);
            dateTimePickerStart.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(897, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // FormTuristi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePickerStart);
            Controls.Add(buttonValidare);
            Controls.Add(labelDataFinal);
            Controls.Add(labelDataStart);
            Controls.Add(labelPerioadaVoiaj);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(labelCroaziera);
            Name = "FormTuristi";
            Text = "FormTuristi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCroaziera;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label labelPerioadaVoiaj;
        private Label labelDataStart;
        private Label labelDataFinal;
        private Button buttonValidare;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePicker1;
    }
}