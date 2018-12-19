namespace ShoppingApp2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ORDER_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDBDataSet1 = new ShoppingApp2.ShoppingDBDataSet1();
            this.tBL_ORDERTableAdapter = new ShoppingApp2.ShoppingDBDataSet1TableAdapters.TBL_ORDERTableAdapter();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OrderPriceLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.ORDER_CODE,
            this.pRODUCTNAMEDataGridViewTextBoxColumn,
            this.PRODUCT_PRICE,
            this.uSERCODEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLORDERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(345, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CheckBox
            // 
            this.CheckBox.DataPropertyName = "checkbox";
            this.CheckBox.FalseValue = "N";
            this.CheckBox.HeaderText = "선택";
            this.CheckBox.IndeterminateValue = "N";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.TrueValue = "Y";
            this.CheckBox.Width = 40;
            // 
            // ORDER_CODE
            // 
            this.ORDER_CODE.DataPropertyName = "ORDER_CODE";
            this.ORDER_CODE.HeaderText = "번호";
            this.ORDER_CODE.Name = "ORDER_CODE";
            this.ORDER_CODE.ReadOnly = true;
            // 
            // pRODUCTNAMEDataGridViewTextBoxColumn
            // 
            this.pRODUCTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCT_NAME";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.HeaderText = "제품이름";
            this.pRODUCTNAMEDataGridViewTextBoxColumn.Name = "pRODUCTNAMEDataGridViewTextBoxColumn";
            // 
            // PRODUCT_PRICE
            // 
            this.PRODUCT_PRICE.DataPropertyName = "PRODUCT_PRICE";
            this.PRODUCT_PRICE.HeaderText = "제품가격";
            this.PRODUCT_PRICE.Name = "PRODUCT_PRICE";
            // 
            // uSERCODEDataGridViewTextBoxColumn
            // 
            this.uSERCODEDataGridViewTextBoxColumn.DataPropertyName = "USER_CODE";
            this.uSERCODEDataGridViewTextBoxColumn.HeaderText = "USER_CODE";
            this.uSERCODEDataGridViewTextBoxColumn.Name = "uSERCODEDataGridViewTextBoxColumn";
            this.uSERCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // tBLORDERBindingSource
            // 
            this.tBLORDERBindingSource.DataMember = "TBL_ORDER";
            this.tBLORDERBindingSource.DataSource = this.shoppingDBDataSet1;
            // 
            // shoppingDBDataSet1
            // 
            this.shoppingDBDataSet1.DataSetName = "ShoppingDBDataSet1";
            this.shoppingDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBL_ORDERTableAdapter
            // 
            this.tBL_ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(29, 213);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "선택삭제";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OrderPriceLabel
            // 
            this.OrderPriceLabel.AutoSize = true;
            this.OrderPriceLabel.Location = new System.Drawing.Point(296, 213);
            this.OrderPriceLabel.Name = "OrderPriceLabel";
            this.OrderPriceLabel.Size = new System.Drawing.Size(38, 12);
            this.OrderPriceLabel.TabIndex = 2;
            this.OrderPriceLabel.Text = "label1";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(298, 237);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "결제하기";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "장바구니";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(344, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(28, 29);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "<-";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 276);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.OrderPriceLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShoppingDBDataSet1 shoppingDBDataSet1;
        private System.Windows.Forms.BindingSource tBLORDERBindingSource;
        private ShoppingDBDataSet1TableAdapters.TBL_ORDERTableAdapter tBL_ORDERTableAdapter;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label OrderPriceLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
    }
}