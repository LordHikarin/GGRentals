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
            this.Restore_BTN = new System.Windows.Forms.Button();
            this.Save_BTN = new System.Windows.Forms.Button();
            this.nombre_TBX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Restore_BTN
            // 
            this.Restore_BTN.Location = new System.Drawing.Point(4, 94);
            this.Restore_BTN.Name = "Restore_BTN";
            this.Restore_BTN.Size = new System.Drawing.Size(493, 23);
            this.Restore_BTN.TabIndex = 0;
            this.Restore_BTN.Text = "Restaurar Copia de Seguridad";
            this.Restore_BTN.UseVisualStyleBackColor = true;
            this.Restore_BTN.Click += new System.EventHandler(this.Restore_BTN_Click);
            // 
            // Save_BTN
            // 
            this.Save_BTN.Location = new System.Drawing.Point(4, 65);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.Size = new System.Drawing.Size(493, 23);
            this.Save_BTN.TabIndex = 1;
            this.Save_BTN.Text = "Crear Copia de Seguridad";
            this.Save_BTN.UseVisualStyleBackColor = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // nombre_TBX
            // 
            this.nombre_TBX.Location = new System.Drawing.Point(4, 39);
            this.nombre_TBX.Name = "nombre_TBX";
            this.nombre_TBX.Size = new System.Drawing.Size(493, 20);
            this.nombre_TBX.TabIndex = 2;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nombre_TBX);
            this.Controls.Add(this.Save_BTN);
            this.Controls.Add(this.Restore_BTN);
            this.Name = "Administracion";
            this.Size = new System.Drawing.Size(500, 340);
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Restore_BTN;
        private System.Windows.Forms.Button Save_BTN;
        private System.Windows.Forms.TextBox nombre_TBX;
    }
}
