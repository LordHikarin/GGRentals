namespace test.Modulos
{
    partial class Inquilino
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Borrar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(607, 357);
            this.dataGridView1.TabIndex = 18;
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
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Agregar Inquilino";
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
            this.Btn_Borrar.Location = new System.Drawing.Point(40, 477);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(146, 49);
            this.Btn_Borrar.TabIndex = 37;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextColor = System.Drawing.Color.White;
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Inquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inquilino";
            this.Size = new System.Drawing.Size(763, 602);
            this.Load += new System.EventHandler(this.Inquilino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Borrar;
    }
}
