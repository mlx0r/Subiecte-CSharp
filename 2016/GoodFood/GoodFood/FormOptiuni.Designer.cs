namespace GoodFood
{
    partial class FormOptiuni
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
            tabControl1 = new TabControl();
            tabPageCalcKcal = new TabPage();
            tabPageComanda = new TabPage();
            tabPageGenMeniu = new TabPage();
            tabPageGraficKcal = new TabPage();
            labelVarsta = new Label();
            labelInaltime = new Label();
            labelGreutate = new Label();
            labelKcalNecesari = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            buttonCalcKcal = new Button();
            tabControl1.SuspendLayout();
            tabPageCalcKcal.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCalcKcal);
            tabControl1.Controls.Add(tabPageComanda);
            tabControl1.Controls.Add(tabPageGenMeniu);
            tabControl1.Controls.Add(tabPageGraficKcal);
            tabControl1.Location = new Point(12, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 313);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCalcKcal
            // 
            tabPageCalcKcal.Controls.Add(buttonCalcKcal);
            tabPageCalcKcal.Controls.Add(textBox4);
            tabPageCalcKcal.Controls.Add(textBox3);
            tabPageCalcKcal.Controls.Add(textBox2);
            tabPageCalcKcal.Controls.Add(textBox1);
            tabPageCalcKcal.Controls.Add(labelKcalNecesari);
            tabPageCalcKcal.Controls.Add(labelGreutate);
            tabPageCalcKcal.Controls.Add(labelInaltime);
            tabPageCalcKcal.Controls.Add(labelVarsta);
            tabPageCalcKcal.Location = new Point(4, 34);
            tabPageCalcKcal.Name = "tabPageCalcKcal";
            tabPageCalcKcal.Padding = new Padding(3);
            tabPageCalcKcal.Size = new Size(768, 275);
            tabPageCalcKcal.TabIndex = 0;
            tabPageCalcKcal.Text = "CalculatorKcal";
            tabPageCalcKcal.UseVisualStyleBackColor = true;
            // 
            // tabPageComanda
            // 
            tabPageComanda.Location = new Point(4, 34);
            tabPageComanda.Name = "tabPageComanda";
            tabPageComanda.Padding = new Padding(3);
            tabPageComanda.Size = new Size(449, 275);
            tabPageComanda.TabIndex = 1;
            tabPageComanda.Text = "Comanda";
            tabPageComanda.UseVisualStyleBackColor = true;
            // 
            // tabPageGenMeniu
            // 
            tabPageGenMeniu.Location = new Point(4, 34);
            tabPageGenMeniu.Name = "tabPageGenMeniu";
            tabPageGenMeniu.Size = new Size(449, 275);
            tabPageGenMeniu.TabIndex = 2;
            tabPageGenMeniu.Text = "Generare Meniu";
            tabPageGenMeniu.UseVisualStyleBackColor = true;
            // 
            // tabPageGraficKcal
            // 
            tabPageGraficKcal.Location = new Point(4, 34);
            tabPageGraficKcal.Name = "tabPageGraficKcal";
            tabPageGraficKcal.Size = new Size(449, 275);
            tabPageGraficKcal.TabIndex = 3;
            tabPageGraficKcal.Text = "Grafic Kcal";
            tabPageGraficKcal.UseVisualStyleBackColor = true;
            // 
            // labelVarsta
            // 
            labelVarsta.AutoSize = true;
            labelVarsta.Location = new Point(28, 29);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(98, 25);
            labelVarsta.TabIndex = 0;
            labelVarsta.Text = "Varsta (ani)";
            // 
            // labelInaltime
            // 
            labelInaltime.AutoSize = true;
            labelInaltime.Location = new Point(28, 76);
            labelInaltime.Name = "labelInaltime";
            labelInaltime.Size = new Size(114, 25);
            labelInaltime.TabIndex = 1;
            labelInaltime.Text = "Inaltime (cm)";
            // 
            // labelGreutate
            // 
            labelGreutate.AutoSize = true;
            labelGreutate.Location = new Point(28, 125);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(114, 25);
            labelGreutate.TabIndex = 2;
            labelGreutate.Text = "Greutate (kg)";
            // 
            // labelKcalNecesari
            // 
            labelKcalNecesari.AutoSize = true;
            labelKcalNecesari.Location = new Point(441, 125);
            labelKcalNecesari.Name = "labelKcalNecesari";
            labelKcalNecesari.Size = new Size(117, 25);
            labelKcalNecesari.TabIndex = 3;
            labelKcalNecesari.Text = "Necesar zilnic";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(574, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 73);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // buttonCalcKcal
            // 
            buttonCalcKcal.Location = new Point(106, 201);
            buttonCalcKcal.Name = "buttonCalcKcal";
            buttonCalcKcal.Size = new Size(112, 34);
            buttonCalcKcal.TabIndex = 8;
            buttonCalcKcal.Text = "Calculeaza";
            buttonCalcKcal.UseVisualStyleBackColor = true;
            // 
            // FormOptiuni
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormOptiuni";
            Text = "Optiuni";
            tabControl1.ResumeLayout(false);
            tabPageCalcKcal.ResumeLayout(false);
            tabPageCalcKcal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCalcKcal;
        private TabPage tabPageComanda;
        private TabPage tabPageGenMeniu;
        private TabPage tabPageGraficKcal;
        private Button buttonCalcKcal;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelKcalNecesari;
        private Label labelGreutate;
        private Label labelInaltime;
        private Label labelVarsta;
    }
}