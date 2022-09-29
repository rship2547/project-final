using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thai
{
    public partial class form_order : Form
    {

        public static string globaluser_or;
        public static string globalname_or;

        public form_order(string name_s,string user_s)
        {
            InitializeComponent();
            table.globalname = name_s;
            table.globaluser = user_s;
            globaluser_or = user_s;
            globalname_or = name_s;
            
            slide.Height = button4.Height;
            slide.Top = button4.Top;
            table1.BringToFront();            
            
            

        }



        private void form_order_Load(object sender, EventArgs e)
        {
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            slide.Height = button1.Height;
            slide.Top = button1.Top;
            
            new Form11().Show();
            table.globalname = globalname_or;
            table.globaluser = globaluser_or;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            slide.Height = button2.Height;
            slide.Top = button2.Top;
            pay1.BringToFront();
            table.globalname = globalname_or;
            table.globaluser = globaluser_or;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allmenu1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //โต้ะ
        {
            slide.Height = button4.Height;
            slide.Top = button4.Top;
            table1.BringToFront();
            table.globalname = globalname_or;
            table.globaluser = globaluser_or;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Close();
        }
    }
}
