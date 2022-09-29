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
    public partial class Form7 : Form
    {
        public static ListView globallistview;
        public static string globalorder;
        public static string globaluser;
        public static string globalname;
        ListViewItem itm;
        public Form7(string name_s,string user_s,string order_s, string day_s)
        {
            InitializeComponent();
            
            globalname = name_s;
            globaluser = user_s;
            globalorder = order_s;
            label6.Text = name_s;
            label7.Text = user_s;
            lb_show_table.Text = order_s;
            lb_day_show.Text = day_s;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            globallistview = listView1;

        }

        private MySqlConnection databaseConnection()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=thaifood;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void showEquipment()   //เรียกประวัติสินค้าที่ลูกค้าซื้อมาเเสดงในลิสวิว
        {
            MySqlConnection conn = databaseConnection();
           // DataSet ds = new DataSet();
            var valami = new DataTable();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM all_order where or_der='" + globalorder + "' AND user='" + globaluser + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(valami);
            conn.Close();
            var result = new string[3];
            var row_c = valami.Rows.Count;
            DataRow dr ;
            for (var i = 0; i < row_c; i++)
            {
                dr = valami.Rows[i];
                result[0] = dr[4].ToString();
                result[1] = dr[5].ToString();
                result[2] = dr[6].ToString();
                itm = new ListViewItem(result);
                listView1.Items.Add(itm);
             //   MessageBox.Show(result[i]);

            }
            decimal gtotal = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += decimal.Parse(lstItem.SubItems[1].Text) * decimal.Parse(lstItem.SubItems[2].Text);
            }
            lb_total.Text = Convert.ToString(gtotal);
        }
        private void form_bill_Load(object sender, EventArgs e)  //เรียนทำงาน
        {
            allmenu.globallistview.Show();
            showlistview();
            showEquipment();
        }
        private void showlistview()
        {
            //MessageBox.Show(ListView1.Text);

        }


        private void dataEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //allmenu.globallistview.Show();
        }

        private void listorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            //allmenu.globallistview.();
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedItem = listView2.Items[.Select].ToString();
           
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  //ปุ่มออกไปหน้าlogin
        {
            new Form5().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e) //ปุ่มย้อนกลับ
        {
            //new Form11(globalname,globaluser).Show();
            //this.Hide();
            new Form11().Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}
