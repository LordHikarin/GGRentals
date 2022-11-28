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
            this.new_BTN = new MaterialSkin.Controls.MaterialButton();
            this.del_BTN = new MaterialSkin.Controls.MaterialButton();
            this.rentas_DATA = new System.Windows.Forms.DataGridView();
            this.inquilino_id_TBX = new System.Windows.Forms.TextBox();
            this.inquilino_id_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.costo_LBL = new MaterialSkin.Controls.MaterialLabel();
            this.costo_TBX = new System.Windows.Forms.TextBox();
            this.Departamento_id_TBX = new System.Windows.Forms.TextBox();
            this.Departamento_id_LBL = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.rentas_DATA)).BeginInit();
            this.SuspendLayout();
            // 
            // new_BTN
            // 
            this.new_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.new_BTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.new_BTN.Depth = 0;
            this.new_BTN.HighEmphasis = true;
            this.new_BTN.Icon = null;
            this.new_BTN.Location = new System.Drawing.Point(247, 170);
            this.new_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.new_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.new_BTN.Name = "new_BTN";
            this.new_BTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.new_BTN.Size = new System.Drawing.Size(70, 36);
            this.new_BTN.TabIndex = 0;
            this.new_BTN.Text = "Nuevo";
            this.new_BTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.new_BTN.UseAccentColor = false;
            this.new_BTN.UseVisualStyleBackColor = true;
            this.new_BTN.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // del_BTN
            // 
            this.del_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.del_BTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.del_BTN.Depth = 0;
            this.del_BTN.HighEmphasis = true;
            this.del_BTN.Icon = null;
            this.del_BTN.Location = new System.Drawing.Point(325, 170);
            this.del_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.del_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.del_BTN.Name = "del_BTN";
            this.del_BTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.del_BTN.Size = new System.Drawing.Size(78, 36);
            this.del_BTN.TabIndex = 2;
            this.del_BTN.Text = "Borrar";
            this.del_BTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.del_BTN.UseAccentColor = false;
            this.del_BTN.UseVisualStyleBackColor = true;
            this.del_BTN.Click += new System.EventHandler(this.del_BTN_Click);
            // 
            // rentas_DATA
            // 
            this.rentas_DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentas_DATA.Location = new System.Drawing.Point(4, 124);
            this.rentas_DATA.Margin = new System.Windows.Forms.Padding(2);
            this.rentas_DATA.Name = "rentas_DATA";
            this.rentas_DATA.Size = new System.Drawing.Size(240, 125);
            this.rentas_DATA.TabIndex = 3;
            // 
            // inquilino_id_TBX
            // 
            this.inquilino_id_TBX.Location = new System.Drawing.Point(4, 48);
            this.inquilino_id_TBX.Name = "inquilino_id_TBX";
            this.inquilino_id_TBX.Size = new System.Drawing.Size(175, 20);
            this.inquilino_id_TBX.TabIndex = 27;
            // 
            // inquilino_id_LBL
            // 
            this.inquilino_id_LBL.AutoSize = true;
            this.inquilino_id_LBL.Depth = 0;
            this.inquilino_id_LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inquilino_id_LBL.Location = new System.Drawing.Point(1, 26);
            this.inquilino_id_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.inquilino_id_LBL.Name = "inquilino_id_LBL";
            this.inquilino_id_LBL.Size = new System.Drawing.Size(120, 19);
            this.inquilino_id_LBL.TabIndex = 26;
            this.inquilino_id_LBL.Text = "Codigo Inquilino:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(248, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 30;
            this.materialLabel1.Text = "Fecha Llegada";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(248, 77);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 19);
            this.materialLabel3.TabIndex = 31;
            this.materialLabel3.Text = "Fecha Salida";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(248, 100);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 33;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // costo_LBL
            // 
            this.costo_LBL.AutoSize = true;
            this.costo_LBL.Depth = 0;
            this.costo_LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.costo_LBL.Location = new System.Drawing.Point(245, 124);
            this.costo_LBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costo_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.costo_LBL.Name = "costo_LBL";
            this.costo_LBL.Size = new System.Drawing.Size(91, 19);
            this.costo_LBL.TabIndex = 34;
            this.costo_LBL.Text = "Costo Total :";
            // 
            // costo_TBX
            // 
            this.costo_TBX.Location = new System.Drawing.Point(247, 142);
            this.costo_TBX.Margin = new System.Windows.Forms.Padding(2);
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
            // Departamento_id_LBL
            // 
            this.Departamento_id_LBL.AutoSize = true;
            this.Departamento_id_LBL.Depth = 0;
            this.Departamento_id_LBL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Departamento_id_LBL.Location = new System.Drawing.Point(3, 71);
            this.Departamento_id_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.Departamento_id_LBL.Name = "Departamento_id_LBL";
            this.Departamento_id_LBL.Size = new System.Drawing.Size(160, 19);
            this.Departamento_id_LBL.TabIndex = 36;
            this.Departamento_id_LBL.Text = "Codigo Departamento:";
            // 
            // Rentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Departamento_id_TBX);
            this.Controls.Add(this.Departamento_id_LBL);
            this.Controls.Add(this.costo_TBX);
            this.Controls.Add(this.costo_LBL);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.inquilino_id_TBX);
            this.Controls.Add(this.inquilino_id_LBL);
            this.Controls.Add(this.rentas_DATA);
            this.Controls.Add(this.del_BTN);
            this.Controls.Add(this.new_BTN);
            this.Name = "Rentas";
            this.Size = new System.Drawing.Size(500, 340);
            this.Load += new System.EventHandler(this.Rentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentas_DATA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton new_BTN;
        private MaterialSkin.Controls.MaterialButton del_BTN;
        private System.Windows.Forms.DataGridView rentas_DATA;
        private System.Windows.Forms.TextBox inquilino_id_TBX;
        private MaterialSkin.Controls.MaterialLabel inquilino_id_LBL;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialLabel costo_LBL;
        private System.Windows.Forms.TextBox costo_TBX;
        private System.Windows.Forms.TextBox Departamento_id_TBX;
        private MaterialSkin.Controls.MaterialLabel Departamento_id_LBL;
    }
}
