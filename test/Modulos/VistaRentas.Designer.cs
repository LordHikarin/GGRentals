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
            ((System.ComponentModel.ISupportInitialize)(this.rentas_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // rentas_DATA
            // 
            this.rentas_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentas_DATA.Location = new System.Drawing.Point(40, 84);
            this.rentas_DATA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentas_DATA.Name = "rentas_DATA";
            this.rentas_DATA.RowHeadersWidth = 51;
            this.rentas_DATA.Size = new System.Drawing.Size(607, 357);
            this.rentas_DATA.TabIndex = 4;
            // 
            // VistaRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.rentas_DATA);
            this.Name = "VistaRentas";
            this.Size = new System.Drawing.Size(763, 602);
            ((System.ComponentModel.ISupportInitialize)(this.rentas_DATA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rentas_DATA;
    }
}
