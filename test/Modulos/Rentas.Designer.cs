﻿namespace test.Modulos
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
            this.inquilino_id_TBX = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.costo_TBX = new System.Windows.Forms.TextBox();
            this.Departamento_id_TBX = new System.Windows.Forms.TextBox();
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
            this.Btn_Borrar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.BtnRdn_contrato = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.Btn_Regresar = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.sPanel1 = new MarDeCortezDsk.UserControlls.SPanel();
            this.TxtBx_idInquilino = new CustomControls.RJControls.RJTextBox();
            this.TxtBx_IdDepa = new CustomControls.RJControls.RJTextBox();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inquilino_id_TBX
            // 
            this.inquilino_id_TBX.Location = new System.Drawing.Point(50, 84);
            this.inquilino_id_TBX.Margin = new System.Windows.Forms.Padding(5);
            this.inquilino_id_TBX.Name = "inquilino_id_TBX";
            this.inquilino_id_TBX.Size = new System.Drawing.Size(232, 22);
            this.inquilino_id_TBX.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 70);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(428, 137);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // costo_TBX
            // 
            this.costo_TBX.Location = new System.Drawing.Point(65, 298);
            this.costo_TBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costo_TBX.Name = "costo_TBX";
            this.costo_TBX.ReadOnly = true;
            this.costo_TBX.Size = new System.Drawing.Size(120, 22);
            this.costo_TBX.TabIndex = 35;
            // 
            // Departamento_id_TBX
            // 
            this.Departamento_id_TBX.Location = new System.Drawing.Point(50, 203);
            this.Departamento_id_TBX.Margin = new System.Windows.Forms.Padding(5);
            this.Departamento_id_TBX.Name = "Departamento_id_TBX";
            this.Departamento_id_TBX.Size = new System.Drawing.Size(232, 22);
            this.Departamento_id_TBX.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Codigo Inquilino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codigo Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(312, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha Llegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(312, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Costo Total";
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
            this.Btn_nuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_nuevo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_nuevo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_nuevo.BorderRadius = 20;
            this.Btn_nuevo.BorderSize = 0;
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.Btn_nuevo.Location = new System.Drawing.Point(25, 525);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(129, 57);
            this.Btn_nuevo.TabIndex = 46;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextColor = System.Drawing.Color.White;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Borrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Borrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Borrar.BorderRadius = 20;
            this.Btn_Borrar.BorderSize = 0;
            this.Btn_Borrar.FlatAppearance.BorderSize = 0;
            this.Btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Borrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Borrar.Location = new System.Drawing.Point(160, 525);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(129, 57);
            this.Btn_Borrar.TabIndex = 47;
            this.Btn_Borrar.Text = "Borrar";
            this.Btn_Borrar.TextColor = System.Drawing.Color.White;
            this.Btn_Borrar.UseVisualStyleBackColor = false;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // BtnRdn_contrato
            // 
            this.BtnRdn_contrato.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnRdn_contrato.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnRdn_contrato.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnRdn_contrato.BorderRadius = 20;
            this.BtnRdn_contrato.BorderSize = 0;
            this.BtnRdn_contrato.FlatAppearance.BorderSize = 0;
            this.BtnRdn_contrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRdn_contrato.ForeColor = System.Drawing.Color.White;
            this.BtnRdn_contrato.Location = new System.Drawing.Point(301, 525);
            this.BtnRdn_contrato.Name = "BtnRdn_contrato";
            this.BtnRdn_contrato.Size = new System.Drawing.Size(129, 57);
            this.BtnRdn_contrato.TabIndex = 48;
            this.BtnRdn_contrato.Text = "Generar contrato";
            this.BtnRdn_contrato.TextColor = System.Drawing.Color.White;
            this.BtnRdn_contrato.UseVisualStyleBackColor = false;
            this.BtnRdn_contrato.Click += new System.EventHandler(this.BtnRdn_contrato_Click);
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Regresar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_Regresar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Btn_Regresar.BorderRadius = 20;
            this.Btn_Regresar.BorderSize = 0;
            this.Btn_Regresar.FlatAppearance.BorderSize = 0;
            this.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.Btn_Regresar.Location = new System.Drawing.Point(436, 525);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(129, 57);
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
            this.sPanel1.Controls.Add(this.TxtBx_IdDepa);
            this.sPanel1.Controls.Add(this.TxtBx_idInquilino);
            this.sPanel1.Controls.Add(this.costo_TBX);
            this.sPanel1.Controls.Add(this.Departamento_id_TBX);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Controls.Add(this.label5);
            this.sPanel1.Controls.Add(this.label4);
            this.sPanel1.Controls.Add(this.inquilino_id_TBX);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.label1);
            this.sPanel1.Controls.Add(this.dateTimePicker2);
            this.sPanel1.Controls.Add(this.dateTimePicker1);
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(25, 23);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(710, 476);
            this.sPanel1.TabIndex = 50;
            // 
            // TxtBx_idInquilino
            // 
            this.TxtBx_idInquilino.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBx_idInquilino.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBx_idInquilino.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBx_idInquilino.BorderRadius = 0;
            this.TxtBx_idInquilino.BorderSize = 2;
            this.TxtBx_idInquilino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_idInquilino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_idInquilino.Location = new System.Drawing.Point(65, 79);
            this.TxtBx_idInquilino.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_idInquilino.Multiline = false;
            this.TxtBx_idInquilino.Name = "TxtBx_idInquilino";
            this.TxtBx_idInquilino.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_idInquilino.PasswordChar = false;
            this.TxtBx_idInquilino.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_idInquilino.PlaceholderText = "";
            this.TxtBx_idInquilino.Size = new System.Drawing.Size(250, 35);
            this.TxtBx_idInquilino.TabIndex = 45;
            this.TxtBx_idInquilino.Texts = "";
            this.TxtBx_idInquilino.UnderlinedStyle = false;
            // 
            // TxtBx_IdDepa
            // 
            this.TxtBx_IdDepa.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBx_IdDepa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBx_IdDepa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TxtBx_IdDepa.BorderRadius = 0;
            this.TxtBx_IdDepa.BorderSize = 2;
            this.TxtBx_IdDepa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_IdDepa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBx_IdDepa.Location = new System.Drawing.Point(65, 188);
            this.TxtBx_IdDepa.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_IdDepa.Multiline = false;
            this.TxtBx_IdDepa.Name = "TxtBx_IdDepa";
            this.TxtBx_IdDepa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBx_IdDepa.PasswordChar = false;
            this.TxtBx_IdDepa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBx_IdDepa.PlaceholderText = "";
            this.TxtBx_IdDepa.Size = new System.Drawing.Size(250, 35);
            this.TxtBx_IdDepa.TabIndex = 46;
            this.TxtBx_IdDepa.Texts = "";
            this.TxtBx_IdDepa.UnderlinedStyle = false;
            // 
            // Rentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(28)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.Btn_Regresar);
            this.Controls.Add(this.BtnRdn_contrato);
            this.Controls.Add(this.Btn_Borrar);
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
        private System.Windows.Forms.TextBox inquilino_id_TBX;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox costo_TBX;
        private System.Windows.Forms.TextBox Departamento_id_TBX;
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
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Borrar;
        private MarDeCortezDsk.UserControlls.BotonRedondo BtnRdn_contrato;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Regresar;
        private MarDeCortezDsk.UserControlls.SPanel sPanel1;
        private CustomControls.RJControls.RJTextBox TxtBx_idInquilino;
        private CustomControls.RJControls.RJTextBox TxtBx_IdDepa;
    }
}
