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
            panelInitCoordonateProgress = new Panel();
            labelProgressCurent = new Label();
            labelProgressText = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMareaNeagra).BeginInit();
            panelInitCoordonateProgress.SuspendLayout();
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
            pictureBoxMareaNeagra.TabIndex = 0;
            pictureBoxMareaNeagra.TabStop = false;
            pictureBoxMareaNeagra.MouseClick += pictureBoxMareaNeagra_MouseClick;
            // 
            // buttonInitCoordonate
            // 
            buttonInitCoordonate.Location = new Point(1030, 56);
            buttonInitCoordonate.Margin = new Padding(2);
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
            buttonSaveCoordonate.Margin = new Padding(2);
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
            buttonActualizareDist.Margin = new Padding(2);
            buttonActualizareDist.Name = "buttonActualizareDist";
            buttonActualizareDist.Size = new Size(144, 20);
            buttonActualizareDist.TabIndex = 3;
            buttonActualizareDist.Text = "Actualizare Distante";
            buttonActualizareDist.UseVisualStyleBackColor = true;
            buttonActualizareDist.Click += buttonActualizareDist_Click;
            // 
            // buttonGenCroaziere
            // 
            buttonGenCroaziere.Location = new Point(1030, 268);
            buttonGenCroaziere.Margin = new Padding(2);
            buttonGenCroaziere.Name = "buttonGenCroaziere";
            buttonGenCroaziere.Size = new Size(144, 20);
            buttonGenCroaziere.TabIndex = 4;
            buttonGenCroaziere.Text = "Generare croaziere";
            buttonGenCroaziere.UseVisualStyleBackColor = true;
            // 
            // buttonListaCroaziere
            // 
            buttonListaCroaziere.Location = new Point(1030, 305);
            buttonListaCroaziere.Margin = new Padding(2);
            buttonListaCroaziere.Name = "buttonListaCroaziere";
            buttonListaCroaziere.Size = new Size(144, 20);
            buttonListaCroaziere.TabIndex = 5;
            buttonListaCroaziere.Text = "Lista croaziere";
            buttonListaCroaziere.UseVisualStyleBackColor = true;
            buttonListaCroaziere.Click += buttonListaCroaziere_Click;
            // 
            // panelInitCoordonateProgress
            // 
            panelInitCoordonateProgress.Controls.Add(labelProgressCurent);
            panelInitCoordonateProgress.Controls.Add(labelProgressText);
            panelInitCoordonateProgress.Controls.Add(progressBar1);
            panelInitCoordonateProgress.Location = new Point(345, 516);
            panelInitCoordonateProgress.Name = "panelInitCoordonateProgress";
            panelInitCoordonateProgress.Size = new Size(462, 128);
            panelInitCoordonateProgress.TabIndex = 6;
            panelInitCoordonateProgress.Visible = false;
            // 
            // labelProgressCurent
            // 
            labelProgressCurent.AutoSize = true;
            labelProgressCurent.Location = new Point(249, 80);
            labelProgressCurent.Name = "labelProgressCurent";
            labelProgressCurent.Size = new Size(36, 15);
            labelProgressCurent.TabIndex = 2;
            labelProgressCurent.Text = "0 / 13";
            // 
            // labelProgressText
            // 
            labelProgressText.AutoSize = true;
            labelProgressText.Location = new Point(148, 80);
            labelProgressText.Name = "labelProgressText";
            labelProgressText.Size = new Size(95, 15);
            labelProgressText.TabIndex = 1;
            labelProgressText.Text = "Porturi marcate: ";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(26, 17);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(416, 36);
            progressBar1.TabIndex = 0;
            // 
            // FormAdministrare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 656);
            Controls.Add(panelInitCoordonateProgress);
            Controls.Add(buttonListaCroaziere);
            Controls.Add(buttonGenCroaziere);
            Controls.Add(buttonActualizareDist);
            Controls.Add(buttonSaveCoordonate);
            Controls.Add(buttonInitCoordonate);
            Controls.Add(pictureBoxMareaNeagra);
            Margin = new Padding(2);
            Name = "FormAdministrare";
            Text = "FormAdministrare";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMareaNeagra).EndInit();
            panelInitCoordonateProgress.ResumeLayout(false);
            panelInitCoordonateProgress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxMareaNeagra;
        private Button buttonInitCoordonate;
        private Button buttonSaveCoordonate;
        private Button buttonActualizareDist;
        private Button buttonGenCroaziere;
        private Button buttonListaCroaziere;
        private Panel panelInitCoordonateProgress;
        private ProgressBar progressBar1;
        private Label labelProgressCurent;
        private Label labelProgressText;
    }
}