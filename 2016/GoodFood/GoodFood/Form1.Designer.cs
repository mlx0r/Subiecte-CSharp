namespace GoodFood;

partial class FormStart
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
        pictureBoxStart = new PictureBox();
        labelStart = new Label();
        buttonInregistrare = new Button();
        buttonAutentificare = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBoxStart).BeginInit();
        SuspendLayout();
        // 
        // pictureBoxStart
        // 
        pictureBoxStart.Image = Properties.Resources.good_food_2;
        pictureBoxStart.Location = new Point(188, 75);
        pictureBoxStart.Margin = new Padding(2, 2, 2, 2);
        pictureBoxStart.Name = "pictureBoxStart";
        pictureBoxStart.Size = new Size(306, 119);
        pictureBoxStart.TabIndex = 0;
        pictureBoxStart.TabStop = false;
        // 
        // labelStart
        // 
        labelStart.AutoSize = true;
        labelStart.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelStart.Location = new Point(83, 27);
        labelStart.Margin = new Padding(2, 0, 2, 0);
        labelStart.Name = "labelStart";
        labelStart.Size = new Size(502, 25);
        labelStart.TabIndex = 1;
        labelStart.Text = "Meniuri diverse caracterizate de transparenta si excelenta!";
        // 
        // buttonInregistrare
        // 
        buttonInregistrare.Location = new Point(118, 212);
        buttonInregistrare.Margin = new Padding(2, 2, 2, 2);
        buttonInregistrare.Name = "buttonInregistrare";
        buttonInregistrare.Size = new Size(120, 34);
        buttonInregistrare.TabIndex = 2;
        buttonInregistrare.Text = "Inregistrare";
        buttonInregistrare.UseVisualStyleBackColor = true;
        buttonInregistrare.Click += buttonInregistrare_Click;
        // 
        // buttonAutentificare
        // 
        buttonAutentificare.Location = new Point(407, 212);
        buttonAutentificare.Margin = new Padding(2, 2, 2, 2);
        buttonAutentificare.Name = "buttonAutentificare";
        buttonAutentificare.Size = new Size(120, 34);
        buttonAutentificare.TabIndex = 3;
        buttonAutentificare.Text = "Autentificare";
        buttonAutentificare.UseVisualStyleBackColor = true;
        buttonAutentificare.Click += buttonAutentificare_Click;
        // 
        // FormStart
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(638, 322);
        Controls.Add(buttonAutentificare);
        Controls.Add(buttonInregistrare);
        Controls.Add(labelStart);
        Controls.Add(pictureBoxStart);
        Margin = new Padding(2, 2, 2, 2);
        Name = "FormStart";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Start";
        ((System.ComponentModel.ISupportInitialize)pictureBoxStart).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxStart;
    private Label labelStart;
    private Button buttonInregistrare;
    private Button buttonAutentificare;
}
