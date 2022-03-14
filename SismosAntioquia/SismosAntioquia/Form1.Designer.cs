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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewConsolidadoRegion = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.comboRegionesAgregarSismo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMagnitud = new System.Windows.Forms.TextBox();
            this.txtProfundidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.botonAgregarSismo = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleSismo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolidadoRegion)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Región:";
            // 
            // ComboBoxRegiones
            // 
            this.ComboBoxRegiones.FormattingEnabled = true;
            this.ComboBoxRegiones.Location = new System.Drawing.Point(54, 6);
            this.ComboBoxRegiones.Name = "ComboBoxRegiones";
            this.ComboBoxRegiones.Size = new System.Drawing.Size(163, 21);
            this.ComboBoxRegiones.TabIndex = 1;
            // 
            // dataGridViewDetalleSismo
            // 
            this.dataGridViewDetalleSismo.AllowUserToAddRows = false;
            this.dataGridViewDetalleSismo.AllowUserToDeleteRows = false;
            this.dataGridViewDetalleSismo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleSismo.Location = new System.Drawing.Point(6, 23);
            this.dataGridViewDetalleSismo.Name = "dataGridViewDetalleSismo";
            this.dataGridViewDetalleSismo.ReadOnly = true;
            this.dataGridViewDetalleSismo.Size = new System.Drawing.Size(497, 213);
            this.dataGridViewDetalleSismo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sismos Registrados:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(323, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 285);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewDetalleSismo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información detallada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewConsolidadoRegion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consolidado por region";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewConsolidadoRegion
            // 
            this.dataGridViewConsolidadoRegion.AllowUserToAddRows = false;
            this.dataGridViewConsolidadoRegion.AllowUserToDeleteRows = false;
            this.dataGridViewConsolidadoRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsolidadoRegion.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewConsolidadoRegion.Name = "dataGridViewConsolidadoRegion";
            this.dataGridViewConsolidadoRegion.ReadOnly = true;
            this.dataGridViewConsolidadoRegion.Size = new System.Drawing.Size(509, 247);
            this.dataGridViewConsolidadoRegion.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ComboBoxRegiones);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(521, 259);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consolidado por fecha:";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(12, 50);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(276, 350);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dtpHora);
            this.tabPage4.Controls.Add(this.botonAgregarSismo);
            this.tabPage4.Controls.Add(this.dtpFecha);
            this.tabPage4.Controls.Add(this.txtLongitud);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtLatitud);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtProfundidad);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txtMagnitud);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.comboRegionesAgregarSismo);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(268, 324);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Agregar Sismo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(268, 259);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Editar Sismo";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(268, 259);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Borrar Sismo";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // comboRegionesAgregarSismo
            // 
            this.comboRegionesAgregarSismo.FormattingEnabled = true;
            this.comboRegionesAgregarSismo.Location = new System.Drawing.Point(67, 21);
            this.comboRegionesAgregarSismo.Name = "comboRegionesAgregarSismo";
            this.comboRegionesAgregarSismo.Size = new System.Drawing.Size(163, 21);
            this.comboRegionesAgregarSismo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Región:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Magnitud:";
            // 
            // txtMagnitud
            // 
            this.txtMagnitud.Location = new System.Drawing.Point(79, 57);
            this.txtMagnitud.Name = "txtMagnitud";
            this.txtMagnitud.Size = new System.Drawing.Size(100, 20);
            this.txtMagnitud.TabIndex = 5;
            // 
            // txtProfundidad
            // 
            this.txtProfundidad.Location = new System.Drawing.Point(79, 95);
            this.txtProfundidad.Name = "txtProfundidad";
            this.txtProfundidad.Size = new System.Drawing.Size(100, 20);
            this.txtProfundidad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Profundidad";
            // 
            // txtLatitud
            // 
            this.txtLatitud.Location = new System.Drawing.Point(79, 130);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(100, 20);
            this.txtLatitud.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Latitud";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(79, 165);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 20);
            this.txtLongitud.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Longitud";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(79, 201);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // botonAgregarSismo
            // 
            this.botonAgregarSismo.Location = new System.Drawing.Point(67, 275);
            this.botonAgregarSismo.Name = "botonAgregarSismo";
            this.botonAgregarSismo.Size = new System.Drawing.Size(112, 23);
            this.botonAgregarSismo.TabIndex = 13;
            this.botonAgregarSismo.Text = "Agregar Sismo";
            this.botonAgregarSismo.UseVisualStyleBackColor = true;
            this.botonAgregarSismo.Click += new System.EventHandler(this.botonAgregarSismo_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm:ss";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(79, 228);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(100, 20);
            this.dtpHora.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hora:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sismos Antioquia 2019 - 2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleSismo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolidadoRegion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxRegiones;
        private System.Windows.Forms.DataGridView dataGridViewDetalleSismo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewConsolidadoRegion;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboRegionesAgregarSismo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button botonAgregarSismo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfundidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMagnitud;
        private System.Windows.Forms.Label label4;
    }
}

