namespace Archivos.AparecioCSharp
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.numLegajo = new System.Windows.Forms.NumericUpDown();
            this.grillaAlumnos = new System.Windows.Forms.DataGridView();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.grillaNotas = new System.Windows.Forms.DataGridView();
            this.numLegajo2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.grillaPromedios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 49);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 22);
            this.txtApellido.TabIndex = 2;
            // 
            // numLegajo
            // 
            this.numLegajo.Location = new System.Drawing.Point(95, 20);
            this.numLegajo.Name = "numLegajo";
            this.numLegajo.Size = new System.Drawing.Size(120, 22);
            this.numLegajo.TabIndex = 3;
            // 
            // grillaAlumnos
            // 
            this.grillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlumnos.Location = new System.Drawing.Point(321, 20);
            this.grillaAlumnos.Name = "grillaAlumnos";
            this.grillaAlumnos.RowTemplate.Height = 24;
            this.grillaAlumnos.Size = new System.Drawing.Size(445, 150);
            this.grillaAlumnos.TabIndex = 4;
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.Location = new System.Drawing.Point(95, 106);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(146, 24);
            this.btnGuardarAlumno.TabIndex = 5;
            this.btnGuardarAlumno.Text = "Guardar Alumno";
            this.btnGuardarAlumno.UseVisualStyleBackColor = true;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.Location = new System.Drawing.Point(95, 275);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(146, 24);
            this.btnGuardarNota.TabIndex = 11;
            this.btnGuardarNota.Text = "Guardar Nota";
            this.btnGuardarNota.UseVisualStyleBackColor = true;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // grillaNotas
            // 
            this.grillaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaNotas.Location = new System.Drawing.Point(321, 189);
            this.grillaNotas.Name = "grillaNotas";
            this.grillaNotas.RowTemplate.Height = 24;
            this.grillaNotas.Size = new System.Drawing.Size(445, 150);
            this.grillaNotas.TabIndex = 10;
            // 
            // numLegajo2
            // 
            this.numLegajo2.Location = new System.Drawing.Point(95, 189);
            this.numLegajo2.Name = "numLegajo2";
            this.numLegajo2.Size = new System.Drawing.Size(120, 22);
            this.numLegajo2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Legajo";
            // 
            // numNota
            // 
            this.numNota.Location = new System.Drawing.Point(95, 221);
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(120, 22);
            this.numNota.TabIndex = 12;
            // 
            // btnPromedios
            // 
            this.btnPromedios.Location = new System.Drawing.Point(65, 411);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(176, 23);
            this.btnPromedios.TabIndex = 13;
            this.btnPromedios.Text = "Obtener promedios";
            this.btnPromedios.UseVisualStyleBackColor = true;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click);
            // 
            // grillaPromedios
            // 
            this.grillaPromedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPromedios.Location = new System.Drawing.Point(321, 359);
            this.grillaPromedios.Name = "grillaPromedios";
            this.grillaPromedios.RowTemplate.Height = 24;
            this.grillaPromedios.Size = new System.Drawing.Size(445, 150);
            this.grillaPromedios.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 563);
            this.Controls.Add(this.grillaPromedios);
            this.Controls.Add(this.btnPromedios);
            this.Controls.Add(this.numNota);
            this.Controls.Add(this.btnGuardarNota);
            this.Controls.Add(this.grillaNotas);
            this.Controls.Add(this.numLegajo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.grillaAlumnos);
            this.Controls.Add(this.numLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLegajo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPromedios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown numLegajo;
        private System.Windows.Forms.DataGridView grillaAlumnos;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.DataGridView grillaNotas;
        private System.Windows.Forms.NumericUpDown numLegajo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numNota;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.DataGridView grillaPromedios;
    }
}

