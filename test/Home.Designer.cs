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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.adm_BTN = new System.Windows.Forms.Button();
            this.dept_BTN = new System.Windows.Forms.Button();
            this.inq_BTN = new System.Windows.Forms.Button();
            this.rent_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adm_BTN
            // 
            this.adm_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adm_BTN.Location = new System.Drawing.Point(1397, 13);
            this.adm_BTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adm_BTN.Name = "adm_BTN";
            this.adm_BTN.Size = new System.Drawing.Size(117, 57);
            this.adm_BTN.TabIndex = 0;
            this.adm_BTN.Text = "Administracion";
            this.adm_BTN.UseVisualStyleBackColor = true;
            this.adm_BTN.Click += new System.EventHandler(this.adm_BTN_Click);
            // 
            // dept_BTN
            // 
            this.dept_BTN.Location = new System.Drawing.Point(1397, 78);
            this.dept_BTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dept_BTN.Name = "dept_BTN";
            this.dept_BTN.Size = new System.Drawing.Size(117, 57);
            this.dept_BTN.TabIndex = 1;
            this.dept_BTN.Text = "Departamentos";
            this.dept_BTN.UseVisualStyleBackColor = true;
            this.dept_BTN.Click += new System.EventHandler(this.dept_BTN_Click);
            // 
            // inq_BTN
            // 
            this.inq_BTN.Location = new System.Drawing.Point(1397, 143);
            this.inq_BTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inq_BTN.Name = "inq_BTN";
            this.inq_BTN.Size = new System.Drawing.Size(117, 57);
            this.inq_BTN.TabIndex = 2;
            this.inq_BTN.Text = "Inquilinos";
            this.inq_BTN.UseVisualStyleBackColor = true;
            this.inq_BTN.Click += new System.EventHandler(this.inq_BTN_Click);
            // 
            // rent_BTN
            // 
            this.rent_BTN.Location = new System.Drawing.Point(1397, 208);
            this.rent_BTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rent_BTN.Name = "rent_BTN";
            this.rent_BTN.Size = new System.Drawing.Size(117, 57);
            this.rent_BTN.TabIndex = 3;
            this.rent_BTN.Text = "Rentas";
            this.rent_BTN.UseVisualStyleBackColor = true;
            this.rent_BTN.Click += new System.EventHandler(this.rent_BTN_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(154)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1527, 750);
            this.Controls.Add(this.rent_BTN);
            this.Controls.Add(this.inq_BTN);
            this.Controls.Add(this.dept_BTN);
            this.Controls.Add(this.adm_BTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adm_BTN;
        private System.Windows.Forms.Button dept_BTN;
        private System.Windows.Forms.Button inq_BTN;
        private System.Windows.Forms.Button rent_BTN;
    }
}