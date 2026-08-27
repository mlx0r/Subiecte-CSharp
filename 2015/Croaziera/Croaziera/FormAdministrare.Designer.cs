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
            pictureBoxMareaNeagra.Location = new Point(1, 46);
            pictureBoxMareaNeagra.Name = "pictureBoxMareaNeagra";
            pictureBoxMareaNeagra.Size = new Size(1428, 769);
            pictureBoxMareaNeagra.TabIndex = 0;
            pictureBoxMareaNeagra.TabStop = false;
            // 
            // buttonInitCoordonate
            // 
            buttonInitCoordonate.Location = new Point(1435, 86);
            buttonInitCoordonate.Name = "buttonInitCoordonate";
            buttonInitCoordonate.Size = new Size(205, 34);
            buttonInitCoordonate.TabIndex = 1;
            buttonInitCoordonate.Text = "Initializare Coordonate";
            buttonInitCoordonate.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCoordonate
            // 
            buttonSaveCoordonate.Location = new Point(1435, 158);
            buttonSaveCoordonate.Name = "buttonSaveCoordonate";
            buttonSaveCoordonate.Size = new Size(205, 34);
            buttonSaveCoordonate.TabIndex = 2;
            buttonSaveCoordonate.Text = "Salvare Coordonate";
            buttonSaveCoordonate.UseVisualStyleBackColor = true;
            // 
            // buttonActualizareDist
            // 
            buttonActualizareDist.Location = new Point(1435, 309);
            buttonActualizareDist.Name = "buttonActualizareDist";
            buttonActualizareDist.Size = new Size(205, 34);
            buttonActualizareDist.TabIndex = 3;
            buttonActualizareDist.Text = "Actualizare Distante";
            buttonActualizareDist.UseVisualStyleBackColor = true;
            // 
            // buttonGenCroaziere
            // 
            buttonGenCroaziere.Location = new Point(1435, 440);
            buttonGenCroaziere.Name = "buttonGenCroaziere";
            buttonGenCroaziere.Size = new Size(205, 34);
            buttonGenCroaziere.TabIndex = 4;
            buttonGenCroaziere.Text = "Generare croaziere";
            buttonGenCroaziere.UseVisualStyleBackColor = true;
            // 
            // buttonListaCroaziere
            // 
            buttonListaCroaziere.Location = new Point(1435, 502);
            buttonListaCroaziere.Name = "buttonListaCroaziere";
            buttonListaCroaziere.Size = new Size(205, 34);
            buttonListaCroaziere.TabIndex = 5;
            buttonListaCroaziere.Text = "Lista croaziere";
            buttonListaCroaziere.UseVisualStyleBackColor = true;
            buttonListaCroaziere.Click += buttonListaCroaziere_Click;
            // 
            // FormAdministrare
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1652, 827);
            Controls.Add(buttonListaCroaziere);
            Controls.Add(buttonGenCroaziere);
            Controls.Add(buttonActualizareDist);
            Controls.Add(buttonSaveCoordonate);
            Controls.Add(buttonInitCoordonate);
            Controls.Add(pictureBoxMareaNeagra);
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