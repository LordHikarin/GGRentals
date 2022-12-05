namespace test.Modulos
{
    partial class Administracion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre_TBX = new System.Windows.Forms.TextBox();
            this.usuarios_DATA = new System.Windows.Forms.DataGridView();
            this.Btn_Nuevo = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.Btn_Borrar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.Btn_Copia = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.Btn_Restaurar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_TBX
            // 
            this.nombre_TBX.Location = new System.Drawing.Point(5, 48);
            this.nombre_TBX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre_TBX.Name = "nombre_TBX";
            this.nombre_TBX.Size = new System.Drawing.Size(656, 22);
            this.nombre_TBX.TabIndex = 2;
            // 
            // usuarios_DATA
            // 
            this.usuarios_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios_DATA.Location = new System.Drawing.Point(28, 185);
            this.usuarios_DATA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuarios_DATA.Name = "usuarios_DATA";
            this.usuarios_DATA.RowHeadersWidth = 51;
            this.usuarios_DATA.Size = new System.Drawing.Size(617, 134);
            this.usuarios_DATA.TabIndex = 19;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Nuevo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Nuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Nuevo.BorderRadius = 20;
            this.Btn_Nuevo.BorderSize = 0;
            this.Btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.Btn_Nuevo.Location = new System.Drawing.Point(38, 344);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(150, 40);
            this.Btn_Nuevo.TabIndex = 38;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextColor = System.Drawing.Color.White;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Borrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Borrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Borrar.BorderRadius = 20;
            this.Btn_Borrar.BorderSize = 0;
            this.Btn_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Borrar.FlatAppearance.BorderSize = 0;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Borrar.Location = new System.Drawing.Point(222, 344);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(150, 40);
            this.Btn_Borrar.TabIndex = 39;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextColor = System.Drawing.Color.White;
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Btn_Copia
            // 
            this.Btn_Copia.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Copia.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Copia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Copia.BorderRadius = 20;
            this.Btn_Copia.BorderSize = 0;
            this.Btn_Copia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Copia.FlatAppearance.BorderSize = 0;
            this.Btn_Copia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Copia.ForeColor = System.Drawing.Color.White;
            this.Btn_Copia.Location = new System.Drawing.Point(17, 77);
            this.Btn_Copia.Name = "Btn_Copia";
            this.Btn_Copia.Size = new System.Drawing.Size(628, 40);
            this.Btn_Copia.TabIndex = 40;
            this.Btn_Copia.Text = "Copia de seguridad";
            this.Btn_Copia.TextColor = System.Drawing.Color.White;
            this.Btn_Copia.UseVisualStyleBackColor = false;
            this.Btn_Copia.Click += new System.EventHandler(this.Btn_Copia_Click);
            // 
            // Btn_Restaurar
            // 
            this.Btn_Restaurar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Restaurar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Restaurar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Restaurar.BorderRadius = 20;
            this.Btn_Restaurar.BorderSize = 0;
            this.Btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Restaurar.FlatAppearance.BorderSize = 0;
            this.Btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Restaurar.ForeColor = System.Drawing.Color.White;
            this.Btn_Restaurar.Location = new System.Drawing.Point(17, 123);
            this.Btn_Restaurar.Name = "Btn_Restaurar";
            this.Btn_Restaurar.Size = new System.Drawing.Size(628, 40);
            this.Btn_Restaurar.TabIndex = 41;
            this.Btn_Restaurar.Text = "Restaurar copia de seguridad";
            this.Btn_Restaurar.TextColor = System.Drawing.Color.White;
            this.Btn_Restaurar.UseVisualStyleBackColor = false;
            this.Btn_Restaurar.Click += new System.EventHandler(this.Btn_Restaurar_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.Btn_Restaurar);
            this.Controls.Add(this.Btn_Copia);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.usuarios_DATA);
            this.Controls.Add(this.nombre_TBX);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Administracion";
            this.Size = new System.Drawing.Size(667, 418);
            this.Load += new System.EventHandler(this.Administracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombre_TBX;
        private System.Windows.Forms.DataGridView usuarios_DATA;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Nuevo;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Borrar;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Copia;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Restaurar;
    }
}
