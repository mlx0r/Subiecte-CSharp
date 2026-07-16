namespace Matrimoniale
{
    partial class FormMatrimoniale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFormularAdaugare = new Label();
            labelSex = new Label();
            labelVarsta = new Label();
            labelNume = new Label();
            labelPrenume = new Label();
            labelOcupatie = new Label();
            label1 = new Label();
            textBoxNume = new TextBox();
            textBoxPrenume = new TextBox();
            textBoxOcupatie = new TextBox();
            numericUpDownVarsta = new NumericUpDown();
            comboBoxSex = new ComboBox();
            buttonAdaugarePers = new Button();
            buttonVarstaMedie = new Button();
            labelEroare = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVarsta).BeginInit();
            SuspendLayout();
            // 
            // labelFormularAdaugare
            // 
            labelFormularAdaugare.AutoSize = true;
            labelFormularAdaugare.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFormularAdaugare.Location = new Point(59, 163);
            labelFormularAdaugare.Name = "labelFormularAdaugare";
            labelFormularAdaugare.Size = new Size(166, 20);
            labelFormularAdaugare.TabIndex = 0;
            labelFormularAdaugare.Text = "Formular de adaugare";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSex.Location = new Point(59, 444);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(35, 20);
            labelSex.TabIndex = 1;
            labelSex.Text = "Sex";
            // 
            // labelVarsta
            // 
            labelVarsta.AutoSize = true;
            labelVarsta.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVarsta.Location = new Point(59, 372);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(53, 20);
            labelVarsta.TabIndex = 2;
            labelVarsta.Text = "Varsta";
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNume.Location = new Point(59, 229);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(53, 20);
            labelNume.TabIndex = 3;
            labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            labelPrenume.AutoSize = true;
            labelPrenume.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrenume.Location = new Point(59, 299);
            labelPrenume.Name = "labelPrenume";
            labelPrenume.Size = new Size(74, 20);
            labelPrenume.TabIndex = 4;
            labelPrenume.Text = "Prenume";
            // 
            // labelOcupatie
            // 
            labelOcupatie.AutoSize = true;
            labelOcupatie.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOcupatie.Location = new Point(59, 517);
            labelOcupatie.Name = "labelOcupatie";
            labelOcupatie.Size = new Size(73, 20);
            labelOcupatie.TabIndex = 5;
            labelOcupatie.Text = "Ocupatie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(959, 102);
            label1.Name = "label1";
            label1.Size = new Size(219, 20);
            label1.TabIndex = 6;
            label1.Text = "Agentie de recrutare personal";
            // 
            // textBoxNume
            // 
            textBoxNume.Location = new Point(164, 223);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(150, 31);
            textBoxNume.TabIndex = 7;
            // 
            // textBoxPrenume
            // 
            textBoxPrenume.Location = new Point(164, 293);
            textBoxPrenume.Name = "textBoxPrenume";
            textBoxPrenume.Size = new Size(150, 31);
            textBoxPrenume.TabIndex = 8;
            // 
            // textBoxOcupatie
            // 
            textBoxOcupatie.Location = new Point(164, 511);
            textBoxOcupatie.Name = "textBoxOcupatie";
            textBoxOcupatie.Size = new Size(150, 31);
            textBoxOcupatie.TabIndex = 10;
            // 
            // numericUpDownVarsta
            // 
            numericUpDownVarsta.Location = new Point(164, 366);
            numericUpDownVarsta.Name = "numericUpDownVarsta";
            numericUpDownVarsta.Size = new Size(150, 31);
            numericUpDownVarsta.TabIndex = 11;
            // 
            // comboBoxSex
            // 
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Items.AddRange(new object[] { "Feminin", "Masculin" });
            comboBoxSex.Location = new Point(164, 436);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(150, 33);
            comboBoxSex.TabIndex = 12;
            // 
            // buttonAdaugarePers
            // 
            buttonAdaugarePers.Location = new Point(103, 659);
            buttonAdaugarePers.Name = "buttonAdaugarePers";
            buttonAdaugarePers.Size = new Size(250, 34);
            buttonAdaugarePers.TabIndex = 13;
            buttonAdaugarePers.Text = "Adaugare persoana";
            buttonAdaugarePers.UseVisualStyleBackColor = true;
            buttonAdaugarePers.Click += buttonAdaugarePers_Click;
            // 
            // buttonVarstaMedie
            // 
            buttonVarstaMedie.Location = new Point(103, 763);
            buttonVarstaMedie.Name = "buttonVarstaMedie";
            buttonVarstaMedie.Size = new Size(250, 34);
            buttonVarstaMedie.TabIndex = 14;
            buttonVarstaMedie.Text = "Varsta medie";
            buttonVarstaMedie.UseVisualStyleBackColor = true;
            // 
            // labelEroare
            // 
            labelEroare.AutoSize = true;
            labelEroare.Location = new Point(418, 698);
            labelEroare.Name = "labelEroare";
            labelEroare.Size = new Size(0, 25);
            labelEroare.TabIndex = 15;
            // 
            // FormMatrimoniale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1433, 883);
            Controls.Add(labelEroare);
            Controls.Add(buttonVarstaMedie);
            Controls.Add(buttonAdaugarePers);
            Controls.Add(comboBoxSex);
            Controls.Add(numericUpDownVarsta);
            Controls.Add(textBoxOcupatie);
            Controls.Add(textBoxPrenume);
            Controls.Add(textBoxNume);
            Controls.Add(label1);
            Controls.Add(labelOcupatie);
            Controls.Add(labelPrenume);
            Controls.Add(labelNume);
            Controls.Add(labelVarsta);
            Controls.Add(labelSex);
            Controls.Add(labelFormularAdaugare);
            Name = "FormMatrimoniale";
            Text = "Matrimoniale";
            ((System.ComponentModel.ISupportInitialize)numericUpDownVarsta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFormularAdaugare;
        private Label labelSex;
        private Label labelVarsta;
        private Label labelNume;
        private Label labelPrenume;
        private Label labelOcupatie;
        private Label label1;
        private TextBox textBoxNume;
        private TextBox textBoxPrenume;
        private TextBox textBoxOcupatie;
        private NumericUpDown numericUpDownVarsta;
        private ComboBox comboBoxSex;
        private Button buttonAdaugarePers;
        private Button buttonVarstaMedie;
        private Label labelEroare;
    }
}
