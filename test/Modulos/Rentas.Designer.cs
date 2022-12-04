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
            this.inquilino_id_TBX = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.costo_TBX = new System.Windows.Forms.TextBox();
            this.Departamento_id_TBX = new System.Windows.Forms.TextBox();
            this.new_BTN = new System.Windows.Forms.Button();
            this.del_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Contrato = new System.Windows.Forms.Button();
            this.botonRedondo1 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.botonRedondo2 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.botonRedondo3 = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.Btn_Volver = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.SuspendLayout();
            // 
            // inquilino_id_TBX
            // 
            this.inquilino_id_TBX.Location = new System.Drawing.Point(5, 59);
            this.inquilino_id_TBX.Margin = new System.Windows.Forms.Padding(4);
            this.inquilino_id_TBX.Name = "inquilino_id_TBX";
            this.inquilino_id_TBX.Size = new System.Drawing.Size(232, 22);
            this.inquilino_id_TBX.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 44);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(293, 112);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // costo_TBX
            // 
            this.costo_TBX.Location = new System.Drawing.Point(291, 176);
            this.costo_TBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costo_TBX.Name = "costo_TBX";
            this.costo_TBX.ReadOnly = true;
            this.costo_TBX.Size = new System.Drawing.Size(120, 22);
            this.costo_TBX.TabIndex = 35;
            // 
            // Departamento_id_TBX
            // 
            this.Departamento_id_TBX.Location = new System.Drawing.Point(8, 114);
            this.Departamento_id_TBX.Margin = new System.Windows.Forms.Padding(4);
            this.Departamento_id_TBX.Name = "Departamento_id_TBX";
            this.Departamento_id_TBX.Size = new System.Drawing.Size(232, 22);
            this.Departamento_id_TBX.TabIndex = 37;
            // 
            // new_BTN
            // 
            this.new_BTN.Location = new System.Drawing.Point(51, 222);
            this.new_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.new_BTN.Name = "new_BTN";
            this.new_BTN.Size = new System.Drawing.Size(100, 28);
            this.new_BTN.TabIndex = 38;
            this.new_BTN.Text = "Nuevo";
            this.new_BTN.UseVisualStyleBackColor = true;
            this.new_BTN.Click += new System.EventHandler(this.new_BTN_Click);
            // 
            // del_BTN
            // 
            this.del_BTN.Location = new System.Drawing.Point(159, 222);
            this.del_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.del_BTN.Name = "del_BTN";
            this.del_BTN.Size = new System.Drawing.Size(100, 28);
            this.del_BTN.TabIndex = 39;
            this.del_BTN.Text = "Borrar";
            this.del_BTN.UseVisualStyleBackColor = true;
            this.del_BTN.Click += new System.EventHandler(this.del_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Codigo Inquilino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codigo Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha Llegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Costo Total";
            // 
            // btn_Contrato
            // 
            this.btn_Contrato.Location = new System.Drawing.Point(159, 267);
            this.btn_Contrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Contrato.Name = "btn_Contrato";
            this.btn_Contrato.Size = new System.Drawing.Size(117, 57);
            this.btn_Contrato.TabIndex = 45;
            this.btn_Contrato.Text = "Generar contrato";
            this.btn_Contrato.UseVisualStyleBackColor = true;
            this.btn_Contrato.Click += new System.EventHandler(this.btn_Contrato_Click);
            // 
            // botonRedondo1
            // 
            this.botonRedondo1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRedondo1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botonRedondo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.botonRedondo1.BorderRadius = 20;
            this.botonRedondo1.BorderSize = 0;
            this.botonRedondo1.FlatAppearance.BorderSize = 0;
            this.botonRedondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo1.ForeColor = System.Drawing.Color.White;
            this.botonRedondo1.Location = new System.Drawing.Point(51, 350);
            this.botonRedondo1.Name = "botonRedondo1";
            this.botonRedondo1.Size = new System.Drawing.Size(150, 40);
            this.botonRedondo1.TabIndex = 46;
            this.botonRedondo1.Text = "botonRedondo1";
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
            this.botonRedondo2.FlatAppearance.BorderSize = 0;
            this.botonRedondo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo2.ForeColor = System.Drawing.Color.White;
            this.botonRedondo2.Location = new System.Drawing.Point(239, 350);
            this.botonRedondo2.Name = "botonRedondo2";
            this.botonRedondo2.Size = new System.Drawing.Size(150, 40);
            this.botonRedondo2.TabIndex = 47;
            this.botonRedondo2.Text = "botonRedondo2";
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
            this.botonRedondo3.FlatAppearance.BorderSize = 0;
            this.botonRedondo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRedondo3.ForeColor = System.Drawing.Color.White;
            this.botonRedondo3.Location = new System.Drawing.Point(415, 350);
            this.botonRedondo3.Name = "botonRedondo3";
            this.botonRedondo3.Size = new System.Drawing.Size(150, 40);
            this.botonRedondo3.TabIndex = 48;
            this.botonRedondo3.Text = "botonRedondo3";
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
            this.Btn_Volver.FlatAppearance.BorderSize = 0;
            this.Btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Volver.ForeColor = System.Drawing.Color.White;
            this.Btn_Volver.Location = new System.Drawing.Point(51, 416);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(150, 40);
            this.Btn_Volver.TabIndex = 49;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.TextColor = System.Drawing.Color.White;
            this.Btn_Volver.UseVisualStyleBackColor = false;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Rentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.botonRedondo3);
            this.Controls.Add(this.botonRedondo2);
            this.Controls.Add(this.botonRedondo1);
            this.Controls.Add(this.btn_Contrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_BTN);
            this.Controls.Add(this.new_BTN);
            this.Controls.Add(this.Departamento_id_TBX);
            this.Controls.Add(this.costo_TBX);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.inquilino_id_TBX);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rentas";
            this.Size = new System.Drawing.Size(605, 594);
            this.Load += new System.EventHandler(this.Rentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inquilino_id_TBX;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox costo_TBX;
        private System.Windows.Forms.TextBox Departamento_id_TBX;
        private System.Windows.Forms.Button new_BTN;
        private System.Windows.Forms.Button del_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Contrato;
        private MarDeCortezDsk.UserControlls.BotonRedondo botonRedondo1;
        private MarDeCortezDsk.UserControlls.BotonRedondo botonRedondo2;
        private MarDeCortezDsk.UserControlls.BotonRedondo botonRedondo3;
        private MarDeCortezDsk.UserControlls.BotonRedondo Btn_Volver;
    }
}
