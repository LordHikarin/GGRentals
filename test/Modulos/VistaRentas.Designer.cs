namespace test.Modulos
{
    partial class VistaRentas
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rentas_DATA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Borrar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.rentas_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // rentas_DATA
            // 
            this.rentas_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentas_DATA.Location = new System.Drawing.Point(30, 68);
            this.rentas_DATA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentas_DATA.Name = "rentas_DATA";
            this.rentas_DATA.RowHeadersWidth = 51;
            this.rentas_DATA.Size = new System.Drawing.Size(455, 290);
            this.rentas_DATA.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar Renta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.DarkRed;
            this.Btn_Borrar.BackgroundColor = System.Drawing.Color.DarkRed;
            this.Btn_Borrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Borrar.BorderRadius = 20;
            this.Btn_Borrar.BorderSize = 0;
            this.Btn_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Borrar.FlatAppearance.BorderSize = 0;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Borrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Borrar.Location = new System.Drawing.Point(30, 375);
            this.Btn_Borrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(124, 40);
            this.Btn_Borrar.TabIndex = 50;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextColor = System.Drawing.Color.White;
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // VistaRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentas_DATA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VistaRentas";
            this.Size = new System.Drawing.Size(572, 489);
            this.Load += new System.EventHandler(this.VistaRentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentas_DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rentas_DATA;
        private System.Windows.Forms.Label label1;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Borrar;
    }
}
