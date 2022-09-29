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
    public partial class formlogin : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public formlogin()
        {
            InitializeComponent();
            con = new MySqlConnection("Server='localhost';Database='thaifood';user='root';Pwd='';SslMode=none");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
        }

        private void button1_Click(object sender, EventArgs e) //ปุ่มregis
        {
            if (txt_user.Text != "" && txt_pass.Text != "")
            {
                cmd = new MySqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM user where user='" + txt_user.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {                    
                    MessageBox.Show("User นี้ถูกใช้งานไปแล้ว กรุณากำหนด User ใหม่อีกครั้ง");
                    txt_user.Text = "";
                    txt_pass.Text = "";
                    txt_name.Text = "";
                    txt_number.Text = "";
                    con.Close();
                }
                else
                {
                    con.Close();                    
                    cmd.CommandText = "INSERT INTO user (id_user,user,password,name,tel_number) VALUES (NULL, '"+txt_user.Text+"', '"+txt_pass.Text+"', '"+txt_name.Text+"', '"+txt_number.Text+"')";
                    con.Open();
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("  ลงทะเบียนสำเร็จเเล้ว  ");
                    if (row > 0)
                    {
                        
                        new Form5().Show();
                        this.Close();
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("กรุณากำหนด User และ Password ");
            }


           
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e) 
        {
            new Form5().Show();
            this.Close();
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_number_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
