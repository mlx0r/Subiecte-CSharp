namespace GoodFood;

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
        tabControlOptiuni = new TabControl();
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
        labelNecesarKcal = new Label();
        dgvMeniuri = new DataGridView();
        tabPageGenMeniu = new TabPage();
        tabPageGraficKcal = new TabPage();
        labelTotalKcal = new Label();
        labelPretTotal = new Label();
        textBoxKcal = new TextBox();
        textBoxTotalKcal = new TextBox();
        textBoxPretTotal = new TextBox();
        buttonComanda = new Button();
        tabControlOptiuni.SuspendLayout();
        tabPageCalcKcal.SuspendLayout();
        tabPageComanda.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMeniuri).BeginInit();
        SuspendLayout();
        // 
        // tabControlOptiuni
        // 
        tabControlOptiuni.Controls.Add(tabPageCalcKcal);
        tabControlOptiuni.Controls.Add(tabPageComanda);
        tabControlOptiuni.Controls.Add(tabPageGenMeniu);
        tabControlOptiuni.Controls.Add(tabPageGraficKcal);
        tabControlOptiuni.Location = new Point(8, 35);
        tabControlOptiuni.Margin = new Padding(2);
        tabControlOptiuni.Name = "tabControlOptiuni";
        tabControlOptiuni.SelectedIndex = 0;
        tabControlOptiuni.Size = new Size(869, 639);
        tabControlOptiuni.TabIndex = 0;
        tabControlOptiuni.SelectedIndexChanged += tabControlOptiuni_SelectedIndexChanged;
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
        tabPageCalcKcal.Location = new Point(4, 24);
        tabPageCalcKcal.Margin = new Padding(2);
        tabPageCalcKcal.Name = "tabPageCalcKcal";
        tabPageCalcKcal.Padding = new Padding(2);
        tabPageCalcKcal.Size = new Size(861, 611);
        tabPageCalcKcal.TabIndex = 0;
        tabPageCalcKcal.Text = "CalculatorKcal";
        tabPageCalcKcal.UseVisualStyleBackColor = true;
        // 
        // buttonCalcKcal
        // 
        buttonCalcKcal.Location = new Point(74, 121);
        buttonCalcKcal.Margin = new Padding(2);
        buttonCalcKcal.Name = "buttonCalcKcal";
        buttonCalcKcal.Size = new Size(78, 20);
        buttonCalcKcal.TabIndex = 8;
        buttonCalcKcal.Text = "Calculeaza";
        buttonCalcKcal.UseVisualStyleBackColor = true;
        buttonCalcKcal.Click += buttonCalcKcal_Click;
        // 
        // textBoxInaltime
        // 
        textBoxInaltime.Location = new Point(120, 44);
        textBoxInaltime.Margin = new Padding(2);
        textBoxInaltime.Name = "textBoxInaltime";
        textBoxInaltime.Size = new Size(106, 23);
        textBoxInaltime.TabIndex = 7;
        // 
        // textBoxGreutate
        // 
        textBoxGreutate.Location = new Point(120, 73);
        textBoxGreutate.Margin = new Padding(2);
        textBoxGreutate.Name = "textBoxGreutate";
        textBoxGreutate.Size = new Size(106, 23);
        textBoxGreutate.TabIndex = 6;
        // 
        // textBoxNecesarKcal
        // 
        textBoxNecesarKcal.Location = new Point(402, 71);
        textBoxNecesarKcal.Margin = new Padding(2);
        textBoxNecesarKcal.Name = "textBoxNecesarKcal";
        textBoxNecesarKcal.Size = new Size(106, 23);
        textBoxNecesarKcal.TabIndex = 5;
        // 
        // textBoxAni
        // 
        textBoxAni.Location = new Point(120, 16);
        textBoxAni.Margin = new Padding(2);
        textBoxAni.Name = "textBoxAni";
        textBoxAni.Size = new Size(106, 23);
        textBoxAni.TabIndex = 4;
        // 
        // labelKcalNecesari
        // 
        labelKcalNecesari.AutoSize = true;
        labelKcalNecesari.Location = new Point(309, 75);
        labelKcalNecesari.Margin = new Padding(2, 0, 2, 0);
        labelKcalNecesari.Name = "labelKcalNecesari";
        labelKcalNecesari.Size = new Size(79, 15);
        labelKcalNecesari.TabIndex = 3;
        labelKcalNecesari.Text = "Necesar zilnic";
        // 
        // labelGreutate
        // 
        labelGreutate.AutoSize = true;
        labelGreutate.Location = new Point(20, 75);
        labelGreutate.Margin = new Padding(2, 0, 2, 0);
        labelGreutate.Name = "labelGreutate";
        labelGreutate.Size = new Size(76, 15);
        labelGreutate.TabIndex = 2;
        labelGreutate.Text = "Greutate (kg)";
        // 
        // labelInaltime
        // 
        labelInaltime.AutoSize = true;
        labelInaltime.Location = new Point(20, 46);
        labelInaltime.Margin = new Padding(2, 0, 2, 0);
        labelInaltime.Name = "labelInaltime";
        labelInaltime.Size = new Size(78, 15);
        labelInaltime.TabIndex = 1;
        labelInaltime.Text = "Inaltime (cm)";
        // 
        // labelVarsta
        // 
        labelVarsta.AutoSize = true;
        labelVarsta.Location = new Point(20, 17);
        labelVarsta.Margin = new Padding(2, 0, 2, 0);
        labelVarsta.Name = "labelVarsta";
        labelVarsta.Size = new Size(65, 15);
        labelVarsta.TabIndex = 0;
        labelVarsta.Text = "Varsta (ani)";
        // 
        // tabPageComanda
        // 
        tabPageComanda.Controls.Add(labelNecesarKcal);
        tabPageComanda.Controls.Add(dgvMeniuri);
        tabPageComanda.Location = new Point(4, 24);
        tabPageComanda.Margin = new Padding(2);
        tabPageComanda.Name = "tabPageComanda";
        tabPageComanda.Padding = new Padding(2);
        tabPageComanda.Size = new Size(861, 611);
        tabPageComanda.TabIndex = 1;
        tabPageComanda.Text = "Comanda";
        tabPageComanda.UseVisualStyleBackColor = true;
        tabPageComanda.Click += tabPageComanda_Click;
        // 
        // labelNecesarKcal
        // 
        labelNecesarKcal.AutoSize = true;
        labelNecesarKcal.Location = new Point(19, 493);
        labelNecesarKcal.Name = "labelNecesarKcal";
        labelNecesarKcal.Size = new Size(74, 15);
        labelNecesarKcal.TabIndex = 8;
        labelNecesarKcal.Text = "Necesar Kcal";
        // 
        // dgvMeniuri
        // 
        dgvMeniuri.AllowUserToAddRows = false;
        dgvMeniuri.AllowUserToDeleteRows = false;
        dgvMeniuri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvMeniuri.Location = new Point(5, 3);
        dgvMeniuri.Name = "dgvMeniuri";
        dgvMeniuri.ReadOnly = true;
        dgvMeniuri.Size = new Size(849, 458);
        dgvMeniuri.TabIndex = 0;
        dgvMeniuri.CellContentClick += dgvMeniuri_CellContentClick;
        dgvMeniuri.CellValueChanged += dgvMeniuri_CellValueChanged;
        dgvMeniuri.DataError += dgvMeniuri_DataError;
        // 
        // tabPageGenMeniu
        // 
        tabPageGenMeniu.Location = new Point(4, 24);
        tabPageGenMeniu.Margin = new Padding(2);
        tabPageGenMeniu.Name = "tabPageGenMeniu";
        tabPageGenMeniu.Size = new Size(861, 611);
        tabPageGenMeniu.TabIndex = 2;
        tabPageGenMeniu.Text = "Generare Meniu";
        tabPageGenMeniu.UseVisualStyleBackColor = true;
        // 
        // tabPageGraficKcal
        // 
        tabPageGraficKcal.Location = new Point(4, 24);
        tabPageGraficKcal.Margin = new Padding(2);
        tabPageGraficKcal.Name = "tabPageGraficKcal";
        tabPageGraficKcal.Size = new Size(861, 611);
        tabPageGraficKcal.TabIndex = 3;
        tabPageGraficKcal.Text = "Grafic Kcal";
        tabPageGraficKcal.UseVisualStyleBackColor = true;
        // 
        // labelTotalKcal
        // 
        labelTotalKcal.AutoSize = true;
        labelTotalKcal.Location = new Point(31, 591);
        labelTotalKcal.Name = "labelTotalKcal";
        labelTotalKcal.Size = new Size(58, 15);
        labelTotalKcal.TabIndex = 2;
        labelTotalKcal.Text = "Total Kcal";
        // 
        // labelPretTotal
        // 
        labelPretTotal.AutoSize = true;
        labelPretTotal.Location = new Point(34, 637);
        labelPretTotal.Name = "labelPretTotal";
        labelPretTotal.Size = new Size(55, 15);
        labelPretTotal.TabIndex = 3;
        labelPretTotal.Text = "Pret total";
        // 
        // textBoxKcal
        // 
        textBoxKcal.Location = new Point(120, 544);
        textBoxKcal.Name = "textBoxKcal";
        textBoxKcal.Size = new Size(100, 23);
        textBoxKcal.TabIndex = 4;
        // 
        // textBoxTotalKcal
        // 
        textBoxTotalKcal.Location = new Point(120, 588);
        textBoxTotalKcal.Name = "textBoxTotalKcal";
        textBoxTotalKcal.Size = new Size(100, 23);
        textBoxTotalKcal.TabIndex = 5;
        // 
        // textBoxPretTotal
        // 
        textBoxPretTotal.Location = new Point(120, 629);
        textBoxPretTotal.Name = "textBoxPretTotal";
        textBoxPretTotal.Size = new Size(100, 23);
        textBoxPretTotal.TabIndex = 6;
        // 
        // buttonComanda
        // 
        buttonComanda.Location = new Point(293, 582);
        buttonComanda.Name = "buttonComanda";
        buttonComanda.Size = new Size(102, 29);
        buttonComanda.TabIndex = 7;
        buttonComanda.Text = "Comanda";
        buttonComanda.UseVisualStyleBackColor = true;
        buttonComanda.Click += buttonComanda_Click;
        // 
        // FormOptiuni
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(882, 685);
        Controls.Add(labelTotalKcal);
        Controls.Add(buttonComanda);
        Controls.Add(textBoxKcal);
        Controls.Add(textBoxTotalKcal);
        Controls.Add(textBoxPretTotal);
        Controls.Add(labelPretTotal);
        Controls.Add(tabControlOptiuni);
        Margin = new Padding(2);
        Name = "FormOptiuni";
        Text = "Optiuni";
        tabControlOptiuni.ResumeLayout(false);
        tabPageCalcKcal.ResumeLayout(false);
        tabPageCalcKcal.PerformLayout();
        tabPageComanda.ResumeLayout(false);
        tabPageComanda.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvMeniuri).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TabControl tabControlOptiuni;
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
    private DataGridView dgvMeniuri;
    private Label labelTotalKcal;
    private Label labelPretTotal;
    private TextBox textBoxKcal;
    private TextBox textBoxTotalKcal;
    private TextBox textBoxPretTotal;
    private Button buttonComanda;
    private Label labelNecesarKcal;
}