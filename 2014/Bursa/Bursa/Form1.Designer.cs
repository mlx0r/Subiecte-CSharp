namespace Bursa
{
    partial class FormBursa
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
            components = new System.ComponentModel.Container();
            buttonDeschideBursa = new Button();
            panelBursa = new Panel();
            numericUpDown1 = new NumericUpDown();
            labelReimprospatare = new Label();
            buttonInchideBursa = new Button();
            menuStrip1 = new MenuStrip();
            utilizatorMenu = new ToolStripMenuItem();
            actiunileMeleToolStripMenuItem = new ToolStripMenuItem();
            graficProfitToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelBursa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDeschideBursa
            // 
            buttonDeschideBursa.Location = new Point(12, 65);
            buttonDeschideBursa.Name = "buttonDeschideBursa";
            buttonDeschideBursa.Size = new Size(147, 34);
            buttonDeschideBursa.TabIndex = 0;
            buttonDeschideBursa.Text = "Deschide bursa";
            buttonDeschideBursa.UseVisualStyleBackColor = true;
            // 
            // panelBursa
            // 
            panelBursa.Controls.Add(numericUpDown1);
            panelBursa.Controls.Add(labelReimprospatare);
            panelBursa.Controls.Add(buttonInchideBursa);
            panelBursa.Controls.Add(buttonDeschideBursa);
            panelBursa.Controls.Add(menuStrip1);
            panelBursa.Dock = DockStyle.Top;
            panelBursa.Location = new Point(0, 0);
            panelBursa.Name = "panelBursa";
            panelBursa.Size = new Size(800, 102);
            panelBursa.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(573, 65);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelReimprospatare
            // 
            labelReimprospatare.AutoSize = true;
            labelReimprospatare.Location = new Point(382, 65);
            labelReimprospatare.Name = "labelReimprospatare";
            labelReimprospatare.Size = new Size(173, 25);
            labelReimprospatare.TabIndex = 2;
            labelReimprospatare.Text = "Rata reimprospatare";
            // 
            // buttonInchideBursa
            // 
            buttonInchideBursa.Location = new Point(195, 65);
            buttonInchideBursa.Name = "buttonInchideBursa";
            buttonInchideBursa.Size = new Size(147, 34);
            buttonInchideBursa.TabIndex = 1;
            buttonInchideBursa.Text = "Inchide bursa";
            buttonInchideBursa.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { utilizatorMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // utilizatorMenu
            // 
            utilizatorMenu.DropDownItems.AddRange(new ToolStripItem[] { actiunileMeleToolStripMenuItem, graficProfitToolStripMenuItem });
            utilizatorMenu.Name = "utilizatorMenu";
            utilizatorMenu.Size = new Size(98, 29);
            utilizatorMenu.Text = "Utilizator";
            utilizatorMenu.MouseEnter += utilizatorMenu_MouseEnter;
            // 
            // actiunileMeleToolStripMenuItem
            // 
            actiunileMeleToolStripMenuItem.Name = "actiunileMeleToolStripMenuItem";
            actiunileMeleToolStripMenuItem.Size = new Size(270, 34);
            actiunileMeleToolStripMenuItem.Text = "Actiunile mele";
            // 
            // graficProfitToolStripMenuItem
            // 
            graficProfitToolStripMenuItem.Name = "graficProfitToolStripMenuItem";
            graficProfitToolStripMenuItem.Size = new Size(270, 34);
            graficProfitToolStripMenuItem.Text = "Grafic profit";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormBursa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBursa);
            MainMenuStrip = menuStrip1;
            Name = "FormBursa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bursa";
            Load += FormBursa_Load;
            panelBursa.ResumeLayout(false);
            panelBursa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDeschideBursa;
        private Panel panelBursa;
        private NumericUpDown numericUpDown1;
        private Label labelReimprospatare;
        private Button buttonInchideBursa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem utilizatorMenu;
        private ToolStripMenuItem actiunileMeleToolStripMenuItem;
        private ToolStripMenuItem graficProfitToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}
