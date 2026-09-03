namespace GoodFood;

partial class FormInregistrare
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
        pictureBoxLogo = new PictureBox();
        labelNume = new Label();
        labelPrenume = new Label();
        labelAdresa = new Label();
        labelParola = new Label();
        labelReintroducereParola = new Label();
        labelAdresaEmail = new Label();
        buttonCreareCont = new Button();
        textBoxNume = new TextBox();
        textBoxAdresa = new TextBox();
        textBoxPrenume = new TextBox();
        textBoxParola = new TextBox();
        textBoxReParola = new TextBox();
        textBoxEmail = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        SuspendLayout();
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.Image = Properties.Resources.good_food_2;
        pictureBoxLogo.Location = new Point(309, -4);
        pictureBoxLogo.Margin = new Padding(4, 4, 4, 4);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(399, 157);
        pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxLogo.TabIndex = 0;
        pictureBoxLogo.TabStop = false;
        // 
        // labelNume
        // 
        labelNume.AutoSize = true;
        labelNume.Font = new Font("Segoe UI", 12F);
        labelNume.Location = new Point(208, 204);
        labelNume.Margin = new Padding(4, 0, 4, 0);
        labelNume.Name = "labelNume";
        labelNume.Size = new Size(80, 32);
        labelNume.TabIndex = 1;
        labelNume.Text = "Nume";
        // 
        // labelPrenume
        // 
        labelPrenume.AutoSize = true;
        labelPrenume.Font = new Font("Segoe UI", 12F);
        labelPrenume.Location = new Point(208, 274);
        labelPrenume.Margin = new Padding(4, 0, 4, 0);
        labelPrenume.Name = "labelPrenume";
        labelPrenume.Size = new Size(110, 32);
        labelPrenume.TabIndex = 2;
        labelPrenume.Text = "Prenume";
        // 
        // labelAdresa
        // 
        labelAdresa.AutoSize = true;
        labelAdresa.Font = new Font("Segoe UI", 12F);
        labelAdresa.Location = new Point(208, 346);
        labelAdresa.Margin = new Padding(4, 0, 4, 0);
        labelAdresa.Name = "labelAdresa";
        labelAdresa.Size = new Size(86, 32);
        labelAdresa.TabIndex = 3;
        labelAdresa.Text = "Adresa";
        // 
        // labelParola
        // 
        labelParola.AutoSize = true;
        labelParola.Font = new Font("Segoe UI", 12F);
        labelParola.Location = new Point(208, 431);
        labelParola.Margin = new Padding(4, 0, 4, 0);
        labelParola.Name = "labelParola";
        labelParola.Size = new Size(78, 32);
        labelParola.TabIndex = 4;
        labelParola.Text = "Parola";
        // 
        // labelReintroducereParola
        // 
        labelReintroducereParola.AutoSize = true;
        labelReintroducereParola.Font = new Font("Segoe UI", 12F);
        labelReintroducereParola.Location = new Point(208, 506);
        labelReintroducereParola.Margin = new Padding(4, 0, 4, 0);
        labelReintroducereParola.Name = "labelReintroducereParola";
        labelReintroducereParola.Size = new Size(227, 32);
        labelReintroducereParola.TabIndex = 5;
        labelReintroducereParola.Text = "Reintroduceti Parola";
        // 
        // labelAdresaEmail
        // 
        labelAdresaEmail.AutoSize = true;
        labelAdresaEmail.Font = new Font("Segoe UI", 12F);
        labelAdresaEmail.Location = new Point(208, 581);
        labelAdresaEmail.Margin = new Padding(4, 0, 4, 0);
        labelAdresaEmail.Name = "labelAdresaEmail";
        labelAdresaEmail.Size = new Size(151, 32);
        labelAdresaEmail.TabIndex = 6;
        labelAdresaEmail.Text = "Adresa email";
        // 
        // buttonCreareCont
        // 
        buttonCreareCont.Location = new Point(385, 659);
        buttonCreareCont.Margin = new Padding(4, 4, 4, 4);
        buttonCreareCont.Name = "buttonCreareCont";
        buttonCreareCont.Size = new Size(183, 55);
        buttonCreareCont.TabIndex = 7;
        buttonCreareCont.Text = "Creare cont";
        buttonCreareCont.UseVisualStyleBackColor = true;
        buttonCreareCont.Click += buttonCreareCont_Click;
        // 
        // textBoxNume
        // 
        textBoxNume.Location = new Point(493, 196);
        textBoxNume.Margin = new Padding(4, 4, 4, 4);
        textBoxNume.Name = "textBoxNume";
        textBoxNume.Size = new Size(194, 39);
        textBoxNume.TabIndex = 8;
        // 
        // textBoxAdresa
        // 
        textBoxAdresa.Location = new Point(493, 338);
        textBoxAdresa.Margin = new Padding(4, 4, 4, 4);
        textBoxAdresa.Name = "textBoxAdresa";
        textBoxAdresa.Size = new Size(194, 39);
        textBoxAdresa.TabIndex = 9;
        // 
        // textBoxPrenume
        // 
        textBoxPrenume.Location = new Point(493, 266);
        textBoxPrenume.Margin = new Padding(4, 4, 4, 4);
        textBoxPrenume.Name = "textBoxPrenume";
        textBoxPrenume.Size = new Size(194, 39);
        textBoxPrenume.TabIndex = 10;
        // 
        // textBoxParola
        // 
        textBoxParola.Location = new Point(493, 424);
        textBoxParola.Margin = new Padding(4, 4, 4, 4);
        textBoxParola.Name = "textBoxParola";
        textBoxParola.PasswordChar = '*';
        textBoxParola.Size = new Size(194, 39);
        textBoxParola.TabIndex = 11;
        // 
        // textBoxReParola
        // 
        textBoxReParola.Location = new Point(493, 498);
        textBoxReParola.Margin = new Padding(4, 4, 4, 4);
        textBoxReParola.Name = "textBoxReParola";
        textBoxReParola.PasswordChar = '*';
        textBoxReParola.Size = new Size(194, 39);
        textBoxReParola.TabIndex = 12;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Location = new Point(493, 573);
        textBoxEmail.Margin = new Padding(4, 4, 4, 4);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(194, 39);
        textBoxEmail.TabIndex = 13;
        // 
        // FormInregistrare
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1004, 805);
        Controls.Add(textBoxEmail);
        Controls.Add(textBoxReParola);
        Controls.Add(textBoxParola);
        Controls.Add(textBoxPrenume);
        Controls.Add(textBoxAdresa);
        Controls.Add(textBoxNume);
        Controls.Add(buttonCreareCont);
        Controls.Add(labelAdresaEmail);
        Controls.Add(labelReintroducereParola);
        Controls.Add(labelParola);
        Controls.Add(labelAdresa);
        Controls.Add(labelPrenume);
        Controls.Add(labelNume);
        Controls.Add(pictureBoxLogo);
        Font = new Font("Segoe UI", 12F);
        Margin = new Padding(4, 4, 4, 4);
        Name = "FormInregistrare";
        Text = "Creare_Cont_Client";
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxLogo;
    private Label labelNume;
    private Label labelPrenume;
    private Label labelAdresa;
    private Label labelParola;
    private Label labelReintroducereParola;
    private Label labelAdresaEmail;
    private Button buttonCreareCont;
    private TextBox textBoxNume;
    private TextBox textBoxAdresa;
    private TextBox textBoxPrenume;
    private TextBox textBoxParola;
    private TextBox textBoxReParola;
    private TextBox textBoxEmail;
}