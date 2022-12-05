namespace test.Modulos
{
    partial class Rentas
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
            this.dtTime_LLegada = new System.Windows.Forms.DateTimePicker();
            this.dtTime_Salida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.botonRedondo1 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.botonRedondo2 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.botonRedondo3 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.Btn_Volver = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.Btn_nuevo = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.Btn_Regresar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.sPanel1 = new MarDeCortezDsk.UserControlls.SPanel();
            this.TxtBx_Costo = new CustomControls.RJControls.RJTextBox();
            this.TxtBx_IdDepa = new CustomControls.RJControls.RJTextBox();
            this.TxtBx_idInquilino = new CustomControls.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtTime_LLegada
            // 
            this.dtTime_LLegada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTime_LLegada.Location = new System.Drawing.Point(39, 342);
            this.dtTime_LLegada.Margin = new System.Windows.Forms.Padding(5);
            this.dtTime_LLegada.Name = "dtTime_LLegada";
            this.dtTime_LLegada.Size = new System.Drawing.Size(269, 22);
            this.dtTime_LLegada.TabIndex = 32;
            // 
            // dtTime_Salida
            // 
            this.dtTime_Salida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTime_Salida.Location = new System.Drawing.Point(39, 423);
            this.dtTime_Salida.Margin = new System.Windows.Forms.Padding(5);
            this.dtTime_Salida.Name = "dtTime_Salida";
            this.dtTime_Salida.Size = new System.Drawing.Size(269, 22);
            this.dtTime_Salida.TabIndex = 33;
            this.dtTime_Salida.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Codigo del inquilino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codigo del departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha de llegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Costo total";
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRedondo1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRedondo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.botonRedondo1.BorderRadius = 20;
            this.botonRedondo1.BorderSize = 0;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(0, 0);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(150, 40);
            this.botonRedondo1.TabIndex = 0;
            this.botonRedondo1.TextColor = System.Drawing.Color.White;
            this.botonRedondo1.UseVisualStyleBackColor = false;
            // 
            // botonRedondo2
            // 
            this.botonRedondo2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRedondo2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRedondo2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.botonRedondo2.BorderRadius = 20;
            this.botonRedondo2.BorderSize = 0;
            this.botonRedondo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo2.ForeColor = System.Drawing.Color.White;
            this.botonRedondo2.Location = new System.Drawing.Point(0, 0);
            this.botonRedondo2.Name = "botonRedondo2";
            this.botonRedondo2.Size = new System.Drawing.Size(150, 40);
            this.botonRedondo2.TabIndex = 0;
            this.botonRedondo2.TextColor = System.Drawing.Color.White;
            this.botonRedondo2.UseVisualStyleBackColor = false;
            // 
            // botonRedondo3
            // 
            this.botonRedondo3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRedondo3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRedondo3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.botonRedondo3.BorderRadius = 20;
            this.botonRedondo3.BorderSize = 0;
            this.botonRedondo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo3.ForeColor = System.Drawing.Color.White;
            this.botonRedondo3.Location = new System.Drawing.Point(0, 0);
            this.botonRedondo3.Name = "botonRedondo3";
            this.botonRedondo3.Size = new System.Drawing.Size(150, 40);
            this.botonRedondo3.TabIndex = 0;
            this.botonRedondo3.TextColor = System.Drawing.Color.White;
            this.botonRedondo3.UseVisualStyleBackColor = false;
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Volver.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Volver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Volver.BorderRadius = 20;
            this.Btn_Volver.BorderSize = 0;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.ForeColor = System.Drawing.Color.White;
            this.Btn_Volver.Location = new System.Drawing.Point(0, 0);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(150, 40);
            this.Btn_Volver.TabIndex = 0;
            this.Btn_Volver.TextColor = System.Drawing.Color.White;
            this.Btn_Volver.UseVisualStyleBackColor = false;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.Btn_nuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.Btn_nuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_nuevo.BorderRadius = 20;
            this.Btn_nuevo.BorderSize = 0;
            this.Btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.Btn_nuevo.Location = new System.Drawing.Point(197, 509);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(271, 57);
            this.Btn_nuevo.TabIndex = 46;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextColor = System.Drawing.Color.White;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.BackColor = System.Drawing.Color.DarkRed;
            this.Btn_Regresar.BackgroundColor = System.Drawing.Color.DarkRed;
            this.Btn_Regresar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Regresar.BorderRadius = 20;
            this.Btn_Regresar.BorderSize = 0;
            this.Btn_Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Regresar.FlatAppearance.BorderSize = 0;
            this.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.Btn_Regresar.Location = new System.Drawing.Point(25, 509);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(155, 57);
            this.Btn_Regresar.TabIndex = 49;
            this.Btn_Regresar.Text = "Volver";
            this.Btn_Regresar.TextColor = System.Drawing.Color.White;
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.TxtBx_Costo);
            this.sPanel1.Controls.Add(this.TxtBx_IdDepa);
            this.sPanel1.Controls.Add(this.TxtBx_idInquilino);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.label5);
            this.sPanel1.Controls.Add(this.label4);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.label1);
            this.sPanel1.Controls.Add(this.dtTime_Salida);
            this.sPanel1.Controls.Add(this.dtTime_LLegada);
            this.sPanel1.Controls.Add(this.label9);
            this.sPanel1.Controls.Add(this.label6);
            this.sPanel1.Controls.Add(this.label7);
            this.sPanel1.Controls.Add(this.label8);
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(25, 23);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(443, 466);
            this.sPanel1.TabIndex = 50;
            // 
            // TxtBx_Costo
            // 
            this.TxtBx_Costo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBx_Costo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBx_Costo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBx_Costo.BorderRadius = 0;
            this.TxtBx_Costo.BorderSize = 2;
            this.TxtBx_Costo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBx_Costo.Enabled = false;
            this.TxtBx_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Costo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_Costo.Location = new System.Drawing.Point(39, 242);
            this.TxtBx_Costo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_Costo.Multiline = false;
            this.TxtBx_Costo.Name = "TxtBx_Costo";
            this.TxtBx_Costo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_Costo.PasswordChar = false;
            this.TxtBx_Costo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_Costo.PlaceholderText = "";
            this.TxtBx_Costo.Size = new System.Drawing.Size(149, 35);
            this.TxtBx_Costo.TabIndex = 47;
            this.TxtBx_Costo.Texts = "";
            this.TxtBx_Costo.UnderlinedStyle = false;
            // 
            // TxtBx_IdDepa
            // 
            this.TxtBx_IdDepa.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBx_IdDepa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBx_IdDepa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBx_IdDepa.BorderRadius = 0;
            this.TxtBx_IdDepa.BorderSize = 2;
            this.TxtBx_IdDepa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBx_IdDepa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_IdDepa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_IdDepa.Location = new System.Drawing.Point(39, 145);
            this.TxtBx_IdDepa.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_IdDepa.Multiline = false;
            this.TxtBx_IdDepa.Name = "TxtBx_IdDepa";
            this.TxtBx_IdDepa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_IdDepa.PasswordChar = false;
            this.TxtBx_IdDepa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_IdDepa.PlaceholderText = "";
            this.TxtBx_IdDepa.Size = new System.Drawing.Size(203, 35);
            this.TxtBx_IdDepa.TabIndex = 46;
            this.TxtBx_IdDepa.Texts = "";
            this.TxtBx_IdDepa.UnderlinedStyle = false;
            // 
            // TxtBx_idInquilino
            // 
            this.TxtBx_idInquilino.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBx_idInquilino.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBx_idInquilino.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBx_idInquilino.BorderRadius = 0;
            this.TxtBx_idInquilino.BorderSize = 2;
            this.TxtBx_idInquilino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBx_idInquilino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_idInquilino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_idInquilino.Location = new System.Drawing.Point(39, 50);
            this.TxtBx_idInquilino.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_idInquilino.Multiline = false;
            this.TxtBx_idInquilino.Name = "TxtBx_idInquilino";
            this.TxtBx_idInquilino.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_idInquilino.PasswordChar = false;
            this.TxtBx_idInquilino.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_idInquilino.PlaceholderText = "";
            this.TxtBx_idInquilino.Size = new System.Drawing.Size(203, 35);
            this.TxtBx_idInquilino.TabIndex = 45;
            this.TxtBx_idInquilino.Texts = "";
            this.TxtBx_idInquilino.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(23, 359);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(23, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(23, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "________________________";
            // 
            // Rentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.Btn_Regresar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.sPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Rentas";
            this.Size = new System.Drawing.Size(763, 602);
            this.Load += new System.EventHandler(this.Rentas_Load);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtTime_LLegada;
        private System.Windows.Forms.DateTimePicker dtTime_Salida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MarDeCortezDsk.UserControlls.BotonRedondo botonRedondo1;
        private MarDeCortezDsk.UserControlls.BotonRedondo botonRedondo2;
        private MarDeCortezDsk.UserControlls.BotonRedondo botonRedondo3;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Volver;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_nuevo;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Regresar;
        private MarDeCortezDsk.UserControlls.SPanel sPanel1;
        private CustomControls.RJControls.RJTextBox TxtBx_idInquilino;
        private CustomControls.RJControls.RJTextBox TxtBx_IdDepa;
        private CustomControls.RJControls.RJTextBox TxtBx_Costo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}
