namespace PantallasProyectoParte1
{
    partial class Pantalla_Opciones
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
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.btnObservarDetallesEquipo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(373, 12);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(101, 41);
            this.btnAgregarEquipo.TabIndex = 1;
            this.btnAgregarEquipo.Text = "Agregar Equipo";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Location = new System.Drawing.Point(373, 59);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(101, 41);
            this.btnEliminarEquipo.TabIndex = 2;
            this.btnEliminarEquipo.Text = "Eliminar Equipo";
            this.btnEliminarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnObservarDetallesEquipo
            // 
            this.btnObservarDetallesEquipo.Location = new System.Drawing.Point(373, 106);
            this.btnObservarDetallesEquipo.Name = "btnObservarDetallesEquipo";
            this.btnObservarDetallesEquipo.Size = new System.Drawing.Size(101, 41);
            this.btnObservarDetallesEquipo.TabIndex = 3;
            this.btnObservarDetallesEquipo.Text = "Observar Detalles";
            this.btnObservarDetallesEquipo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(373, 200);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 41);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(373, 153);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 41);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // Pantalla_Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 255);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnObservarDetallesEquipo);
            this.Controls.Add(this.btnEliminarEquipo);
            this.Controls.Add(this.btnAgregarEquipo);
            this.Name = "Pantalla_Opciones";
            this.Text = "Pantalla_Equipos";
            this.Load += new System.EventHandler(this.Pantalla_Equipos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.Button btnObservarDetallesEquipo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegresar;
    }
}