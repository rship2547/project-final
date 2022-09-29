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
    public partial class pay : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server='localhost';Database='thaifood';user='root';password=;");
        MySqlCommand cmd;
        MySqlDataReader dr;

        public static ListView globallistview;
        public static string globalorder;
        public static string globaluser;
        public static string globalname;

        public pay()
        {
            InitializeComponent();
        }

        private void pay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form7(table.globalname, table.globaluser, table.globalorder, allmenu.globalday).Show();
            Hide();
        }






    }
}
