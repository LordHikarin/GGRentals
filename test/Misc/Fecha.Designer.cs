using System;

namespace test.Misc
{
    partial class Fecha
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.fecha_LBL = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // fecha_LBL
            // 
            this.fecha_LBL.AutoSize = true;
            this.fecha_LBL.BackColor = System.Drawing.SystemColors.Control;
            this.fecha_LBL.Depth = 0;
            this.fecha_LBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecha_LBL.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.fecha_LBL.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.fecha_LBL.Location = new System.Drawing.Point(51, 4);
            this.fecha_LBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fecha_LBL.MouseState = MaterialSkin.MouseState.HOVER;
            this.fecha_LBL.Name = "fecha_LBL";
            this.fecha_LBL.Size = new System.Drawing.Size(99, 29);
            this.fecha_LBL.TabIndex = 1;
            this.fecha_LBL.Text = "25/09/22";
            // 
            // Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.fecha_LBL);
            this.Controls.Add(this.iconPictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fecha";
            this.Size = new System.Drawing.Size(200, 39);
            this.Load += new System.EventHandler(this.Fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private MaterialSkin.Controls.MaterialLabel fecha_LBL;
    }
}
