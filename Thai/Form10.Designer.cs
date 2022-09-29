namespace Thai
{
    partial class Form10
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.txt_name_food = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.txt_price_food = new System.Windows.Forms.TextBox();
            this.dataGrid_food = new System.Windows.Forms.DataGridView();
            this.bt_out = new System.Windows.Forms.Button();
            this.bt_add_image = new System.Windows.Forms.Button();
            this.lab_path = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.Tomato;
            this.bt_add.FlatAppearance.BorderSize = 0;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_add.ForeColor = System.Drawing.Color.DarkRed;
            this.bt_add.Location = new System.Drawing.Point(124, 748);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(178, 73);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "เพิ่ม";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Tomato;
            this.bt_delete.FlatAppearance.BorderSize = 0;
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_delete.ForeColor = System.Drawing.Color.DarkRed;
            this.bt_delete.Location = new System.Drawing.Point(545, 748);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(163, 73);
            this.bt_delete.TabIndex = 1;
            this.bt_delete.Text = "ลบ";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.AutoEllipsis = true;
            this.bt_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_update.BackColor = System.Drawing.Color.Tomato;
            this.bt_update.FlatAppearance.BorderSize = 0;
            this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_update.ForeColor = System.Drawing.Color.DarkRed;
            this.bt_update.Location = new System.Drawing.Point(342, 748);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(172, 73);
            this.bt_update.TabIndex = 2;
            this.bt_update.Text = "แก้ไข";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // txt_name_food
            // 
            this.txt_name_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_name_food.Location = new System.Drawing.Point(193, 249);
            this.txt_name_food.Name = "txt_name_food";
            this.txt_name_food.Size = new System.Drawing.Size(350, 30);
            this.txt_name_food.TabIndex = 3;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.menu.ForeColor = System.Drawing.Color.DarkRed;
            this.menu.Location = new System.Drawing.Point(119, 251);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(57, 25);
            this.menu.TabIndex = 4;
            this.menu.Text = "เมนู :";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.price.ForeColor = System.Drawing.Color.DarkRed;
            this.price.Location = new System.Drawing.Point(587, 254);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(64, 25);
            this.price.TabIndex = 5;
            this.price.Text = "ราคา :";
            // 
            // txt_price_food
            // 
            this.txt_price_food.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_price_food.Location = new System.Drawing.Point(667, 251);
            this.txt_price_food.Name = "txt_price_food";
            this.txt_price_food.Size = new System.Drawing.Size(166, 30);
            this.txt_price_food.TabIndex = 6;
            // 
            // dataGrid_food
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_food.Location = new System.Drawing.Point(948, 179);
            this.dataGrid_food.Name = "dataGrid_food";
            this.dataGrid_food.RowHeadersWidth = 51;
            this.dataGrid_food.RowTemplate.Height = 24;
            this.dataGrid_food.Size = new System.Drawing.Size(556, 589);
            this.dataGrid_food.TabIndex = 8;
            this.dataGrid_food.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_food_CellMouseClick);
            // 
            // bt_out
            // 
            this.bt_out.BackColor = System.Drawing.Color.DarkRed;
            this.bt_out.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_out.Location = new System.Drawing.Point(24, 29);
            this.bt_out.Name = "bt_out";
            this.bt_out.Size = new System.Drawing.Size(137, 50);
            this.bt_out.TabIndex = 9;
            this.bt_out.Text = "กลับเมนู";
            this.bt_out.UseVisualStyleBackColor = false;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // bt_add_image
            // 
            this.bt_add_image.BackColor = System.Drawing.Color.DarkRed;
            this.bt_add_image.FlatAppearance.BorderSize = 0;
            this.bt_add_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add_image.ForeColor = System.Drawing.Color.White;
            this.bt_add_image.Location = new System.Drawing.Point(505, 675);
            this.bt_add_image.Name = "bt_add_image";
            this.bt_add_image.Size = new System.Drawing.Size(202, 27);
            this.bt_add_image.TabIndex = 10;
            this.bt_add_image.Text = "เลือกรูปภาพ";
            this.bt_add_image.UseVisualStyleBackColor = false;
            this.bt_add_image.Click += new System.EventHandler(this.bt_add_image_Click);
            // 
            // lab_path
            // 
            this.lab_path.AutoSize = true;
            this.lab_path.Location = new System.Drawing.Point(176, 680);
            this.lab_path.Name = "lab_path";
            this.lab_path.Size = new System.Drawing.Size(0, 16);
            this.lab_path.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Thai.Properties.Resources.Lay_Thai_res;
            this.pictureBox2.Location = new System.Drawing.Point(382, -84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 784);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(556, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "ตัวอย่างหน้าเมนู";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thai.Properties.Resources.Unlimited_Pasta_Fest___2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1546, 946);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_path);
            this.Controls.Add(this.bt_add_image);
            this.Controls.Add(this.bt_out);
            this.Controls.Add(this.dataGrid_food);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_price_food);
            this.Controls.Add(this.price);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.txt_name_food);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.TextBox txt_name_food;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox txt_price_food;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGrid_food;
        private System.Windows.Forms.Button bt_out;
        private System.Windows.Forms.Button bt_add_image;
        private System.Windows.Forms.Label lab_path;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}