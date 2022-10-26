namespace test
{
    partial class main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_BTN = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.usr_TBX = new System.Windows.Forms.TextBox();
            this.psw_TBX = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_BTN
            // 
            this.login_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_BTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.login_BTN.Depth = 0;
            this.login_BTN.HighEmphasis = true;
            this.login_BTN.Icon = null;
            this.login_BTN.Location = new System.Drawing.Point(9, 305);
            this.login_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.login_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_BTN.Name = "login_BTN";
            this.login_BTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.login_BTN.Size = new System.Drawing.Size(91, 36);
            this.login_BTN.TabIndex = 1;
            this.login_BTN.Text = "Ingresar";
            this.login_BTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.login_BTN.UseAccentColor = false;
            this.login_BTN.UseVisualStyleBackColor = true;
            this.login_BTN.Click += new System.EventHandler(this.login_BTN_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(50, 208);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(136, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Nombre de Usuario";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(75, 257);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Contraseña";
            // 
            // usr_TBX
            // 
            this.usr_TBX.Location = new System.Drawing.Point(9, 230);
            this.usr_TBX.Name = "usr_TBX";
            this.usr_TBX.Size = new System.Drawing.Size(235, 20);
            this.usr_TBX.TabIndex = 6;
            this.usr_TBX.TextChanged += new System.EventHandler(this.usr_TBX_TextChanged);
            // 
            // psw_TBX
            // 
            this.psw_TBX.Location = new System.Drawing.Point(9, 279);
            this.psw_TBX.Name = "psw_TBX";
            this.psw_TBX.Size = new System.Drawing.Size(235, 20);
            this.psw_TBX.TabIndex = 7;
            this.psw_TBX.TextChanged += new System.EventHandler(this.psw_TBX_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 128;
            this.iconPictureBox1.Location = new System.Drawing.Point(53, 67);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(128, 128);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.psw_TBX);
            this.Controls.Add(this.usr_TBX);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.login_BTN);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GG Rentals";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton login_BTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox usr_TBX;
        private System.Windows.Forms.TextBox psw_TBX;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}

