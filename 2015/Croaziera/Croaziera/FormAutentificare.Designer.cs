namespace Croaziera
{
    partial class FormAutentificare
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
            labelUtilizator = new Label();
            labelParola = new Label();
            textBoxUtilizator = new TextBox();
            textBoxParola = new TextBox();
            buttonAutentificare = new Button();
            SuspendLayout();
            // 
            // labelUtilizator
            // 
            labelUtilizator.AutoSize = true;
            labelUtilizator.Location = new Point(113, 102);
            labelUtilizator.Margin = new Padding(2, 0, 2, 0);
            labelUtilizator.Name = "labelUtilizator";
            labelUtilizator.Size = new Size(89, 15);
            labelUtilizator.TabIndex = 0;
            labelUtilizator.Text = "Nume utilizator";
            // 
            // labelParola
            // 
            labelParola.AutoSize = true;
            labelParola.Location = new Point(164, 133);
            labelParola.Margin = new Padding(2, 0, 2, 0);
            labelParola.Name = "labelParola";
            labelParola.Size = new Size(40, 15);
            labelParola.TabIndex = 1;
            labelParola.Text = "Parola";
            // 
            // textBoxUtilizator
            // 
            textBoxUtilizator.Location = new Point(223, 98);
            textBoxUtilizator.Margin = new Padding(2);
            textBoxUtilizator.Name = "textBoxUtilizator";
            textBoxUtilizator.Size = new Size(106, 23);
            textBoxUtilizator.TabIndex = 2;
            textBoxUtilizator.KeyDown += textBoxUtilizator_KeyDown;
            // 
            // textBoxParola
            // 
            textBoxParola.Location = new Point(223, 130);
            textBoxParola.Margin = new Padding(2);
            textBoxParola.Name = "textBoxParola";
            textBoxParola.Size = new Size(106, 23);
            textBoxParola.TabIndex = 3;
            textBoxParola.UseSystemPasswordChar = true;
            textBoxParola.KeyDown += textBoxParola_KeyDown;
            // 
            // buttonAutentificare
            // 
            buttonAutentificare.Location = new Point(223, 164);
            buttonAutentificare.Margin = new Padding(2);
            buttonAutentificare.Name = "buttonAutentificare";
            buttonAutentificare.Size = new Size(105, 20);
            buttonAutentificare.TabIndex = 4;
            buttonAutentificare.Text = "Intrare in cont";
            buttonAutentificare.UseVisualStyleBackColor = true;
            buttonAutentificare.Click += buttonAutentificare_Click;
            // 
            // FormAutentificare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(buttonAutentificare);
            Controls.Add(textBoxParola);
            Controls.Add(textBoxUtilizator);
            Controls.Add(labelParola);
            Controls.Add(labelUtilizator);
            Margin = new Padding(2);
            Name = "FormAutentificare";
            Text = "Autentificare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUtilizator;
        private Label labelParola;
        private TextBox textBoxUtilizator;
        private TextBox textBoxParola;
        private Button buttonAutentificare;
    }
}
