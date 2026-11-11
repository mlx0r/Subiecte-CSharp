namespace GoodFood
{
    partial class VizualizareComanda
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
            dgvVizComanda = new DataGridView();
            labelKcalViz = new Label();
            labelTotalKcalViz = new Label();
            labelPretTotalViz = new Label();
            textBoxTotalKcalViz = new TextBox();
            textBoxKcalViz = new TextBox();
            textBoxTotalPretViz = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvVizComanda).BeginInit();
            SuspendLayout();
            // 
            // dgvVizComanda
            // 
            dgvVizComanda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVizComanda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVizComanda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVizComanda.Location = new Point(12, 12);
            dgvVizComanda.Name = "dgvVizComanda";
            dgvVizComanda.Size = new Size(647, 294);
            dgvVizComanda.TabIndex = 0;
            dgvVizComanda.CellContentClick += dgvVizComanda_CellContentClick;
            dgvVizComanda.CellValueChanged += dgvVizComanda_CellValueChanged;
            dgvVizComanda.DataError += dgvVizComanda_DataError;
            // 
            // labelKcalViz
            // 
            labelKcalViz.AutoSize = true;
            labelKcalViz.Location = new Point(36, 330);
            labelKcalViz.Name = "labelKcalViz";
            labelKcalViz.Size = new Size(73, 15);
            labelKcalViz.TabIndex = 1;
            labelKcalViz.Text = "Necesar kcal";
            // 
            // labelTotalKcalViz
            // 
            labelTotalKcalViz.AutoSize = true;
            labelTotalKcalViz.Location = new Point(36, 374);
            labelTotalKcalViz.Name = "labelTotalKcalViz";
            labelTotalKcalViz.Size = new Size(57, 15);
            labelTotalKcalViz.TabIndex = 2;
            labelTotalKcalViz.Text = "Total kcal";
            // 
            // labelPretTotalViz
            // 
            labelPretTotalViz.AutoSize = true;
            labelPretTotalViz.Location = new Point(36, 422);
            labelPretTotalViz.Name = "labelPretTotalViz";
            labelPretTotalViz.Size = new Size(55, 15);
            labelPretTotalViz.TabIndex = 3;
            labelPretTotalViz.Text = "Pret total";
            // 
            // textBoxTotalKcalViz
            // 
            textBoxTotalKcalViz.Location = new Point(117, 366);
            textBoxTotalKcalViz.Name = "textBoxTotalKcalViz";
            textBoxTotalKcalViz.Size = new Size(100, 23);
            textBoxTotalKcalViz.TabIndex = 4;
            // 
            // textBoxKcalViz
            // 
            textBoxKcalViz.Location = new Point(117, 322);
            textBoxKcalViz.Name = "textBoxKcalViz";
            textBoxKcalViz.Size = new Size(100, 23);
            textBoxKcalViz.TabIndex = 5;
            // 
            // textBoxTotalPretViz
            // 
            textBoxTotalPretViz.Location = new Point(117, 414);
            textBoxTotalPretViz.Name = "textBoxTotalPretViz";
            textBoxTotalPretViz.Size = new Size(100, 23);
            textBoxTotalPretViz.TabIndex = 6;
            // 
            // VizualizareComanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 477);
            Controls.Add(textBoxTotalPretViz);
            Controls.Add(textBoxKcalViz);
            Controls.Add(textBoxTotalKcalViz);
            Controls.Add(labelPretTotalViz);
            Controls.Add(labelTotalKcalViz);
            Controls.Add(labelKcalViz);
            Controls.Add(dgvVizComanda);
            Name = "VizualizareComanda";
            Text = "VizualizareComanda";
            ((System.ComponentModel.ISupportInitialize)dgvVizComanda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVizComanda;
        private Label labelKcalViz;
        private Label labelTotalKcalViz;
        private Label labelPretTotalViz;
        private TextBox textBoxTotalKcalViz;
        private TextBox textBoxKcalViz;
        private TextBox textBoxTotalPretViz;
    }
}