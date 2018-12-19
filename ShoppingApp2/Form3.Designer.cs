namespace ShoppingApp2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PRODUCT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCT_QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLPRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingDBDataSet = new ShoppingApp2.ShoppingDBDataSet();
            this.NameLabel = new System.Windows.Forms.Label();
            this.basketBtn = new System.Windows.Forms.Button();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.tBL_PRODUCTTableAdapter = new ShoppingApp2.ShoppingDBDataSetTableAdapters.TBL_PRODUCTTableAdapter();
            this.User_CodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "검색 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "분류 : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 21);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.PRODUCT_CODE,
            this.PRODUCT_NAME,
            this.PRODUCT_PRICE,
            this.PRODUCT_CATEGORY,
            this.PRODUCT_QUANTITY});
            this.dataGridView1.DataSource = this.tBLPRODUCTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 288);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CheckBox
            // 
            this.CheckBox.DataPropertyName = "checkbox";
            this.CheckBox.FalseValue = "N";
            this.CheckBox.Frozen = true;
            this.CheckBox.HeaderText = "선택";
            this.CheckBox.IndeterminateValue = "N";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.TrueValue = "Y";
            this.CheckBox.Width = 40;
            // 
            // PRODUCT_CODE
            // 
            this.PRODUCT_CODE.DataPropertyName = "PRODUCT_CODE";
            this.PRODUCT_CODE.HeaderText = "제품번호";
            this.PRODUCT_CODE.Name = "PRODUCT_CODE";
            this.PRODUCT_CODE.ReadOnly = true;
            // 
            // PRODUCT_NAME
            // 
            this.PRODUCT_NAME.DataPropertyName = "PRODUCT_NAME";
            this.PRODUCT_NAME.HeaderText = "제품이름";
            this.PRODUCT_NAME.Name = "PRODUCT_NAME";
            // 
            // PRODUCT_PRICE
            // 
            this.PRODUCT_PRICE.DataPropertyName = "PRODUCT_PRICE";
            this.PRODUCT_PRICE.HeaderText = "제품가격";
            this.PRODUCT_PRICE.Name = "PRODUCT_PRICE";
            // 
            // PRODUCT_CATEGORY
            // 
            this.PRODUCT_CATEGORY.DataPropertyName = "PRODUCT_CATEGORY";
            this.PRODUCT_CATEGORY.HeaderText = "분류";
            this.PRODUCT_CATEGORY.Name = "PRODUCT_CATEGORY";
            // 
            // PRODUCT_QUANTITY
            // 
            this.PRODUCT_QUANTITY.DataPropertyName = "PRODUCT_QUANTITY";
            this.PRODUCT_QUANTITY.HeaderText = "수량";
            this.PRODUCT_QUANTITY.Name = "PRODUCT_QUANTITY";
            // 
            // tBLPRODUCTBindingSource
            // 
            this.tBLPRODUCTBindingSource.DataMember = "TBL_PRODUCT";
            this.tBLPRODUCTBindingSource.DataSource = this.shoppingDBDataSet;
            // 
            // shoppingDBDataSet
            // 
            this.shoppingDBDataSet.DataSetName = "ShoppingDBDataSet";
            this.shoppingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(464, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "이름";
            // 
            // basketBtn
            // 
            this.basketBtn.Location = new System.Drawing.Point(478, 428);
            this.basketBtn.Name = "basketBtn";
            this.basketBtn.Size = new System.Drawing.Size(94, 41);
            this.basketBtn.TabIndex = 8;
            this.basketBtn.Text = "장바구니";
            this.basketBtn.UseVisualStyleBackColor = true;
            this.basketBtn.Click += new System.EventHandler(this.basketBtn_Click);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(464, 91);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(29, 12);
            this.TotalPriceLabel.TabIndex = 9;
            this.TotalPriceLabel.Text = "가격";
            // 
            // tBL_PRODUCTTableAdapter
            // 
            this.tBL_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // User_CodeLabel
            // 
            this.User_CodeLabel.AutoSize = true;
            this.User_CodeLabel.Location = new System.Drawing.Point(281, 11);
            this.User_CodeLabel.Name = "User_CodeLabel";
            this.User_CodeLabel.Size = new System.Drawing.Size(53, 12);
            this.User_CodeLabel.TabIndex = 11;
            this.User_CodeLabel.Text = "유저코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "상품목록";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User_CodeLabel);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.basketBtn);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ShoppingDBDataSet shoppingDBDataSet;
        private System.Windows.Forms.BindingSource tBLPRODUCTBindingSource;
        private ShoppingDBDataSetTableAdapters.TBL_PRODUCTTableAdapter tBL_PRODUCTTableAdapter;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button basketBtn;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCT_QUANTITY;
        private System.Windows.Forms.Label User_CodeLabel;
        private System.Windows.Forms.Label label3;
    }
}