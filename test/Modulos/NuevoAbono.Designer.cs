namespace test.Modulos
{
    partial class NuevoAbono
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
            this.botonRedondo2 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.botonRedondo1 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.sPanel2 = new MarDeCortezDsk.UserControlls.SPanel();
            this.MetodoPago_TBX = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidad_TBX = new CustomControls.RJControls.RJTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.user_TBX = new CustomControls.RJControls.RJTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Data_Abonados = new System.Windows.Forms.DataGridView();
            this.TBx_search = new CustomControls.RJControls.RJTextBox();
            this.sPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Abonados)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRedondo2
            // 
            this.botonRedondo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.botonRedondo2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.botonRedondo2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.botonRedondo2.BorderRadius = 20;
            this.botonRedondo2.BorderSize = 0;
            this.botonRedondo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRedondo2.FlatAppearance.BorderSize = 0;
            this.botonRedondo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo2.ForeColor = System.Drawing.Color.White;
            this.botonRedondo2.Location = new System.Drawing.Point(163, 505);
            this.botonRedondo2.Margin = new System.Windows.Forms.Padding(4);
            this.botonRedondo2.Name = "botonRedondo2";
            this.botonRedondo2.Size = new System.Drawing.Size(303, 49);
            this.botonRedondo2.TabIndex = 59;
            this.botonRedondo2.Text = "Abonar";
            this.botonRedondo2.TextColor = System.Drawing.Color.White;
            this.botonRedondo2.UseVisualStyleBackColor = false;
            this.botonRedondo2.Click += new System.EventHandler(this.botonRedondo2_Click);
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.DarkRed;
            this.botonRedondo1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.botonRedondo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.botonRedondo1.BorderRadius = 20;
            this.botonRedondo1.BorderSize = 0;
            this.botonRedondo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(27, 505);
            this.botonRedondo1.Margin = new System.Windows.Forms.Padding(4);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(115, 49);
            this.botonRedondo1.TabIndex = 58;
            this.botonRedondo1.Text = "Volver";
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            this.botonRedondo1.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.White;
            this.sPanel2.BorderColor = System.Drawing.Color.White;
            this.sPanel2.Controls.Add(this.MetodoPago_TBX);
            this.sPanel2.Controls.Add(this.label1);
            this.sPanel2.Controls.Add(this.label2);
            this.sPanel2.Controls.Add(this.cantidad_TBX);
            this.sPanel2.Controls.Add(this.label12);
            this.sPanel2.Controls.Add(this.label13);
            this.sPanel2.Controls.Add(this.user_TBX);
            this.sPanel2.Controls.Add(this.label14);
            this.sPanel2.Controls.Add(this.label15);
            this.sPanel2.Edge = 20;
            this.sPanel2.Location = new System.Drawing.Point(27, 21);
            this.sPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(350, 441);
            this.sPanel2.TabIndex = 60;
            // 
            // MetodoPago_TBX
            // 
            this.MetodoPago_TBX.BackColor = System.Drawing.SystemColors.Window;
            this.MetodoPago_TBX.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MetodoPago_TBX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.MetodoPago_TBX.BorderRadius = 0;
            this.MetodoPago_TBX.BorderSize = 2;
            this.MetodoPago_TBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MetodoPago_TBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetodoPago_TBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MetodoPago_TBX.Location = new System.Drawing.Point(39, 270);
            this.MetodoPago_TBX.Margin = new System.Windows.Forms.Padding(5);
            this.MetodoPago_TBX.Multiline = false;
            this.MetodoPago_TBX.Name = "MetodoPago_TBX";
            this.MetodoPago_TBX.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.MetodoPago_TBX.PasswordChar = false;
            this.MetodoPago_TBX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.MetodoPago_TBX.PlaceholderText = "Dinero, Transferencia, Cheque";
            this.MetodoPago_TBX.Size = new System.Drawing.Size(283, 39);
            this.MetodoPago_TBX.TabIndex = 58;
            this.MetodoPago_TBX.Texts = "";
            this.MetodoPago_TBX.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Metodo de pago";
            // 
            // cantidad_TBX
            // 
            this.cantidad_TBX.BackColor = System.Drawing.SystemColors.Window;
            this.cantidad_TBX.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cantidad_TBX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cantidad_TBX.BorderRadius = 0;
            this.cantidad_TBX.BorderSize = 2;
            this.cantidad_TBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cantidad_TBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad_TBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cantidad_TBX.Location = new System.Drawing.Point(39, 164);
            this.cantidad_TBX.Margin = new System.Windows.Forms.Padding(5);
            this.cantidad_TBX.Multiline = false;
            this.cantidad_TBX.Name = "cantidad_TBX";
            this.cantidad_TBX.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.cantidad_TBX.PasswordChar = false;
            this.cantidad_TBX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cantidad_TBX.PlaceholderText = "";
            this.cantidad_TBX.Size = new System.Drawing.Size(283, 39);
            this.cantidad_TBX.TabIndex = 55;
            this.cantidad_TBX.Texts = "";
            this.cantidad_TBX.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(29, 198);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 25);
            this.label12.TabIndex = 54;
            this.label12.Text = "________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(29, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 25);
            this.label13.TabIndex = 53;
            this.label13.Text = "________________________";
            // 
            // user_TBX
            // 
            this.user_TBX.BackColor = System.Drawing.SystemColors.Window;
            this.user_TBX.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.user_TBX.BorderFocusColor = System.Drawing.Color.HotPink;
            this.user_TBX.BorderRadius = 0;
            this.user_TBX.BorderSize = 2;
            this.user_TBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_TBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_TBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_TBX.Location = new System.Drawing.Point(39, 50);
            this.user_TBX.Margin = new System.Windows.Forms.Padding(5);
            this.user_TBX.Multiline = false;
            this.user_TBX.Name = "user_TBX";
            this.user_TBX.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.user_TBX.PasswordChar = false;
            this.user_TBX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.user_TBX.PlaceholderText = "";
            this.user_TBX.Size = new System.Drawing.Size(283, 39);
            this.user_TBX.TabIndex = 49;
            this.user_TBX.Texts = "";
            this.user_TBX.UnderlinedStyle = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(23, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 25);
            this.label14.TabIndex = 45;
            this.label14.Text = "Nombre del inquilino";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(23, 126);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 25);
            this.label15.TabIndex = 44;
            this.label15.Text = "Cantidad";
            // 
            // Data_Abonados
            // 
            this.Data_Abonados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Abonados.Location = new System.Drawing.Point(385, 75);
            this.Data_Abonados.Name = "Data_Abonados";
            this.Data_Abonados.RowHeadersWidth = 51;
            this.Data_Abonados.RowTemplate.Height = 24;
            this.Data_Abonados.Size = new System.Drawing.Size(316, 387);
            this.Data_Abonados.TabIndex = 61;
            // 
            // TBx_search
            // 
            this.TBx_search.BackColor = System.Drawing.SystemColors.Window;
            this.TBx_search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TBx_search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBx_search.BorderRadius = 0;
            this.TBx_search.BorderSize = 2;
            this.TBx_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBx_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBx_search.Location = new System.Drawing.Point(386, 28);
            this.TBx_search.Margin = new System.Windows.Forms.Padding(5);
            this.TBx_search.Multiline = false;
            this.TBx_search.Name = "TBx_search";
            this.TBx_search.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TBx_search.PasswordChar = false;
            this.TBx_search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBx_search.PlaceholderText = "Introducir inquilino a buscar";
            this.TBx_search.Size = new System.Drawing.Size(315, 39);
            this.TBx_search.TabIndex = 59;
            this.TBx_search.Texts = "";
            this.TBx_search.UnderlinedStyle = false;
            this.TBx_search._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // NuevoAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.TBx_search);
            this.Controls.Add(this.Data_Abonados);
            this.Controls.Add(this.botonRedondo2);
            this.Controls.Add(this.botonRedondo1);
            this.Controls.Add(this.sPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NuevoAbono";
            this.Size = new System.Drawing.Size(715, 607);
            this.Load += new System.EventHandler(this.NuevoAbono_Load);
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Abonados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MarDeCortezDsk.UserControlls.BotonRedondo botonRedondo2;
        private MarDeCortezDsk.UserControlls.BotonRedondo botonRedondo1;
        private MarDeCortezDsk.UserControlls.SPanel sPanel2;
        private CustomControls.RJControls.RJTextBox cantidad_TBX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private CustomControls.RJControls.RJTextBox user_TBX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private CustomControls.RJControls.RJTextBox MetodoPago_TBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Data_Abonados;
        private CustomControls.RJControls.RJTextBox TBx_search;
    }
}
