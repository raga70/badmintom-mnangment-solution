namespace WFA
{
    partial class login
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.White;
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.tbUser.Location = new System.Drawing.Point(69, 208);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(211, 27);
            this.tbUser.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.tbPass.Location = new System.Drawing.Point(69, 255);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(211, 27);
            this.tbPass.TabIndex = 1;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(32, 309);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(250, 40);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "LOG IN";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(25, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(33, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 2);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(10)))), ((int)(((byte)(92)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(33, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 2);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WFA.Properties.Resources.image;
            this.pictureBox2.Location = new System.Drawing.Point(32, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WFA.Properties.Resources.image__1_;
            this.pictureBox3.Location = new System.Drawing.Point(32, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // login
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbUser;
        private TextBox tbPass;
        private Button btLogin;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}