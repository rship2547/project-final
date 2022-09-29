namespace Thai
{
    partial class Form9
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.แก้ไขสินค้า = new System.Windows.Forms.Label();
            this.bt_food = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Thai.Properties.Resources.food___beverage__3_1;
            this.pictureBox1.Location = new System.Drawing.Point(545, -25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // แก้ไขสินค้า
            // 
            this.แก้ไขสินค้า.AutoSize = true;
            this.แก้ไขสินค้า.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.แก้ไขสินค้า.ForeColor = System.Drawing.Color.DarkKhaki;
            this.แก้ไขสินค้า.Location = new System.Drawing.Point(292, 479);
            this.แก้ไขสินค้า.Name = "แก้ไขสินค้า";
            this.แก้ไขสินค้า.Size = new System.Drawing.Size(0, 32);
            this.แก้ไขสินค้า.TabIndex = 1;
            // 
            // bt_food
            // 
            this.bt_food.BackColor = System.Drawing.Color.Tomato;
            this.bt_food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_food.ForeColor = System.Drawing.Color.White;
            this.bt_food.Location = new System.Drawing.Point(146, 441);
            this.bt_food.Name = "bt_food";
            this.bt_food.Size = new System.Drawing.Size(578, 138);
            this.bt_food.TabIndex = 2;
            this.bt_food.Text = "แก้ไขสินค้า";
            this.bt_food.UseVisualStyleBackColor = false;
            this.bt_food.Click += new System.EventHandler(this.bt_food_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(880, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(546, 138);
            this.button2.TabIndex = 3;
            this.button2.Text = "รายได้";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.DarkRed;
            this.bt_exit.FlatAppearance.BorderSize = 0;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_exit.Location = new System.Drawing.Point(524, 747);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(565, 55);
            this.bt_exit.TabIndex = 7;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thai.Properties.Resources.ดีไซน์ที่ไม่มีชื่อ__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1546, 946);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_food);
            this.Controls.Add(this.แก้ไขสินค้า);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label แก้ไขสินค้า;
        private System.Windows.Forms.Button bt_food;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_exit;
    }
}