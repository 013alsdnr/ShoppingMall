using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp2
{
    public class Product
    {
        private string product_name = "";
        private int product_price = 0;
        private int product_code = 0;
        private int user_code = 0;
        private int order_code = 0;

        public int Order_code
        {
            get
            {
                return this.order_code;
            }

            set
            {
                this.order_code = value;
            }
        }

        public int User_code
        {
            get
            {
                return this.user_code;
            }

            set
            {
                this.user_code = value;
            }
        }


        public string Product_name
        {
            get
            {
                return this.product_name;
            }

            set
            {
                this.product_name = value;
            }
        }
        public int Product_price
        {
            get
            {
                return this.product_price;
            }

            set
            {
                this.product_price = value;
            }
        }

        public int Product_code
        {
            get
            {
                return this.product_code;
            }

            set
            {
                this.product_code = value;
            }
        }
    }
}
