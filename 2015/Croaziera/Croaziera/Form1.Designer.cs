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
            labelUtilizator.Location = new Point(162, 170);
            labelUtilizator.Name = "labelUtilizator";
            labelUtilizator.Size = new Size(133, 25);
            labelUtilizator.TabIndex = 0;
            labelUtilizator.Text = "Nume utilizator";
            // 
            // labelParola
            // 
            labelParola.AutoSize = true;
            labelParola.Location = new Point(235, 222);
            labelParola.Name = "labelParola";
            labelParola.Size = new Size(60, 25);
            labelParola.TabIndex = 1;
            labelParola.Text = "Parola";
            // 
            // textBoxUtilizator
            // 
            textBoxUtilizator.Location = new Point(318, 164);
            textBoxUtilizator.Name = "textBoxUtilizator";
            textBoxUtilizator.Size = new Size(150, 31);
            textBoxUtilizator.TabIndex = 2;
            textBoxUtilizator.KeyDown += textBoxUtilizator_KeyDown;
            // 
            // textBoxParola
            // 
            textBoxParola.Location = new Point(318, 216);
            textBoxParola.Name = "textBoxParola";
            textBoxParola.Size = new Size(150, 31);
            textBoxParola.TabIndex = 3;
            textBoxParola.KeyDown += textBoxParola_KeyDown;
            // 
            // buttonAutentificare
            // 
            buttonAutentificare.Location = new Point(318, 273);
            buttonAutentificare.Name = "buttonAutentificare";
            buttonAutentificare.Size = new Size(150, 34);
            buttonAutentificare.TabIndex = 4;
            buttonAutentificare.Text = "Intrare in cont";
            buttonAutentificare.UseVisualStyleBackColor = true;
            buttonAutentificare.Click += buttonAutentificare_Click;
            // 
            // FormAutentificare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAutentificare);
            Controls.Add(textBoxParola);
            Controls.Add(textBoxUtilizator);
            Controls.Add(labelParola);
            Controls.Add(labelUtilizator);
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
