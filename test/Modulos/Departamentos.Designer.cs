namespace test.Modulos
{
    partial class Departamentos
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
            this.costo_TBX = new System.Windows.Forms.TextBox();
            this.ubicacion_TBX = new System.Windows.Forms.TextBox();
            this.departamento_ID_TBX = new System.Windows.Forms.TextBox();
            this.dept_DATA = new System.Windows.Forms.DataGridView();
            this.departamento_TBX = new System.Windows.Forms.TextBox();
            this.new_BTN = new System.Windows.Forms.Button();
            this.del_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dept_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // costo_TBX
            // 
            this.costo_TBX.Location = new System.Drawing.Point(172, 84);
            this.costo_TBX.Name = "costo_TBX";
            this.costo_TBX.Size = new System.Drawing.Size(300, 20);
            this.costo_TBX.TabIndex = 23;
            // 
            // ubicacion_TBX
            // 
            this.ubicacion_TBX.Location = new System.Drawing.Point(172, 59);
            this.ubicacion_TBX.Name = "ubicacion_TBX";
            this.ubicacion_TBX.Size = new System.Drawing.Size(300, 20);
            this.ubicacion_TBX.TabIndex = 22;
            // 
            // departamento_ID_TBX
            // 
            this.departamento_ID_TBX.Location = new System.Drawing.Point(172, 33);
            this.departamento_ID_TBX.Name = "departamento_ID_TBX";
            this.departamento_ID_TBX.Size = new System.Drawing.Size(300, 20);
            this.departamento_ID_TBX.TabIndex = 20;
            // 
            // dept_DATA
            // 
            this.dept_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dept_DATA.Location = new System.Drawing.Point(3, 177);
            this.dept_DATA.Name = "dept_DATA";
            this.dept_DATA.Size = new System.Drawing.Size(464, 150);
            this.dept_DATA.TabIndex = 18;
            // 
            // departamento_TBX
            // 
            this.departamento_TBX.Location = new System.Drawing.Point(172, 8);
            this.departamento_TBX.Name = "departamento_TBX";
            this.departamento_TBX.Size = new System.Drawing.Size(300, 20);
            this.departamento_TBX.TabIndex = 29;
            // 
            // new_BTN
            // 
            this.new_BTN.Location = new System.Drawing.Point(172, 110);
            this.new_BTN.Name = "new_BTN";
            this.new_BTN.Size = new System.Drawing.Size(75, 23);
            this.new_BTN.TabIndex = 30;
            this.new_BTN.Text = "Nuevo";
            this.new_BTN.UseVisualStyleBackColor = true;
            this.new_BTN.Click += new System.EventHandler(this.new_BTN_Click);
            // 
            // del_BTN
            // 
            this.del_BTN.Location = new System.Drawing.Point(392, 110);
            this.del_BTN.Name = "del_BTN";
            this.del_BTN.Size = new System.Drawing.Size(75, 23);
            this.del_BTN.TabIndex = 31;
            this.del_BTN.Text = "Borrar";
            this.del_BTN.UseVisualStyleBackColor = true;
            this.del_BTN.Click += new System.EventHandler(this.del_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Costo por dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ubicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Codigo Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Departamento";
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.del_BTN);
            this.Controls.Add(this.new_BTN);
            this.Controls.Add(this.departamento_TBX);
            this.Controls.Add(this.costo_TBX);
            this.Controls.Add(this.ubicacion_TBX);
            this.Controls.Add(this.departamento_ID_TBX);
            this.Controls.Add(this.dept_DATA);
            this.Name = "Departamentos";
            this.Size = new System.Drawing.Size(500, 340);
            this.Load += new System.EventHandler(this.Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dept_DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox costo_TBX;
        private System.Windows.Forms.TextBox ubicacion_TBX;
        private System.Windows.Forms.TextBox departamento_ID_TBX;
        private System.Windows.Forms.DataGridView dept_DATA;
        private System.Windows.Forms.TextBox departamento_TBX;
        private System.Windows.Forms.Button new_BTN;
        private System.Windows.Forms.Button del_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
