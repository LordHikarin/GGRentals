namespace test
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usr_TBX = new System.Windows.Forms.TextBox();
            this.psw_TBX = new System.Windows.Forms.TextBox();
            this.login_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usr_TBX
            // 
            this.usr_TBX.Location = new System.Drawing.Point(9, 220);
            this.usr_TBX.Name = "usr_TBX";
            this.usr_TBX.Size = new System.Drawing.Size(235, 20);
            this.usr_TBX.TabIndex = 6;
            this.usr_TBX.TextChanged += new System.EventHandler(this.usr_TBX_TextChanged);
            // 
            // psw_TBX
            // 
            this.psw_TBX.Location = new System.Drawing.Point(9, 269);
            this.psw_TBX.Name = "psw_TBX";
            this.psw_TBX.Size = new System.Drawing.Size(235, 20);
            this.psw_TBX.TabIndex = 7;
            this.psw_TBX.UseSystemPasswordChar = true;
            this.psw_TBX.TextChanged += new System.EventHandler(this.psw_TBX_TextChanged);
            // 
            // login_BTN
            // 
            this.login_BTN.BackColor = System.Drawing.Color.SkyBlue;
            this.login_BTN.Enabled = false;
            this.login_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_BTN.Location = new System.Drawing.Point(9, 305);
            this.login_BTN.Name = "login_BTN";
            this.login_BTN.Size = new System.Drawing.Size(75, 33);
            this.login_BTN.TabIndex = 9;
            this.login_BTN.Text = "Ingresar";
            this.login_BTN.UseVisualStyleBackColor = false;
            this.login_BTN.Click += new System.EventHandler(this.login_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(6, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clave de Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test.Properties.Resources.LogoGG;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(-1, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 169);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_BTN);
            this.Controls.Add(this.psw_TBX);
            this.Controls.Add(this.usr_TBX);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GG Rentals";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usr_TBX;
        private System.Windows.Forms.TextBox psw_TBX;
        private System.Windows.Forms.Button login_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

