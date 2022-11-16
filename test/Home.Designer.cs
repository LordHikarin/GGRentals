namespace test
{
    partial class Home
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
            this.home_BTN = new FontAwesome.Sharp.IconButton();
            this.inq_BTN = new FontAwesome.Sharp.IconButton();
            this.rentas_BTN = new FontAwesome.Sharp.IconButton();
            this.admin_BTN = new FontAwesome.Sharp.IconButton();
            this.dept_BTN = new FontAwesome.Sharp.IconButton();
            this.fecha1 = new test.Misc.Fecha();
            this.SuspendLayout();
            // 
            // home_BTN
            // 
            this.home_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_BTN.BackColor = System.Drawing.Color.Transparent;
            this.home_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.home_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_BTN.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home_BTN.IconColor = System.Drawing.Color.Black;
            this.home_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home_BTN.IconSize = 128;
            this.home_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.home_BTN.Location = new System.Drawing.Point(666, 316);
            this.home_BTN.Name = "home_BTN";
            this.home_BTN.Size = new System.Drawing.Size(128, 128);
            this.home_BTN.TabIndex = 11;
            this.home_BTN.Text = "Inicio";
            this.home_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home_BTN.UseVisualStyleBackColor = false;
            // 
            // inq_BTN
            // 
            this.inq_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inq_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inq_BTN.IconChar = FontAwesome.Sharp.IconChar.User;
            this.inq_BTN.IconColor = System.Drawing.Color.Black;
            this.inq_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inq_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inq_BTN.Location = new System.Drawing.Point(730, 214);
            this.inq_BTN.Name = "inq_BTN";
            this.inq_BTN.Size = new System.Drawing.Size(64, 96);
            this.inq_BTN.TabIndex = 12;
            this.inq_BTN.Text = "Inquilinos";
            this.inq_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inq_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inq_BTN.UseVisualStyleBackColor = true;
            this.inq_BTN.Click += new System.EventHandler(this.inq_BTN_Click);
            // 
            // rentas_BTN
            // 
            this.rentas_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentas_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentas_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentas_BTN.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.rentas_BTN.IconColor = System.Drawing.Color.Black;
            this.rentas_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rentas_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rentas_BTN.Location = new System.Drawing.Point(462, 380);
            this.rentas_BTN.Name = "rentas_BTN";
            this.rentas_BTN.Size = new System.Drawing.Size(96, 64);
            this.rentas_BTN.TabIndex = 13;
            this.rentas_BTN.Text = "Rentas";
            this.rentas_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rentas_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rentas_BTN.UseVisualStyleBackColor = true;
            this.rentas_BTN.Click += new System.EventHandler(this.rentas_BTN_Click);
            // 
            // admin_BTN
            // 
            this.admin_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_BTN.IconChar = FontAwesome.Sharp.IconChar.ClipboardQuestion;
            this.admin_BTN.IconColor = System.Drawing.Color.Black;
            this.admin_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.admin_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.admin_BTN.Location = new System.Drawing.Point(564, 380);
            this.admin_BTN.Name = "admin_BTN";
            this.admin_BTN.Size = new System.Drawing.Size(96, 64);
            this.admin_BTN.TabIndex = 14;
            this.admin_BTN.Text = "Administracion";
            this.admin_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.admin_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.admin_BTN.UseVisualStyleBackColor = true;
            this.admin_BTN.Click += new System.EventHandler(this.admin_BTN_Click);
            // 
            // dept_BTN
            // 
            this.dept_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dept_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dept_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept_BTN.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.dept_BTN.IconColor = System.Drawing.Color.Black;
            this.dept_BTN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dept_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dept_BTN.Location = new System.Drawing.Point(730, 112);
            this.dept_BTN.Name = "dept_BTN";
            this.dept_BTN.Size = new System.Drawing.Size(64, 96);
            this.dept_BTN.TabIndex = 15;
            this.dept_BTN.Text = "Dept";
            this.dept_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dept_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dept_BTN.UseVisualStyleBackColor = true;
            this.dept_BTN.Click += new System.EventHandler(this.dept_BTN_Click);
            // 
            // fecha1
            // 
            this.fecha1.BackColor = System.Drawing.SystemColors.Control;
            this.fecha1.Location = new System.Drawing.Point(644, 67);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(150, 32);
            this.fecha1.TabIndex = 16;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.dept_BTN);
            this.Controls.Add(this.admin_BTN);
            this.Controls.Add(this.rentas_BTN);
            this.Controls.Add(this.inq_BTN);
            this.Controls.Add(this.home_BTN);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton home_BTN;
        private FontAwesome.Sharp.IconButton inq_BTN;
        private FontAwesome.Sharp.IconButton rentas_BTN;
        private FontAwesome.Sharp.IconButton admin_BTN;
        private FontAwesome.Sharp.IconButton dept_BTN;
        private Misc.Fecha fecha1;
    }
}