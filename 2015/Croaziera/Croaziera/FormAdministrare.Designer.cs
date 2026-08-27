namespace Croaziera
{
    partial class FormAdministrare
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
            buttonInitCoordonate = new Button();
            buttonSaveCoordonate = new Button();
            buttonActualizareDist = new Button();
            buttonGenCroaziere = new Button();
            buttonListaCroaziere = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMareaNeagra).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMareaNeagra
            // 
            pictureBoxMareaNeagra.Image = Properties.Resources.MareaNeagra;
            pictureBoxMareaNeagra.Location = new Point(11, 37);
            pictureBoxMareaNeagra.Margin = new Padding(2, 2, 2, 2);
            pictureBoxMareaNeagra.Name = "pictureBoxMareaNeagra";
            pictureBoxMareaNeagra.Size = new Size(1000, 461);
            pictureBoxMareaNeagra.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMareaNeagra.TabIndex = 0;
            pictureBoxMareaNeagra.TabStop = false;
            pictureBoxMareaNeagra.MouseClick += pictureBoxMareaNeagra_MouseClick;
            // 
            // buttonInitCoordonate
            // 
            buttonInitCoordonate.Location = new Point(1030, 56);
            buttonInitCoordonate.Margin = new Padding(2, 2, 2, 2);
            buttonInitCoordonate.Name = "buttonInitCoordonate";
            buttonInitCoordonate.Size = new Size(144, 20);
            buttonInitCoordonate.TabIndex = 1;
            buttonInitCoordonate.Text = "Initializare Coordonate";
            buttonInitCoordonate.UseVisualStyleBackColor = true;
            buttonInitCoordonate.Click += buttonInitCoordonate_Click;
            // 
            // buttonSaveCoordonate
            // 
            buttonSaveCoordonate.Location = new Point(1030, 99);
            buttonSaveCoordonate.Margin = new Padding(2, 2, 2, 2);
            buttonSaveCoordonate.Name = "buttonSaveCoordonate";
            buttonSaveCoordonate.Size = new Size(144, 20);
            buttonSaveCoordonate.TabIndex = 2;
            buttonSaveCoordonate.Text = "Salvare Coordonate";
            buttonSaveCoordonate.UseVisualStyleBackColor = true;
            buttonSaveCoordonate.Click += buttonSaveCoordonate_Click;
            // 
            // buttonActualizareDist
            // 
            buttonActualizareDist.Location = new Point(1030, 189);
            buttonActualizareDist.Margin = new Padding(2, 2, 2, 2);
            buttonActualizareDist.Name = "buttonActualizareDist";
            buttonActualizareDist.Size = new Size(144, 20);
            buttonActualizareDist.TabIndex = 3;
            buttonActualizareDist.Text = "Actualizare Distante";
            buttonActualizareDist.UseVisualStyleBackColor = true;
            // 
            // buttonGenCroaziere
            // 
            buttonGenCroaziere.Location = new Point(1030, 268);
            buttonGenCroaziere.Margin = new Padding(2, 2, 2, 2);
            buttonGenCroaziere.Name = "buttonGenCroaziere";
            buttonGenCroaziere.Size = new Size(144, 20);
            buttonGenCroaziere.TabIndex = 4;
            buttonGenCroaziere.Text = "Generare croaziere";
            buttonGenCroaziere.UseVisualStyleBackColor = true;
            // 
            // buttonListaCroaziere
            // 
            buttonListaCroaziere.Location = new Point(1030, 305);
            buttonListaCroaziere.Margin = new Padding(2, 2, 2, 2);
            buttonListaCroaziere.Name = "buttonListaCroaziere";
            buttonListaCroaziere.Size = new Size(144, 20);
            buttonListaCroaziere.TabIndex = 5;
            buttonListaCroaziere.Text = "Lista croaziere";
            buttonListaCroaziere.UseVisualStyleBackColor = true;
            buttonListaCroaziere.Click += buttonListaCroaziere_Click;
            // 
            // FormAdministrare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 623);
            Controls.Add(buttonListaCroaziere);
            Controls.Add(buttonGenCroaziere);
            Controls.Add(buttonActualizareDist);
            Controls.Add(buttonSaveCoordonate);
            Controls.Add(buttonInitCoordonate);
            Controls.Add(pictureBoxMareaNeagra);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormAdministrare";
            Text = "FormAdministrare";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMareaNeagra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxMareaNeagra;
        private Button buttonInitCoordonate;
        private Button buttonSaveCoordonate;
        private Button buttonActualizareDist;
        private Button buttonGenCroaziere;
        private Button buttonListaCroaziere;
    }
}