namespace ChiCuadrada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDistribucionChi2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGradoLibertad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChiCuadrada = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DGVDistro = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDistro)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verDistribucionChi2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCSVToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirCSVToolStripMenuItem
            // 
            this.abrirCSVToolStripMenuItem.Name = "abrirCSVToolStripMenuItem";
            this.abrirCSVToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.abrirCSVToolStripMenuItem.Text = "Abrir *.CSV";
            this.abrirCSVToolStripMenuItem.Click += new System.EventHandler(this.abrirCSVToolStripMenuItem_Click);
            // 
            // verDistribucionChi2ToolStripMenuItem
            // 
            this.verDistribucionChi2ToolStripMenuItem.Name = "verDistribucionChi2ToolStripMenuItem";
            this.verDistribucionChi2ToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.verDistribucionChi2ToolStripMenuItem.Text = "Ver Distribucion Chi^2";
            this.verDistribucionChi2ToolStripMenuItem.Click += new System.EventHandler(this.verDistribucionChi2ToolStripMenuItem_Click);
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 94);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(578, 245);
            this.dgv1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sumar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grado de Libertad: ";
            // 
            // lblGradoLibertad
            // 
            this.lblGradoLibertad.AutoSize = true;
            this.lblGradoLibertad.Location = new System.Drawing.Point(289, 50);
            this.lblGradoLibertad.Name = "lblGradoLibertad";
            this.lblGradoLibertad.Size = new System.Drawing.Size(0, 13);
            this.lblGradoLibertad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chi^2: ";
            // 
            // lblChiCuadrada
            // 
            this.lblChiCuadrada.AutoSize = true;
            this.lblChiCuadrada.Location = new System.Drawing.Point(392, 50);
            this.lblChiCuadrada.Name = "lblChiCuadrada";
            this.lblChiCuadrada.Size = new System.Drawing.Size(0, 13);
            this.lblChiCuadrada.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.001",
            "0.0025",
            "0.005",
            "0.01",
            "0.025",
            "0.05",
            "0.1",
            "0.15",
            "0.2",
            "0.25",
            "0.3",
            "0.35",
            "0.4",
            "0.45",
            "0.5",
            "0.55",
            "0.6",
            "0.65",
            "0.7",
            "0.75",
            "0.8",
            "0.85",
            "0.9",
            "0.95",
            "0.975",
            "0.99",
            "0.995",
            "0.9975",
            "0.999"});
            this.comboBox1.Location = new System.Drawing.Point(48, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "0.05";
            // 
            // DGVDistro
            // 
            this.DGVDistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDistro.Location = new System.Drawing.Point(544, 142);
            this.DGVDistro.Name = "DGVDistro";
            this.DGVDistro.Size = new System.Drawing.Size(848, 197);
            this.DGVDistro.TabIndex = 10;
            this.DGVDistro.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calcular H";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DGVDistro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblChiCuadrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGradoLibertad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chi-Cuadrada de Prueba en Git";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCSVToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGradoLibertad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChiCuadrada;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem verDistribucionChi2ToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGVDistro;
        private System.Windows.Forms.Button button2;
    }
}

