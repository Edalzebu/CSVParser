namespace CsvParser
{
    partial class VentanaPrincipal
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.listaCampos = new System.Windows.Forms.ListBox();
            this.tablaGrid = new System.Windows.Forms.DataGridView();
            this.openFileWindow = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregarCampo = new System.Windows.Forms.Button();
            this.txtBoxAgregarCampo = new System.Windows.Forms.TextBox();
            this.btnPasarColumna = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Enabled = false;
            this.btnImportar.Location = new System.Drawing.Point(905, 60);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // listaCampos
            // 
            this.listaCampos.FormattingEnabled = true;
            this.listaCampos.Location = new System.Drawing.Point(12, 145);
            this.listaCampos.Name = "listaCampos";
            this.listaCampos.Size = new System.Drawing.Size(167, 329);
            this.listaCampos.TabIndex = 1;
            // 
            // tablaGrid
            // 
            this.tablaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaGrid.Location = new System.Drawing.Point(224, 145);
            this.tablaGrid.Name = "tablaGrid";
            this.tablaGrid.Size = new System.Drawing.Size(756, 329);
            this.tablaGrid.TabIndex = 2;
            this.tablaGrid.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaGrid_ColumnHeaderMouseDoubleClick);
            // 
            // openFileWindow
            // 
            this.openFileWindow.FileName = "openFileWindow";
            // 
            // btnAgregarCampo
            // 
            this.btnAgregarCampo.Location = new System.Drawing.Point(181, 114);
            this.btnAgregarCampo.Name = "btnAgregarCampo";
            this.btnAgregarCampo.Size = new System.Drawing.Size(26, 23);
            this.btnAgregarCampo.TabIndex = 3;
            this.btnAgregarCampo.Text = "+";
            this.btnAgregarCampo.UseVisualStyleBackColor = true;
            this.btnAgregarCampo.Click += new System.EventHandler(this.btnAgregarCampo_Click);
            // 
            // txtBoxAgregarCampo
            // 
            this.txtBoxAgregarCampo.Location = new System.Drawing.Point(12, 116);
            this.txtBoxAgregarCampo.Name = "txtBoxAgregarCampo";
            this.txtBoxAgregarCampo.Size = new System.Drawing.Size(167, 20);
            this.txtBoxAgregarCampo.TabIndex = 4;
            // 
            // btnPasarColumna
            // 
            this.btnPasarColumna.Location = new System.Drawing.Point(185, 284);
            this.btnPasarColumna.Name = "btnPasarColumna";
            this.btnPasarColumna.Size = new System.Drawing.Size(22, 23);
            this.btnPasarColumna.TabIndex = 5;
            this.btnPasarColumna.Text = ">";
            this.btnPasarColumna.UseVisualStyleBackColor = true;
            this.btnPasarColumna.Click += new System.EventHandler(this.btnPasarColumna_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(905, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPasarColumna);
            this.Controls.Add(this.txtBoxAgregarCampo);
            this.Controls.Add(this.btnAgregarCampo);
            this.Controls.Add(this.tablaGrid);
            this.Controls.Add(this.listaCampos);
            this.Controls.Add(this.btnImportar);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.tablaGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.ListBox listaCampos;
        private System.Windows.Forms.DataGridView tablaGrid;
        private System.Windows.Forms.OpenFileDialog openFileWindow;
        private System.Windows.Forms.Button btnAgregarCampo;
        private System.Windows.Forms.TextBox txtBoxAgregarCampo;
        private System.Windows.Forms.Button btnPasarColumna;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}