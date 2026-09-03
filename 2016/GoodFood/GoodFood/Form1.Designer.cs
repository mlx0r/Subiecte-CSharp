namespace GoodFood
{
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
            pictureBoxStart.Location = new Point(299, 119);
            pictureBoxStart.Name = "pictureBoxStart";
            pictureBoxStart.Size = new Size(307, 123);
            pictureBoxStart.TabIndex = 0;
            pictureBoxStart.TabStop = false;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStart.Location = new Point(119, 45);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(735, 38);
            labelStart.TabIndex = 1;
            labelStart.Text = "Meniuri diverse caracterizate de transparenta si excelenta!";
            // 
            // buttonInregistrare
            // 
            buttonInregistrare.Location = new Point(169, 354);
            buttonInregistrare.Name = "buttonInregistrare";
            buttonInregistrare.Size = new Size(171, 57);
            buttonInregistrare.TabIndex = 2;
            buttonInregistrare.Text = "Inregistrare";
            buttonInregistrare.UseVisualStyleBackColor = true;
            buttonInregistrare.Click += buttonInregistrare_Click;
            // 
            // buttonAutentificare
            // 
            buttonAutentificare.Location = new Point(582, 354);
            buttonAutentificare.Name = "buttonAutentificare";
            buttonAutentificare.Size = new Size(171, 57);
            buttonAutentificare.TabIndex = 3;
            buttonAutentificare.Text = "Autentificare";
            buttonAutentificare.UseVisualStyleBackColor = true;
            buttonAutentificare.Click += buttonAutentificare_Click;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 537);
            Controls.Add(buttonAutentificare);
            Controls.Add(buttonInregistrare);
            Controls.Add(labelStart);
            Controls.Add(pictureBoxStart);
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
}
