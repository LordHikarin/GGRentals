﻿namespace test.Modulos
{
    partial class Abonos
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
            this.label1 = new System.Windows.Forms.Label();
            this.abonos_DATA = new System.Windows.Forms.DataGridView();
            this.TxtBx_Search = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.abonos_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Agregar Abono";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // abonos_DATA
            // 
            this.abonos_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonos_DATA.Location = new System.Drawing.Point(40, 84);
            this.abonos_DATA.Margin = new System.Windows.Forms.Padding(4);
            this.abonos_DATA.Name = "abonos_DATA";
            this.abonos_DATA.RowHeadersWidth = 51;
            this.abonos_DATA.Size = new System.Drawing.Size(607, 357);
            this.abonos_DATA.TabIndex = 20;
            // 
            // TxtBx_Search
            // 
            this.TxtBx_Search.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBx_Search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBx_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBx_Search.BorderRadius = 0;
            this.TxtBx_Search.BorderSize = 2;
            this.TxtBx_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_Search.Location = new System.Drawing.Point(372, 38);
            this.TxtBx_Search.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Search.Multiline = false;
            this.TxtBx_Search.Name = "TxtBx_Search";
            this.TxtBx_Search.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_Search.PasswordChar = false;
            this.TxtBx_Search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_Search.PlaceholderText = "Introducir inquilino a buscar";
            this.TxtBx_Search.Size = new System.Drawing.Size(275, 35);
            this.TxtBx_Search.TabIndex = 22;
            this.TxtBx_Search.Texts = "";
            this.TxtBx_Search.UnderlinedStyle = false;
            this.TxtBx_Search._TextChanged += new System.EventHandler(this.TxtBx_Search__TextChanged);
            // 
            // Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.TxtBx_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abonos_DATA);
            this.Name = "Abonos";
            this.Size = new System.Drawing.Size(763, 602);
            this.Load += new System.EventHandler(this.Abonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonos_DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView abonos_DATA;
        private CustomControls.RJControls.RJTextBox TxtBx_Search;
    }
}
