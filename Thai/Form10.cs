using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thai
{
    public partial class Form10 : Form
    {
        public static string globalId;

        public Form10()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=thaifood;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void resetdata()  //เคลียรอเลือกสินค้า
        {
            txt_name_food.Clear();
            txt_price_food.Clear();
            lab_path.Text = "";
            globalId = "";
            pictureBox1.Image = null;
        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataTable valami = new DataTable();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM all_food ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(valami);
            conn.Close();
            var row_c = valami.Rows.Count;
            if (row_c == 0)
            {
                MessageBox.Show("ไม่พบข้อมูล");
            }
            else
            {                
                dataGrid_food.DataSource = valami;
                dataGrid_food.Columns["id"].HeaderText = "รายการ";
                dataGrid_food.Columns["namefood"].HeaderText = "เมนู";
                dataGrid_food.Columns["price"].HeaderText = "ราคา";
                dataGrid_food.Columns["pathimage"].HeaderText = "Path";
            }

        }
        private void Add_food(string pathimage, string namefood, int price)
        {
            //  MessageBox.Show("P==> " + pathimage);
            string newFileName = pathimage.Replace("\\", "\\\\");
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO all_food (namefood,price,pathimage) VALUES ('" + namefood + "','" + price + "','" + newFileName + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                 MessageBox.Show("เพิ่มเมนูเสร็จเเล้วค่ะ");
                resetdata();
                showEquipment();
                globalId = "";
            }
        }
        private void Edit_food(int Id, string pathimage, string namefood, int price)
        {
            string newFileName = pathimage.Replace("\\", "\\\\");
            MySqlConnection conn = databaseConnection();
            string sql = "UPDATE all_food SET namefood = '"+ namefood + "',price = '"+ price + "',pathimage = '"+ newFileName + "' WHERE id = '"+ Id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("แก้ไขเมนูเสร็จเเล้วค่ะ");
                resetdata();
                showEquipment();
                globalId = "";
            }
        }
        private void bt_add_Click(object sender, EventArgs e) //ปุ่มเพิ่ม
        {
            if(globalId== "")
            {
                if (txt_name_food.Text != "")
                {
                    string[] files = Directory.GetFiles(@"D:\final\Image\");
                    
                    string pathimage = "D:\\final\\Image\\" + Path.GetFileName(lab_path.Text);
                    string namefood = txt_name_food.Text;
                    int price = Convert.ToInt32(txt_price_food.Text);
                    Add_food(pathimage, namefood, price);
                }

            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            showEquipment();
            globalId = "";
        }

        private void bt_add_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)| *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                lab_path.Text = open.FileName;
            }
        }

        private void dataGrid_food_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_name_food.Text = dataGrid_food.CurrentRow.Cells[1].Value.ToString();
            txt_price_food.Text = dataGrid_food.CurrentRow.Cells[2].Value.ToString();
            lab_path.Text = dataGrid_food.CurrentRow.Cells[3].Value.ToString();           
            globalId = dataGrid_food.CurrentRow.Cells[0].Value.ToString();                       
           
            if (Path.GetFileName(lab_path.Text) != "")
            {
                string newFileName = lab_path.Text.Replace("\\", @"\");

                pictureBox1.Image = new Bitmap(newFileName);

            }

        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_update_Click(object sender, EventArgs e) //ปุ่มเเก้ไข
        { 
            if (globalId != "") 
            {
            int Id = Convert.ToInt32(globalId);
            string pathimage = "D:\\final\\Image\\" + Path.GetFileName(lab_path.Text);
            string namefood = txt_name_food.Text;
            int price = Convert.ToInt32(txt_price_food.Text);
        //    MessageBox.Show("P==> "+ pathimage);
           
           
                Edit_food(Id, pathimage, namefood, price);
            }
            
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (globalId != "")
            {
                int Id = Convert.ToInt32(globalId);
                MySqlConnection conn = databaseConnection();
                string sql = "DELETE FROM all_food WHERE id = '" + Id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("ลบเมนูเสร็จเเล้วค่ะ");
                    resetdata();
                    showEquipment();
                    globalId = "";
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form11().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
