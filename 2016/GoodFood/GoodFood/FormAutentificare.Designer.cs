namespace GoodFood;

partial class FormAutentificare
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
        labelAdresaEmailAut = new Label();
        labelParolaAut = new Label();
        textBoxEmail = new TextBox();
        textBoxPass = new TextBox();
        buttonIntraInCont = new Button();
        SuspendLayout();
        // 
        // labelAdresaEmailAut
        // 
        labelAdresaEmailAut.AutoSize = true;
        labelAdresaEmailAut.Location = new Point(81, 48);
        labelAdresaEmailAut.Margin = new Padding(2, 0, 2, 0);
        labelAdresaEmailAut.Name = "labelAdresaEmailAut";
        labelAdresaEmailAut.Size = new Size(75, 15);
        labelAdresaEmailAut.TabIndex = 0;
        labelAdresaEmailAut.Text = "Adresa email";
        // 
        // labelParolaAut
        // 
        labelParolaAut.AutoSize = true;
        labelParolaAut.Location = new Point(81, 96);
        labelParolaAut.Margin = new Padding(2, 0, 2, 0);
        labelParolaAut.Name = "labelParolaAut";
        labelParolaAut.Size = new Size(40, 15);
        labelParolaAut.TabIndex = 1;
        labelParolaAut.Text = "Parola";
        // 
        // textBox1
        // 
        textBoxEmail.Location = new Point(206, 44);
        textBoxEmail.Margin = new Padding(2, 2, 2, 2);
        textBoxEmail.Name = "textBox1";
        textBoxEmail.Size = new Size(106, 23);
        textBoxEmail.TabIndex = 2;
        // 
        // textBox2
        // 
        textBoxPass.Location = new Point(206, 92);
        textBoxPass.Margin = new Padding(2, 2, 2, 2);
        textBoxPass.Name = "textBox2";
        textBoxPass.PasswordChar = '*';
        textBoxPass.Size = new Size(106, 23);
        textBoxPass.TabIndex = 3;
        // 
        // buttonIntraInCont
        // 
        buttonIntraInCont.Location = new Point(438, 209);
        buttonIntraInCont.Margin = new Padding(2, 2, 2, 2);
        buttonIntraInCont.Name = "buttonIntraInCont";
        buttonIntraInCont.Size = new Size(88, 20);
        buttonIntraInCont.TabIndex = 4;
        buttonIntraInCont.Text = "Intra";
        buttonIntraInCont.UseVisualStyleBackColor = true;
        buttonIntraInCont.Click += buttonIntraInCont_Click;
        // 
        // FormAutentificare
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(560, 270);
        Controls.Add(buttonIntraInCont);
        Controls.Add(textBoxPass);
        Controls.Add(textBoxEmail);
        Controls.Add(labelParolaAut);
        Controls.Add(labelAdresaEmailAut);
        Margin = new Padding(2, 2, 2, 2);
        Name = "FormAutentificare";
        Text = "FormAutentificare";
        Load += FormAutentificare_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelAdresaEmailAut;
    private Label labelParolaAut;
    private TextBox textBoxEmail;
    private TextBox textBoxPass;
    private Button buttonIntraInCont;
}