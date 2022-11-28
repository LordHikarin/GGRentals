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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.costo_TBX = new System.Windows.Forms.TextBox();
            this.ubicacion_TBX = new System.Windows.Forms.TextBox();
            this.departamento_ID_TBX = new System.Windows.Forms.TextBox();
            this.costo_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.dept_DATA = new System.Windows.Forms.DataGridView();
            this.ubicacion_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.dept_id_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.del_BTN = new MaterialSkin.Controls.MaterialButton();
            this.new_BTN = new MaterialSkin.Controls.MaterialButton();
            this.departamento_TBX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dept_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(5, 8);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(106, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Departamento:";
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
            // costo_LBL
            // 
            this.costo_LBL.AutoSize = true;
            this.costo_LBL.Depth = 0;
            this.costo_LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costo_LBL.Location = new System.Drawing.Point(5, 84);
            this.costo_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.costo_LBL.Name = "costo_LBL";
            this.costo_LBL.Size = new System.Drawing.Size(101, 19);
            this.costo_LBL.TabIndex = 19;
            this.costo_LBL.Text = "Costo por Dia:";
            // 
            // dept_DATA
            // 
            this.dept_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dept_DATA.Location = new System.Drawing.Point(3, 177);
            this.dept_DATA.Name = "dept_DATA";
            this.dept_DATA.Size = new System.Drawing.Size(464, 150);
            this.dept_DATA.TabIndex = 18;
            // 
            // ubicacion_LBL
            // 
            this.ubicacion_LBL.AutoSize = true;
            this.ubicacion_LBL.Depth = 0;
            this.ubicacion_LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ubicacion_LBL.Location = new System.Drawing.Point(6, 59);
            this.ubicacion_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.ubicacion_LBL.Name = "ubicacion_LBL";
            this.ubicacion_LBL.Size = new System.Drawing.Size(75, 19);
            this.ubicacion_LBL.TabIndex = 17;
            this.ubicacion_LBL.Text = "Ubicacion:";
            // 
            // dept_id_LBL
            // 
            this.dept_id_LBL.AutoSize = true;
            this.dept_id_LBL.Depth = 0;
            this.dept_id_LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dept_id_LBL.Location = new System.Drawing.Point(6, 33);
            this.dept_id_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.dept_id_LBL.Name = "dept_id_LBL";
            this.dept_id_LBL.Size = new System.Drawing.Size(160, 19);
            this.dept_id_LBL.TabIndex = 15;
            this.dept_id_LBL.Text = "Codigo Departamento:";
            // 
            // del_BTN
            // 
            this.del_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.del_BTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.del_BTN.Depth = 0;
            this.del_BTN.HighEmphasis = true;
            this.del_BTN.Icon = null;
            this.del_BTN.Location = new System.Drawing.Point(250, 113);
            this.del_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.del_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.del_BTN.Name = "del_BTN";
            this.del_BTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.del_BTN.Size = new System.Drawing.Size(78, 36);
            this.del_BTN.TabIndex = 28;
            this.del_BTN.Text = "Borrar";
            this.del_BTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.del_BTN.UseAccentColor = false;
            this.del_BTN.UseVisualStyleBackColor = true;
            this.del_BTN.Click += new System.EventHandler(this.del_BTN_Click);
            // 
            // new_BTN
            // 
            this.new_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.new_BTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.new_BTN.Depth = 0;
            this.new_BTN.HighEmphasis = true;
            this.new_BTN.Icon = null;
            this.new_BTN.Location = new System.Drawing.Point(172, 113);
            this.new_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.new_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_BTN.Name = "new_BTN";
            this.new_BTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.new_BTN.Size = new System.Drawing.Size(70, 36);
            this.new_BTN.TabIndex = 26;
            this.new_BTN.Text = "Nuevo";
            this.new_BTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.new_BTN.UseAccentColor = false;
            this.new_BTN.UseVisualStyleBackColor = true;
            this.new_BTN.Click += new System.EventHandler(this.new_BTN_Click);
            // 
            // departamento_TBX
            // 
            this.departamento_TBX.Location = new System.Drawing.Point(172, 8);
            this.departamento_TBX.Name = "departamento_TBX";
            this.departamento_TBX.Size = new System.Drawing.Size(300, 20);
            this.departamento_TBX.TabIndex = 29;
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.departamento_TBX);
            this.Controls.Add(this.del_BTN);
            this.Controls.Add(this.new_BTN);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.costo_TBX);
            this.Controls.Add(this.ubicacion_TBX);
            this.Controls.Add(this.departamento_ID_TBX);
            this.Controls.Add(this.costo_LBL);
            this.Controls.Add(this.dept_DATA);
            this.Controls.Add(this.ubicacion_LBL);
            this.Controls.Add(this.dept_id_LBL);
            this.Name = "Departamentos";
            this.Size = new System.Drawing.Size(500, 340);
            this.Load += new System.EventHandler(this.Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dept_DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox costo_TBX;
        private System.Windows.Forms.TextBox ubicacion_TBX;
        private System.Windows.Forms.TextBox departamento_ID_TBX;
        private MaterialSkin.Controls.MaterialLabel costo_LBL;
        private System.Windows.Forms.DataGridView dept_DATA;
        private MaterialSkin.Controls.MaterialLabel ubicacion_LBL;
        private MaterialSkin.Controls.MaterialLabel dept_id_LBL;
        private MaterialSkin.Controls.MaterialButton del_BTN;
        private MaterialSkin.Controls.MaterialButton new_BTN;
        private System.Windows.Forms.TextBox departamento_TBX;
    }
}
