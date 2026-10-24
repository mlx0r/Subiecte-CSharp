namespace Croaziera
{
    partial class FormVizualizareTraseu
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
            pictureBoxMareaNeagra = new PictureBox();
            buttonRevenireAuth = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMareaNeagra).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMareaNeagra
            // 
            pictureBoxMareaNeagra.Image = Properties.Resources.MareaNeagra;
            pictureBoxMareaNeagra.Location = new Point(11, 37);
            pictureBoxMareaNeagra.Margin = new Padding(2);
            pictureBoxMareaNeagra.Name = "pictureBoxMareaNeagra";
            pictureBoxMareaNeagra.Size = new Size(1000, 461);
            pictureBoxMareaNeagra.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMareaNeagra.TabIndex = 1;
            pictureBoxMareaNeagra.TabStop = false;
            pictureBoxMareaNeagra.Paint += pictureBoxMareaNeagra_Paint;
            // 
            // buttonRevenireAuth
            // 
            buttonRevenireAuth.Location = new Point(1026, 426);
            buttonRevenireAuth.Name = "buttonRevenireAuth";
            buttonRevenireAuth.Size = new Size(151, 27);
            buttonRevenireAuth.TabIndex = 2;
            buttonRevenireAuth.Text = "Inchidere";
            buttonRevenireAuth.UseVisualStyleBackColor = true;
            buttonRevenireAuth.Click += buttonRevenireAuth_Click;
            // 
            // FormVizualizareTraseu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 637);
            Controls.Add(buttonRevenireAuth);
            Controls.Add(pictureBoxMareaNeagra);
            Name = "FormVizualizareTraseu";
            Text = "Vizualizare Traseu";
            Load += FormVizualizareTraseu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMareaNeagra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxMareaNeagra;
        private Button buttonRevenireAuth;
    }
}