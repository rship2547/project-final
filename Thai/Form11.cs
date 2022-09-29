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
    public partial class Form11 : Form
    {
        String[] arl = new String[3];
        ListViewItem itm;
        public static ListView globallistview;
        public static string globalday;
        public Form11()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            globallistview = listView1;
            lb_day.Text = DateTime.Now.ToString("dd/MM/yyyy");
            globalday = lb_day.Text;
        }
        private MySqlConnection databaseConnection()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=thaifood;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showEquipment() //เชื่อมดาต้าเบสเมนูอาหาร เพื่อเเสดงในดาต้ากริวิว
        {
            MySqlConnection conn = databaseConnection();
            DataTable valami = new DataTable();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM all_food  ";
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
                dataGrid_order.DataSource = valami;


                //Set AutoGenerateColumns False.
                dataGrid_order.AutoGenerateColumns = false;

                dataGrid_order.Columns["id"].HeaderText = "รายการ";
                dataGrid_order.Columns["id"].Width = 50;
                dataGrid_order.Columns["namefood"].HeaderText = "เมนู";
                dataGrid_order.Columns["price"].HeaderText = "ราคา";
                dataGrid_order.Columns["pathimage"].HeaderText = "Path";
            }

        }
        private void menuorder(string order, string food, int amount, int price) //เก็บออเดออาหาร ประวัติ
        {
            MySqlConnection con = databaseConnection();
            string sql = "INSERT INTO all_order (user,day,or_der,food,amount,price) VALUES ('" + table.globaluser + "','" + lb_day.Text + "','" + order + "','" + food + "','" + amount + "','" + price + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows > 0)
            {
                // MessageBox.Show("สั่งซื้อสินค้าเสร็จเเล้วค่ะ");

            }
            
            new Form7(table.globalname, table.globaluser, lb_table.Text, lb_day.Text).Show();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            showEquipment();
            lb_table.Text = table.globalorder;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGrid_order_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)  //โชว์รูปภาพถ้าเราคลิกด่ต้ากริด
        {
            string pathimg = dataGrid_order.CurrentRow.Cells[3].Value.ToString();            
            if (Path.GetFileName(pathimg) != "")
            {
                string newFileName = pathimg.Replace("\\", @"\");

                pictureBox_show.Image = new Bitmap(newFileName);

            }
            else
            {
                pictureBox_show.Image = null;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_order_Click(object sender, EventArgs e) //ปุ่มสั่งสินค้า
        {
            arl[0] = dataGrid_order.CurrentRow.Cells[1].Value.ToString(); //คำสั่งให้ชื่อเมนูปรากฏขึ้นในลิสวิว
            arl[1] = numericUpDown_order.Value.ToString();
            arl[2] = dataGrid_order.CurrentRow.Cells[2].Value.ToString() + " ";
            if (numericUpDown_order.Value == 0)
            {
                MessageBox.Show("โปรดเลือกจำนวนสินค้า");
            }
            else
            {
                numericUpDown_order.Maximum = numericUpDown_order.Maximum - numericUpDown_order.Value;
                itm = new ListViewItem(arl);
                listView1.Items.Add(itm);

            }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
            numericUpDown_order.Value=0;
        }

        private void bt_delete_list_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);

            MessageBox.Show("คุณได้ลบเมนูสินค้า");
        }

        private void bt_comfirm_Click(object sender, EventArgs e) 
        {
            List<string> list = new List<string>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string name = listView1.Items[i].SubItems[0].Text;
                string amount = listView1.Items[i].SubItems[1].Text;
                string price = listView1.Items[i].SubItems[2].Text;
                list.Add(name + "-" + amount + "-" + price);
            }
            //ปุ่มคอนเฟิม หลังจากกดปุ่ม เมนูทั้งหมดในลิสวิวจะเก็บลงไปในดาต้าเบส ผ่านการทำงานของฟังชั่น menuorder

            foreach (string item in list)
            {
                
                string order = lb_table.Text;
                string[] item_split = item.Split('-');
              
                menuorder(order, item_split[0], Convert.ToInt32(item_split[1]), Convert.ToInt32(item_split[2]));
            }
            MessageBox.Show("สั่งซื้อสินค้าเสร็จเเล้วค่ะ");
            this.Close();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel_list_order_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_day_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_total_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form7(table.globalname, table.globaluser, lb_table.Text, lb_day.Text).Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)| *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = new Bitmap(open.FileName);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)| *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox8.Image = new Bitmap(open.FileName);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)| *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.Image = new Bitmap(open.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)| *.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open.FileName);
            }
        }

        private void dataGrid_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
