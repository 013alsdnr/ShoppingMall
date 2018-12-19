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
    public partial class Form2 : Form
    {
        string email;
        string name;
        string phone;
        string password;
        string address;

        Con_database db;
        DataTable dt;

        public Form2()
        {
            InitializeComponent();
            db = new Con_database();
            db.ConnectDB();
            E_mailBox.LostFocus += new EventHandler(E_mailBox_LostFocus);
            PhoneBox.LostFocus += new EventHandler(PhoneBox_LostFocus);
            PhoneBox.GotFocus += new EventHandler(PhoneBox_GotFocus);
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            email = E_mailBox.Text;
            name = NameBox.Text;
            phone = PhoneBox.Text;
            password = PasswordBox.Text;
            address = AddressBox.Text;

            if(email=="" || name=="" || phone=="" || password=="" || address == "")
            {
                MessageBox.Show("모든 항목을 작성해주셔야 합니다.");
                return;
            }

            string sql = "INSERT INTO TBL_USER(USER_EMAIL, USER_NAME, USER_PHONE, USER_PW, USER_ADDRESS)" +
                         "VALUES(" + "'" + email + "'" + ", " + "'" + name + "'" + ", " + "'" + phone + "'" + ", "
                         + "'" + password + "'" + ", " + "'" + address + "'" + ")";

            try
            {
                dt = db.GetDBTable(sql);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("SQL 오류");
                return;
            }


            MessageBox.Show("회원가입에 성공했습니다.");

            this.Visible = false;
            Form1 f1 = new Form1();
            f1.ShowDialog();

            db.CloseDB();
        }

        public int countChar(string Sentence, string Character)
        {
            int count = (Sentence.Length - Sentence.Replace(Character, "").Length) / Character.Length;
            return count;
        }

        private void E_mailBox_LostFocus(object sender, EventArgs e)
        {
            //MessageBox.Show("로스트포커스 함수 들어옴");
            email = E_mailBox.Text;

            int @count = countChar(email, "@");
            //MessageBox.Show(@count.ToString());

            int dotCount = countChar(email, ".");
            //MessageBox.Show(dotCount.ToString());

            if (@count != 1 || dotCount > 2)
            {
                MessageBox.Show("Email 양식에 맞지 않습니다.");
                E_mailBox.Text = "";
                E_mailBox.Focus();
            }
        }

        private void PhoneBox_GotFocus(object sender, EventArgs e)
        {
            PhoneBox.Text = "";
            PhoneBox.ForeColor = Color.Black;
        }

        private void PhoneBox_LostFocus(object sender, EventArgs e)
        {
            if(PhoneBox.Text.Length != 11)
            {
                MessageBox.Show("핸드폰 번호를 잘 못 입력하셨습니다.");
                PhoneBox.Text = "";
                PhoneBox.Focus();
            }
            
        }

        private void EmailCheckBtn_Click(object sender, EventArgs e)
        {
            string email = E_mailBox.Text;
            string dbEmail = "";
            string sql = "SELECT USER_EMAIL FROM TBL_USER WHERE USER_EMAIL = " + "'" + email + "'";

            dt = db.GetDBTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                dbEmail = dr["user_email"].ToString();
            }

            if (email == dbEmail)
            {
                MessageBox.Show("이미 가입된 이메일 입니다.");
                E_mailBox.Text = "";
                E_mailBox.Focus();
                return;
            }
            else
            {
                MessageBox.Show("사용 가능한 이메일 입니다.");
            }
        }

        private void PhoneCheckBtn_Click(object sender, EventArgs e)
        {
            string phone = PhoneBox.Text;
            string dbPhone = "";
            string sql = "SELECT USER_PHONE FROM TBL_USER WHERE USER_PHONE = " + "'" + phone + "'";

            dt = db.GetDBTable(sql);

            foreach (DataRow dr in dt.Rows)
            {
                dbPhone = dr["user_phone"].ToString();
            }

            if (phone == dbPhone)
            {
                MessageBox.Show("이미 가입된 핸드폰번호 입니다.");
                PhoneBox.Text = "";
                PhoneBox.Focus();
                return;
            }
            else
            {
                MessageBox.Show("사용 가능한 핸드폰번호 입니다.");
            }
        }
    }
}
