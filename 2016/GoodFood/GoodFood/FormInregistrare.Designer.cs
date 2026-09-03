namespace GoodFood
{
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
            pictureBox1 = new PictureBox();
            labelNume = new Label();
            labelPrenume = new Label();
            labelAdresa = new Label();
            labelParola = new Label();
            labelReintroducereParola = new Label();
            labelAdresaEmail = new Label();
            buttonCreareCont = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.good_food_2;
            pictureBox1.Location = new Point(238, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 123);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Location = new Point(160, 159);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(60, 25);
            labelNume.TabIndex = 1;
            labelNume.Text = "Nume";
            // 
            // labelPrenume
            // 
            labelPrenume.AutoSize = true;
            labelPrenume.Location = new Point(160, 214);
            labelPrenume.Name = "labelPrenume";
            labelPrenume.Size = new Size(82, 25);
            labelPrenume.TabIndex = 2;
            labelPrenume.Text = "Prenume";
            // 
            // labelAdresa
            // 
            labelAdresa.AutoSize = true;
            labelAdresa.Location = new Point(160, 270);
            labelAdresa.Name = "labelAdresa";
            labelAdresa.Size = new Size(67, 25);
            labelAdresa.TabIndex = 3;
            labelAdresa.Text = "Adresa";
            // 
            // labelParola
            // 
            labelParola.AutoSize = true;
            labelParola.Location = new Point(160, 337);
            labelParola.Name = "labelParola";
            labelParola.Size = new Size(60, 25);
            labelParola.TabIndex = 4;
            labelParola.Text = "Parola";
            // 
            // labelReintroducereParola
            // 
            labelReintroducereParola.AutoSize = true;
            labelReintroducereParola.Location = new Point(160, 395);
            labelReintroducereParola.Name = "labelReintroducereParola";
            labelReintroducereParola.Size = new Size(169, 25);
            labelReintroducereParola.TabIndex = 5;
            labelReintroducereParola.Text = "Reintroduceti Parola";
            // 
            // labelAdresaEmail
            // 
            labelAdresaEmail.AutoSize = true;
            labelAdresaEmail.Location = new Point(160, 454);
            labelAdresaEmail.Name = "labelAdresaEmail";
            labelAdresaEmail.Size = new Size(114, 25);
            labelAdresaEmail.TabIndex = 6;
            labelAdresaEmail.Text = "Adresa email";
            // 
            // buttonCreareCont
            // 
            buttonCreareCont.Location = new Point(296, 515);
            buttonCreareCont.Name = "buttonCreareCont";
            buttonCreareCont.Size = new Size(141, 43);
            buttonCreareCont.TabIndex = 7;
            buttonCreareCont.Text = "Creare cont";
            buttonCreareCont.UseVisualStyleBackColor = true;
            buttonCreareCont.Click += buttonCreareCont_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(379, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(379, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(379, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(379, 331);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(379, 389);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(379, 448);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 13;
            // 
            // FormInregistrare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonCreareCont);
            Controls.Add(labelAdresaEmail);
            Controls.Add(labelReintroducereParola);
            Controls.Add(labelParola);
            Controls.Add(labelAdresa);
            Controls.Add(labelPrenume);
            Controls.Add(labelNume);
            Controls.Add(pictureBox1);
            Name = "FormInregistrare";
            Text = "Creare_Cont_Client";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelNume;
        private Label labelPrenume;
        private Label labelAdresa;
        private Label labelParola;
        private Label labelReintroducereParola;
        private Label labelAdresaEmail;
        private Button buttonCreareCont;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}