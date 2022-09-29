using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thai
{
    public partial class allmenu : UserControl
    {   
        DataTable data;
        ListViewItem itm;
        String[] arl = new String[3];
        public static string globalday;
        String id;

        MySqlConnection con = new MySqlConnection("Server='localhost';Database='thaifood';user='root';password=;");
        MySqlCommand cmd;
        MySqlDataReader dr;

        public static ListView globallistview;
        //public static string globalorder;
        //public static string globaluser;
        //public static string globalname;
       

        public allmenu()
        {
            InitializeComponent();
           // MessageBox.Show("in form all menu table==> " + table.globalorde_t);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            globallistview = listView1;
            lb_day.Text = DateTime.Now.ToString("dd/MM/yyyy");
            globalday = lb_day.Text;
            // MessageBox.Show("in form all menu name==> " + globalname + "  user==> " + globaluser);



        }
    
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            lb_table.Text = table.globalorder;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                arl[0] = "ต้มยำขึ้นสวรรค์";
                arl[1] = numericUpDown1.Value.ToString();
                arl[2] = 120 + " ";
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown1.Maximum = numericUpDown1.Maximum - numericUpDown1.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                    
               }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);


        }

        private void raca_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void n_tomyum_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data1_cellclick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                arl[0] = "ปลากดว่าอร่อย";
                arl[1] = numericUpDown2.Value.ToString();
                arl[2] = 100 + " "; 
                if (numericUpDown2.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown1.Maximum = numericUpDown2.Maximum - numericUpDown2.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                arl[0] = "ตำแสบเเซ่บ";
                arl[1] = numericUpDown3.Value.ToString();
                arl[2] = 60 + " ";
                if (numericUpDown3.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown3.Maximum = numericUpDown3.Maximum - numericUpDown3.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                arl[0] = "ผัดผงงงจังเลย";
                arl[1] = numericUpDown4.Value.ToString();
                arl[2] = 80 + " ";
                if (numericUpDown4.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown1.Maximum = numericUpDown4.Maximum - numericUpDown4.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                arl[0] = "หมูข่อยโดนเต๊ะ";
                arl[1] = numericUpDown5.Value.ToString();
                arl[2] = 70 + " ";
                if (numericUpDown5.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown5.Maximum = numericUpDown5.Maximum - numericUpDown5.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
                arl[0] = "คนละยำ";
                arl[1] = numericUpDown6.Value.ToString();
                arl[2] = 90 + " ";
                if (numericUpDown6.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown6.Maximum = numericUpDown6.Maximum - numericUpDown6.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
                arl[0] = "ทอดมันกุ้ง เเต่หนูมันกว่า";
                arl[1] = numericUpDown7.Value.ToString();
                arl[2] = 60 + " ";
                if (numericUpDown7.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown7.Maximum = numericUpDown7.Maximum - numericUpDown7.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                arl[0] = "ผมไม่ได้เผา กุ้งเผา";
                arl[1] = numericUpDown8.Value.ToString();
                arl[2] = 320 + " ";
                if (numericUpDown8.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown8.Maximum = numericUpDown8.Maximum - numericUpDown8.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
                arl[0] = "ราดหน้าเหนียวข้น";
                arl[1] = numericUpDown9.Value.ToString();
                arl[2] = 50 + " ";
                if (numericUpDown9.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown9.Maximum = numericUpDown9.Maximum - numericUpDown9.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
                arl[0] = "ผัดอะไรเด็กไม่กิน ";
                arl[1] = numericUpDown10.Value.ToString();
                arl[2] = 70 + " ";
                if (numericUpDown10.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown10.Maximum = numericUpDown10.Maximum - numericUpDown10.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
                arl[0] = "ต้มข๋าไกร่";
                arl[1] = numericUpDown11.Value.ToString();
                arl[2] = 120 + " ";
                if (numericUpDown11.Value == 0)
                {
                    MessageBox.Show("โปรดเลือกจำนวนสินค้า");
                }
                else
                {
                    numericUpDown11.Maximum = numericUpDown11.Maximum - numericUpDown11.Value;
                    itm = new ListViewItem(arl);
                    listView1.Items.Add(itm);
                }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void pay_Click(object sender, EventArgs e)
        {
            new Form7(table.globalname,table.globaluser, lb_table.Text, lb_day.Text).Show();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
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


        private void button15_Click(object sender, EventArgs e)
        {

            //MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=all_order;");
            //con.Open();
            //String sql = $"INSERT INTO all_order (food,amount,price) VALUES ('{Food}','{Amount}','{Price}')";
            //MySqlCommand cmd = new MySqlCommand(sql, con);
            //int rows = cmd.ExecuteNonQuery();
            //con.Close();

            //if (rows >= 0)
            //{
            //    MessageBox.Show("  success  ");
            //}


          


            //MessageBox.Show(listView1.ToString);
            //menuorder(food, amount, price);
            
            List<string> list = new List<string>();
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                string name = listView1.Items[i].SubItems[0].Text;
                string amount = listView1.Items[i].SubItems[1].Text;
                string price = listView1.Items[i].SubItems[2].Text;
                list.Add(name + "-" + amount + "-" + price);
            }

            foreach (string item in list)
            {
                // MessageBox.Show(item);
                string order = lb_table.Text;
                string[] item_split = item.Split('-');
             //   MessageBox.Show(item_split[0] + " " + item_split[1] + " " + item_split[2]);
                menuorder(order, item_split[0], Convert.ToInt32(item_split[1]), Convert.ToInt32(item_split[2]));
            }
            MessageBox.Show("สั่งซื้อสินค้าเสร็จเเล้วค่ะ");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }


        private void menuorder(string order,string food, int amount, int price)
        {

            string sql = "INSERT INTO all_order (user,day,or_der,food,amount,price) VALUES ('" + table.globaluser + "','" + lb_day.Text + "','" + order+"','"+food+"','"+amount+"','"+price+"')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            int rows = cmd.ExecuteNonQuery();
            con.Close();

            if (rows > 0)
            {
               // MessageBox.Show("สั่งซื้อสินค้าเสร็จเเล้วค่ะ");

            }
        }

        
        private void button13_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("in form all menu table==> " + globalorder);
            // MessageBox.Show("in form all menu table.global==> " + table.globalorde_t);
            
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);            
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_order_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void allmenu_Load(object sender, EventArgs e)
        {
            
        }

        private void lb_table_Click(object sender, EventArgs e)
        {
          
        }

        private void label26_Click_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            arl[0] = "ต้มข๋าไกร่";
            arl[1] = numericUpDown12.Value.ToString();
            arl[2] = 120 + " ";
            if (numericUpDown12.Value == 0)
            {
                MessageBox.Show("โปรดเลือกจำนวนสินค้า");
            }
            else
            {
                numericUpDown12.Maximum = numericUpDown12.Maximum - numericUpDown12.Value;
                itm = new ListViewItem(arl);
                listView1.Items.Add(itm);
            }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            arl[0] = "ต้มข๋าไกร่";
            arl[1] = numericUpDown13.Value.ToString();
            arl[2] = 120 + " ";
            if (numericUpDown11.Value == 0)
            {
                MessageBox.Show("โปรดเลือกจำนวนสินค้า");
            }
            else
            {
                numericUpDown11.Maximum = numericUpDown11.Maximum - numericUpDown11.Value;
                itm = new ListViewItem(arl);
                listView1.Items.Add(itm);
            }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            arl[0] = "ต้มข๋าไกร่";
            arl[1] = numericUpDown11.Value.ToString();
            arl[2] = 120 + " ";
            if (numericUpDown11.Value == 0)
            {
                MessageBox.Show("โปรดเลือกจำนวนสินค้า");
            }
            else
            {
                numericUpDown11.Maximum = numericUpDown11.Maximum - numericUpDown11.Value;
                itm = new ListViewItem(arl);
                listView1.Items.Add(itm);
            }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            arl[0] = "ต้มข๋าไกร่";
            arl[1] = numericUpDown11.Value.ToString();
            arl[2] = 120 + " ";
            if (numericUpDown11.Value == 0)
            {
                MessageBox.Show("โปรดเลือกจำนวนสินค้า");
            }
            else
            {
                numericUpDown11.Maximum = numericUpDown11.Maximum - numericUpDown11.Value;
                itm = new ListViewItem(arl);
                listView1.Items.Add(itm);
            }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            label_total.Text = Convert.ToString(gtotal);
        }
    }
    }
    
          
