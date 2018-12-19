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
    public partial class Form4 : Form
    {
        private Con_database db;
        private DataTable dt;
        private List<Product> productList = new List<Product>();
        private List<Product> deleteList = new List<Product>();
        private string sql = "";
        private int orderPrice = 0;
        private int user_code;
        private int totalPrice;
        private string user_name;

        public string UserName
        {
            get { return this.user_name; }
            set { this.user_name = value; }
        }

        public int Usercode
        {
            get { return this.user_code; }
            set { this.user_code = value; }
        }

        public int TotalPrice
        {
            get { return this.totalPrice; }
            set { this.totalPrice = value; }
        }


        public Form4(List<Product> productList)
        {
            InitializeComponent();
            db = new Con_database();
            db.ConnectDB();

            this.productList = productList;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            orderPrice += totalPrice;
            OrderPriceLabel.Text = "결제금액 : " + orderPrice.ToString() + "원";
            foreach (Product product in productList)
            {
                //이 안에 인서트 문이 들어가야 된다.
                sql = "INSERT INTO TBL_ORDER(PRODUCT_NAME, PRODUCT_PRICE, USER_CODE)" +
                      "VALUES(" + "'" + product.Product_name + "'" + ", '" + product.Product_price + "'" +
                      ", '" + product.User_code + "')";

                dt = db.GetDBTable(sql);
                
            }

            db.CloseDB();

            // TODO: 이 코드는 데이터를 'shoppingDBDataSet1.TBL_ORDER' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.shoppingDBDataSet1.TBL_ORDER.Columns.Add("checkbox");
            this.tBL_ORDERTableAdapter.Fill(this.shoppingDBDataSet1.TBL_ORDER);

            

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

            if (chkCell.Value.Equals("Y"))
            {
                Product product = new Product();
                product.Order_code = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["ORDER_CODE"].Value.ToString());
                product.Product_price = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_PRICE"].Value.ToString());
                orderPrice -= product.Product_price;
                deleteList.Add(product);
            }

            if (chkCell.Value.Equals("N"))
            {
                int order_code = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["ORDER_CODE"].Value.ToString());
                for (int i = 0; i < deleteList.Count; i++)
                {
                    if (deleteList[i].Order_code == order_code)
                    {
                        deleteList.Remove(deleteList[i]);
                    }
                }
                orderPrice += Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_PRICE"].Value.ToString());
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(Product product in deleteList)
            {
                sql = "DELETE FROM TBL_ORDER WHERE ORDER_CODE = " + product.Order_code;
                dt = db.GetDBTable(sql);
            }

            OrderPriceLabel.Text =  "결제금액 : " + orderPrice.ToString() + "원";
            
            this.tBL_ORDERTableAdapter.Fill(this.shoppingDBDataSet1.TBL_ORDER);
            db.CloseDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 완료 됐습니다.");
            sql = "DELETE FROM TBL_ORDER";
            dt = db.GetDBTable(sql);

            this.tBL_ORDERTableAdapter.Fill(this.shoppingDBDataSet1.TBL_ORDER);
            orderPrice = 0;
            totalPrice = 0;
            OrderPriceLabel.Text = "";
            db.CloseDB();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.User_code = user_code;
            f3.passvalue = user_name;
            f3.Visible = true;
        }



        // 뒤로가서 더 추가하기
          // 유저코드 이름 저장해서 다시 장바구니로 오는것 까지 완료
          // 원래 있던 가격에 더해져서 보여줘야 하는데 이부분 수정해야함
    }
}
