namespace GoodFood
{
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonIntraInCont = new Button();
            SuspendLayout();
            // 
            // labelAdresaEmailAut
            // 
            labelAdresaEmailAut.AutoSize = true;
            labelAdresaEmailAut.Location = new Point(116, 80);
            labelAdresaEmailAut.Name = "labelAdresaEmailAut";
            labelAdresaEmailAut.Size = new Size(114, 25);
            labelAdresaEmailAut.TabIndex = 0;
            labelAdresaEmailAut.Text = "Adresa email";
            // 
            // labelParolaAut
            // 
            labelParolaAut.AutoSize = true;
            labelParolaAut.Location = new Point(116, 160);
            labelParolaAut.Name = "labelParolaAut";
            labelParolaAut.Size = new Size(60, 25);
            labelParolaAut.TabIndex = 1;
            labelParolaAut.Text = "Parola";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 154);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // buttonIntraInCont
            // 
            buttonIntraInCont.Location = new Point(626, 349);
            buttonIntraInCont.Name = "buttonIntraInCont";
            buttonIntraInCont.Size = new Size(125, 33);
            buttonIntraInCont.TabIndex = 4;
            buttonIntraInCont.Text = "Intra";
            buttonIntraInCont.UseVisualStyleBackColor = true;
            buttonIntraInCont.Click += buttonIntraInCont_Click;
            // 
            // FormAutentificare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonIntraInCont);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelParolaAut);
            Controls.Add(labelAdresaEmailAut);
            Name = "FormAutentificare";
            Text = "FormAutentificare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAdresaEmailAut;
        private Label labelParolaAut;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonIntraInCont;
    }
}