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
            this.sPanel1 = new MarDeCortezDsk.UserControlls.SPanel();
            this.login_BTN = new MarDeCortezDsk.UserControlls.BotonRedondo();
            this.label3 = new System.Windows.Forms.Label();
            this.circularImagen1 = new test.UserControlls.CircularImagen();
            this.TxtBoxContraseña = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxUsuario = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularImagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.Controls.Add(this.login_BTN);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.circularImagen1);
            this.sPanel1.Controls.Add(this.TxtBoxContraseña);
            this.sPanel1.Controls.Add(this.label1);
            this.sPanel1.Controls.Add(this.TxtBoxUsuario);
            this.sPanel1.Controls.Add(this.label2);
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(33, 15);
            this.sPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(357, 548);
            this.sPanel1.TabIndex = 14;
            // 
            // login_BTN
            // 
            this.login_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.login_BTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.login_BTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.login_BTN.BorderRadius = 20;
            this.login_BTN.BorderSize = 0;
            this.login_BTN.FlatAppearance.BorderSize = 0;
            this.login_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_BTN.ForeColor = System.Drawing.Color.White;
            this.login_BTN.Location = new System.Drawing.Point(40, 457);
            this.login_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.login_BTN.Name = "login_BTN";
            this.login_BTN.Size = new System.Drawing.Size(273, 49);
            this.login_BTN.TabIndex = 17;
            this.login_BTN.Text = "Ingresar";
            this.login_BTN.TextColor = System.Drawing.Color.White;
            this.login_BTN.UseVisualStyleBackColor = false;
            this.login_BTN.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(35, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "____________________";
            // 
            // circularImagen1
            // 
            this.circularImagen1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularImagen1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularImagen1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularImagen1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularImagen1.BorderSize = 2;
            this.circularImagen1.GradientAngle = 50F;
            this.circularImagen1.Image = ((System.Drawing.Image)(resources.GetObject("circularImagen1.Image")));
            this.circularImagen1.Location = new System.Drawing.Point(88, 23);
            this.circularImagen1.Margin = new System.Windows.Forms.Padding(4);
            this.circularImagen1.Name = "circularImagen1";
            this.circularImagen1.Size = new System.Drawing.Size(180, 180);
            this.circularImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularImagen1.TabIndex = 14;
            this.circularImagen1.TabStop = false;
            this.circularImagen1.Click += new System.EventHandler(this.circularImagen1_Click);
            // 
            // TxtBoxContraseña
            // 
            this.TxtBoxContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxContraseña.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBoxContraseña.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.TxtBoxContraseña.BorderRadius = 0;
            this.TxtBoxContraseña.BorderSize = 2;
            this.TxtBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxContraseña.Location = new System.Drawing.Point(48, 366);
            this.TxtBoxContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBoxContraseña.Multiline = false;
            this.TxtBoxContraseña.Name = "TxtBoxContraseña";
            this.TxtBoxContraseña.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtBoxContraseña.PasswordChar = true;
            this.TxtBoxContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxContraseña.PlaceholderText = "Contraseña";
            this.TxtBoxContraseña.Size = new System.Drawing.Size(265, 43);
            this.TxtBoxContraseña.TabIndex = 15;
            this.TxtBoxContraseña.Texts = "";
            this.TxtBoxContraseña.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de Usuario";
            // 
            // TxtBoxUsuario
            // 
            this.TxtBoxUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.TxtBoxUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.TxtBoxUsuario.BorderRadius = 0;
            this.TxtBoxUsuario.BorderSize = 2;
            this.TxtBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxUsuario.Location = new System.Drawing.Point(48, 244);
            this.TxtBoxUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.TxtBoxUsuario.Multiline = false;
            this.TxtBoxUsuario.Name = "TxtBoxUsuario";
            this.TxtBoxUsuario.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.TxtBoxUsuario.PasswordChar = false;
            this.TxtBoxUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxUsuario.PlaceholderText = "usuario";
            this.TxtBoxUsuario.Size = new System.Drawing.Size(265, 43);
            this.TxtBoxUsuario.TabIndex = 15;
            this.TxtBoxUsuario.Texts = "";
            this.TxtBoxUsuario.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clave de Inicio";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(425, 577);
            this.Controls.Add(this.sPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GG Rentals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularImagen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UserControlls.CircularImagen circularImagen1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox TxtBoxContraseña;
        private CustomControls.RJControls.RJTextBox TxtBoxUsuario;
        private MarDeCortezDsk.UserControlls.SPanel sPanel1;
        private MarDeCortezDsk.UserControlls.BotonRedondo login_BTN;
    }
}

