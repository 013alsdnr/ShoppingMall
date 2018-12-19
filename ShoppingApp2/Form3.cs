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
    public partial class Form3 : Form
    {
        private string username;
        private int user_code;

        private int totalPrice;

        public string passvalue
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public int User_code
        {
            get { return this.user_code; }
            set { this.user_code = value; }
        }

        List<Product> productList = new List<Product>();
       
        public Form3()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            NewMethod();
            User_CodeLabel.Text = user_code.ToString();


            // TODO: 이 코드는 데이터를 'shoppingDBDataSet.TBL_PRODUCT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.shoppingDBDataSet.TBL_PRODUCT.Columns.Add("checkbox");
            this.tBL_PRODUCTTableAdapter.Fill(this.shoppingDBDataSet.TBL_PRODUCT);
            dataGridView1.ClearSelection();

        }

        private void NewMethod()
        {
            NameLabel.Text = passvalue + "님 안녕하세요!";
        }

        private void basketBtn_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(productList);

            
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckBox"];
                chk.Value = chk.FalseValue;
            }
            //dataGridView1.ClearSelection();

            this.Visible = false;

            f4.TotalPrice = totalPrice;
            f4.Usercode = user_code;
            f4.UserName = username;
            f4.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["CheckBox"];

            if (string.IsNullOrEmpty(chkCell.Value.ToString()))
            {
                chkCell.Value = "N";
            }

            switch (chkCell.Value.ToString())
            {
                case "N":
                    chkCell.Value = "Y";
                    break;
                case "Y":
                    chkCell.Value = "N";
                    break;
            }


            //MessageBox.Show("chkval [" + chkCell.Value  + "]");

            
            if (chkCell.Value.Equals("Y"))
            {
                Product product = new Product();
                product.Product_name = dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_NAME"].Value.ToString();
                product.Product_price = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_PRICE"].Value.ToString());
                product.Product_code = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_CODE"].Value.ToString());
                product.User_code = user_code;
                productList.Add(product);

                totalPrice += Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_PRICE"].Value.ToString());
                //MessageBox.Show("true : PRODUCT_PRICE >> " + dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_PRICE"].Value.ToString());
            }
            else if (chkCell.Value.Equals("N"))
            {
                int productCode = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_CODE"].Value.ToString());
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].Product_code == productCode)
                    {
                        productList.Remove(productList[i]);
                    }
                }
                totalPrice -= Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_PRICE"].Value.ToString());
                // MessageBox.Show("flag가 true로 들어옴");
                //MessageBox.Show("false : PRODUCT_PRICE >> " + dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_PRICE"].Value.ToString());
            }

            TotalPriceLabel.Text = "결제금액 :  " + totalPrice.ToString() + "원";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tBL_PRODUCTTableAdapter.FillBy(this.shoppingDBDataSet.TBL_PRODUCT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //검색기능, 분류기능 추가
    }
}

