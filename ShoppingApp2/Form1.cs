using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp2
{
    public partial class Form1 : Form
    {
        Con_database db;
        private string username = "";
        private int user_code = 0;

        public Form1()
        {
            InitializeComponent();
            db = new Con_database();
            db.ConnectDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select user_name, user_code from tbl_user where user_email = "
                          + "'" + EmailBox.Text + "'" + " and " + "user_pw = "
                          + "'" + PasswordBox.Text + "'";

            DataTable dt = db.GetDBTable(sql);
            

            if(dt.Rows.Count == 0)
            {
                MessageBox.Show("회원정보가 없습니다.");
                EmailBox.Text = "";
                PasswordBox.Text = "";
                EmailBox.Focus();
                return;
            }

            foreach(DataRow dr in dt.Rows)
            {
                username = dr["USER_NAME"].ToString();
                user_code = Int32.Parse(dr["USER_CODE"].ToString());
                MessageBox.Show(username + "님 환영합니다.");
            }

            this.Visible = false;
            Form3 f3 = new Form3();
            f3.passvalue = username;
            f3.User_code = user_code;
            f3.ShowDialog();

            //textBox1.Text = sql;
            db.CloseDB();
        }


    }
}
