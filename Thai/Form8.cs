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
    public partial class Form8 : Form
    {
        public static ListView globallistview;
        ListViewItem itm;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            showEquipment(DateTime.Now.ToString("dd/MM/yyyy"));
        }
        private MySqlConnection databaseConnection()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=thaifood;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showEquipment(string day)
        {
            MySqlConnection conn = databaseConnection();
            // DataSet ds = new DataSet();
            var valami = new DataTable();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM all_order where day='" + day + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(valami);
            conn.Close();
            var result = new string[5];
            var row_c = valami.Rows.Count;
            if (row_c == 0)
            {
                MessageBox.Show("ไม่มีรายได้ในวันนี้");
            }
            else
            {
                DataRow dr;
                for (var i = 0; i < row_c; i++)
                {
                    dr = valami.Rows[i];
                    result[0] = dr[1].ToString();
                    result[1] = dr[3].ToString();
                    result[2] = dr[4].ToString();
                    result[3] = dr[5].ToString();
                    result[4] = dr[6].ToString();
                    itm = new ListViewItem(result);
                    listView1.Items.Add(itm);
                    //   MessageBox.Show(result[i]);

                }
                decimal gtotal = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += decimal.Parse(lstItem.SubItems[3].Text) * decimal.Parse(lstItem.SubItems[4].Text);
                }
                lb_total.Text = Convert.ToString(gtotal);
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //เลือกวันเเล้วไปทำงานshowEquipment
        {
            showEquipment(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
        }

        private void register_Click(object sender, EventArgs e) //ปุ่มปิด
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //new form_order().Show();
            //this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void lb_total_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
