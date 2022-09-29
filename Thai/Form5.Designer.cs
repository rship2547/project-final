namespace Thai
{
    partial class Form5
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
            System.Windows.Forms.Button bt_exit;
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            bt_exit.BackColor = System.Drawing.Color.Sienna;
            bt_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            bt_exit.FlatAppearance.BorderSize = 0;
            bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_exit.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bt_exit.ForeColor = System.Drawing.SystemColors.Window;
            bt_exit.Location = new System.Drawing.Point(59, 815);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new System.Drawing.Size(110, 51);
            bt_exit.TabIndex = 4;
            bt_exit.Text = "Exit";
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(511, 364);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(525, 43);
            this.txt_user.TabIndex = 0;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(511, 644);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(525, 43);
            this.txt_pass.TabIndex = 1;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.DarkRed;
            this.bt_login.FlatAppearance.BorderSize = 0;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(502, 796);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(254, 56);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_register
            // 
            this.bt_register.BackColor = System.Drawing.Color.DarkRed;
            this.bt_register.FlatAppearance.BorderSize = 0;
            this.bt_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_register.ForeColor = System.Drawing.Color.White;
            this.bt_register.Location = new System.Drawing.Point(780, 796);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(256, 56);
            this.bt_register.TabIndex = 3;
            this.bt_register.Text = "Register";
            this.bt_register.UseVisualStyleBackColor = false;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thai.Properties.Resources.Unlimited_Pasta_Fest___3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1546, 946);
            this.Controls.Add(bt_exit);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_register;
    }
}