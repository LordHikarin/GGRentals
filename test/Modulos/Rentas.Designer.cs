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
            this.rentas_DATA = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.rentas_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // rentas_DATA
            // 
            this.rentas_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentas_DATA.Location = new System.Drawing.Point(6, 276);
            this.rentas_DATA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentas_DATA.Name = "rentas_DATA";
            this.rentas_DATA.RowHeadersWidth = 51;
            this.rentas_DATA.Size = new System.Drawing.Size(430, 185);
            this.rentas_DATA.TabIndex = 3;
            // 
            // inquilino_id_TBX
            // 
            this.inquilino_id_TBX.Location = new System.Drawing.Point(4, 48);
            this.inquilino_id_TBX.Name = "inquilino_id_TBX";
            this.inquilino_id_TBX.Size = new System.Drawing.Size(175, 20);
            this.inquilino_id_TBX.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(220, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // costo_TBX
            // 
            this.costo_TBX.Location = new System.Drawing.Point(218, 143);
            this.costo_TBX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.costo_TBX.Name = "costo_TBX";
            this.costo_TBX.ReadOnly = true;
            this.costo_TBX.Size = new System.Drawing.Size(91, 20);
            this.costo_TBX.TabIndex = 35;
            // 
            // Departamento_id_TBX
            // 
            this.Departamento_id_TBX.Location = new System.Drawing.Point(6, 93);
            this.Departamento_id_TBX.Name = "Departamento_id_TBX";
            this.Departamento_id_TBX.Size = new System.Drawing.Size(175, 20);
            this.Departamento_id_TBX.TabIndex = 37;
            // 
            // new_BTN
            // 
            this.new_BTN.Location = new System.Drawing.Point(38, 180);
            this.new_BTN.Name = "new_BTN";
            this.new_BTN.Size = new System.Drawing.Size(75, 23);
            this.new_BTN.TabIndex = 38;
            this.new_BTN.Text = "Nuevo";
            this.new_BTN.UseVisualStyleBackColor = true;
            this.new_BTN.Click += new System.EventHandler(this.new_BTN_Click);
            // 
            // del_BTN
            // 
            this.del_BTN.Location = new System.Drawing.Point(119, 180);
            this.del_BTN.Name = "del_BTN";
            this.del_BTN.Size = new System.Drawing.Size(75, 23);
            this.del_BTN.TabIndex = 39;
            this.del_BTN.Text = "Borrar";
            this.del_BTN.UseVisualStyleBackColor = true;
            this.del_BTN.Click += new System.EventHandler(this.del_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Codigo Inquilino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Codigo Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha Llegada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Costo Total";
            // 
            // btn_Contrato
            // 
            this.btn_Contrato.Location = new System.Drawing.Point(119, 217);
            this.btn_Contrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Contrato.Name = "btn_Contrato";
            this.btn_Contrato.Size = new System.Drawing.Size(88, 46);
            this.btn_Contrato.TabIndex = 45;
            this.btn_Contrato.Text = "Generar contrato";
            this.btn_Contrato.UseVisualStyleBackColor = true;
            this.btn_Contrato.Click += new System.EventHandler(this.btn_Contrato_Click);
            // 
            // Rentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.rentas_DATA);
            this.Name = "Rentas";
            this.Size = new System.Drawing.Size(454, 483);
            this.Load += new System.EventHandler(this.Rentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentas_DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView rentas_DATA;
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
    }
}
