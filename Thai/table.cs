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
    public partial class table : UserControl
    {
        public static string globalorder;
        public static string globaluser;
        public static string globalname;
        public table()
        {
            InitializeComponent();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void T_4_Click(object sender, EventArgs e)
        {            
            if (T_4.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    T_4.BackColor = Color.Red;                    
                    globalorder = "4";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                    
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_4.BackColor = Color.LawnGreen;
            }
        }

        private void T_1_Click(object sender, EventArgs e)
        {
            
            if (T_1.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    T_1.BackColor = Color.Red;                   
                    globalorder = "1";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_1.BackColor = Color.LawnGreen;
            }
        }
    

        private void T_7_Click(object sender, EventArgs e)
        {
            if (T_7.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    globalorder = "7";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                    T_7.BackColor = Color.Red;
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_7.BackColor = Color.LawnGreen;
            }
        }

        private void table_Load(object sender, EventArgs e)
        {
            T_1.BackColor = Color.LawnGreen;
            T_2.BackColor = Color.LawnGreen;
            T_3.BackColor = Color.LawnGreen;
            T_4.BackColor = Color.LawnGreen;
            T_5.BackColor = Color.LawnGreen;
            T_6.BackColor = Color.LawnGreen;
            T_7.BackColor = Color.LawnGreen;
            T_8.BackColor = Color.LawnGreen;
            T_9.BackColor = Color.LawnGreen;

        }

        private void T_2_Click(object sender, EventArgs e)
        {
            if (T_2.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    globalorder = "2";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                    T_2.BackColor = Color.Red;
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_2.BackColor = Color.LawnGreen;
            }
        }

        private void T_5_Click(object sender, EventArgs e)
        {
            if (T_5.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    globalorder = "5";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                    T_5.BackColor = Color.Red;
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_5.BackColor = Color.LawnGreen;
            }
        }

        private void T_8_Click(object sender, EventArgs e)
        {
            if (T_8.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    globalorder = "8";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                    T_8.BackColor = Color.Red;
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_8.BackColor = Color.LawnGreen;
            }
        }

        private void T_3_Click(object sender, EventArgs e)
        {
            if (T_3.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    globalorder = "3";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                    T_3.BackColor = Color.Red;
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_3.BackColor = Color.LawnGreen;
            }
        }

        private void T_6_Click(object sender, EventArgs e)
        {
            if (T_6.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    globalorder = "6";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                    T_6.BackColor = Color.Red;
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_6.BackColor = Color.LawnGreen;
            }
        }

        private void T_9_Click(object sender, EventArgs e)
        {
            if (T_9.BackColor == Color.LawnGreen)
            {
                if (MessageBox.Show("คุณต้องการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    globalorder = "9";
                    //  Parent.Controls["allmenu1"].BringToFront();
                    new Form11().Show();
                    T_9.BackColor = Color.Red;
                }
                    
            }
            else
            {
                if (MessageBox.Show("คุณต้องการยกเลิกการเปิดโต๊ะนี้ใช่หรือไม่?", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    T_9.BackColor = Color.LawnGreen;
            }
        }
    }
}
