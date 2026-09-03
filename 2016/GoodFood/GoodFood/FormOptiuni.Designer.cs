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
            buttonCalcKcal = new Button();
            textBoxInaltime = new TextBox();
            textBoxGreutate = new TextBox();
            textBoxNecesarKcal = new TextBox();
            textBoxAni = new TextBox();
            labelKcalNecesari = new Label();
            labelGreutate = new Label();
            labelInaltime = new Label();
            labelVarsta = new Label();
            tabPageComanda = new TabPage();
            tabPageGenMeniu = new TabPage();
            tabPageGraficKcal = new TabPage();
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
            tabPageCalcKcal.Controls.Add(textBoxInaltime);
            tabPageCalcKcal.Controls.Add(textBoxGreutate);
            tabPageCalcKcal.Controls.Add(textBoxNecesarKcal);
            tabPageCalcKcal.Controls.Add(textBoxAni);
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
            // buttonCalcKcal
            // 
            buttonCalcKcal.Location = new Point(106, 201);
            buttonCalcKcal.Name = "buttonCalcKcal";
            buttonCalcKcal.Size = new Size(112, 34);
            buttonCalcKcal.TabIndex = 8;
            buttonCalcKcal.Text = "Calculeaza";
            buttonCalcKcal.UseVisualStyleBackColor = true;
            buttonCalcKcal.Click += buttonCalcKcal_Click;
            // 
            // textBoxInaltime
            // 
            textBoxInaltime.Location = new Point(171, 73);
            textBoxInaltime.Name = "textBoxInaltime";
            textBoxInaltime.Size = new Size(150, 31);
            textBoxInaltime.TabIndex = 7;
            // 
            // textBoxGreutate
            // 
            textBoxGreutate.Location = new Point(171, 122);
            textBoxGreutate.Name = "textBoxGreutate";
            textBoxGreutate.Size = new Size(150, 31);
            textBoxGreutate.TabIndex = 6;
            // 
            // textBoxNecesarKcal
            // 
            textBoxNecesarKcal.Location = new Point(574, 119);
            textBoxNecesarKcal.Name = "textBoxNecesarKcal";
            textBoxNecesarKcal.Size = new Size(150, 31);
            textBoxNecesarKcal.TabIndex = 5;
            // 
            // textBoxAni
            // 
            textBoxAni.Location = new Point(171, 26);
            textBoxAni.Name = "textBoxAni";
            textBoxAni.Size = new Size(150, 31);
            textBoxAni.TabIndex = 4;
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
            // labelGreutate
            // 
            labelGreutate.AutoSize = true;
            labelGreutate.Location = new Point(28, 125);
            labelGreutate.Name = "labelGreutate";
            labelGreutate.Size = new Size(114, 25);
            labelGreutate.TabIndex = 2;
            labelGreutate.Text = "Greutate (kg)";
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
            // labelVarsta
            // 
            labelVarsta.AutoSize = true;
            labelVarsta.Location = new Point(28, 29);
            labelVarsta.Name = "labelVarsta";
            labelVarsta.Size = new Size(98, 25);
            labelVarsta.TabIndex = 0;
            labelVarsta.Text = "Varsta (ani)";
            // 
            // tabPageComanda
            // 
            tabPageComanda.Location = new Point(4, 34);
            tabPageComanda.Name = "tabPageComanda";
            tabPageComanda.Padding = new Padding(3);
            tabPageComanda.Size = new Size(768, 275);
            tabPageComanda.TabIndex = 1;
            tabPageComanda.Text = "Comanda";
            tabPageComanda.UseVisualStyleBackColor = true;
            // 
            // tabPageGenMeniu
            // 
            tabPageGenMeniu.Location = new Point(4, 34);
            tabPageGenMeniu.Name = "tabPageGenMeniu";
            tabPageGenMeniu.Size = new Size(768, 275);
            tabPageGenMeniu.TabIndex = 2;
            tabPageGenMeniu.Text = "Generare Meniu";
            tabPageGenMeniu.UseVisualStyleBackColor = true;
            // 
            // tabPageGraficKcal
            // 
            tabPageGraficKcal.Location = new Point(4, 34);
            tabPageGraficKcal.Name = "tabPageGraficKcal";
            tabPageGraficKcal.Size = new Size(768, 275);
            tabPageGraficKcal.TabIndex = 3;
            tabPageGraficKcal.Text = "Grafic Kcal";
            tabPageGraficKcal.UseVisualStyleBackColor = true;
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
        private TextBox textBoxInaltime;
        private TextBox textBoxGreutate;
        private TextBox textBoxNecesarKcal;
        private TextBox textBoxAni;
        private Label labelKcalNecesari;
        private Label labelGreutate;
        private Label labelInaltime;
        private Label labelVarsta;
    }
}