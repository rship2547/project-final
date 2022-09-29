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
    public partial class Form5 : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
       
        public Form5()
        {
            InitializeComponent();
            con = new MySqlConnection("Server='localhost';Database='thaifood';user='root';Pwd='';SslMode=none");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
        }


        private void button1_Click(object sender, EventArgs e) //ปุ้มlogin
        {
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            string name = "";
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM user where user='" + user + "' AND password='" + pass + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name = dr.GetString(3);
                MessageBox.Show("ยินดีต้อนรับสู่ Laythai");
                new form_order(name, user).Show();
                con.Close();
                this.Close();


             }
            else if (user == "admintonliw" && pass == "admintonliw")
            {
                MessageBox.Show("สวัสดีคุณแอดมิน ^_^");
                new Form9().Show();
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
                txt_user.Text = "";
                txt_pass.Text = "";
                con.Close();
            }
            
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            new formlogin().Show();
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
