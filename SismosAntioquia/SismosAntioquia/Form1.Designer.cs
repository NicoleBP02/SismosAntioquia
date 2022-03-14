namespace SismosAntioquia
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxRegiones = new System.Windows.Forms.ComboBox();
            this.dataGridViewDetalleSismo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleSismo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Región:";
            // 
            // ComboBoxRegiones
            // 
            this.ComboBoxRegiones.FormattingEnabled = true;
            this.ComboBoxRegiones.Location = new System.Drawing.Point(80, 50);
            this.ComboBoxRegiones.Name = "ComboBoxRegiones";
            this.ComboBoxRegiones.Size = new System.Drawing.Size(237, 21);
            this.ComboBoxRegiones.TabIndex = 1;
            // 
            // dataGridViewDetalleSismo
            // 
            this.dataGridViewDetalleSismo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleSismo.Location = new System.Drawing.Point(345, 53);
            this.dataGridViewDetalleSismo.Name = "dataGridViewDetalleSismo";
            this.dataGridViewDetalleSismo.Size = new System.Drawing.Size(397, 150);
            this.dataGridViewDetalleSismo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sismos Registrados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDetalleSismo);
            this.Controls.Add(this.ComboBoxRegiones);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sismos Antioquia 2019 - 2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleSismo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxRegiones;
        private System.Windows.Forms.DataGridView dataGridViewDetalleSismo;
        private System.Windows.Forms.Label label2;
    }
}

