namespace ShoppingApp2
{
    partial class Form2
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
            this.SignInBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.E_mailBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailCheckBtn = new System.Windows.Forms.Button();
            this.PhoneCheckBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(100, 385);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 22;
            this.SignInBtn.Text = "Sign Up";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(28, 145);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(215, 21);
            this.NameBox.TabIndex = 21;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(28, 199);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(215, 21);
            this.PasswordBox.TabIndex = 20;
            // 
            // PhoneBox
            // 
            this.PhoneBox.ForeColor = System.Drawing.Color.Silver;
            this.PhoneBox.Location = new System.Drawing.Point(28, 250);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(215, 21);
            this.PhoneBox.TabIndex = 19;
            this.PhoneBox.Text = "\"-\" 빼고 입력해주세요";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(28, 346);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(215, 21);
            this.AddressBox.TabIndex = 18;
            // 
            // E_mailBox
            // 
            this.E_mailBox.Location = new System.Drawing.Point(28, 59);
            this.E_mailBox.Name = "E_mailBox";
            this.E_mailBox.Size = new System.Drawing.Size(215, 21);
            this.E_mailBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "E-Mail";
            // 
            // EmailCheckBtn
            // 
            this.EmailCheckBtn.Location = new System.Drawing.Point(28, 87);
            this.EmailCheckBtn.Name = "EmailCheckBtn";
            this.EmailCheckBtn.Size = new System.Drawing.Size(75, 23);
            this.EmailCheckBtn.TabIndex = 23;
            this.EmailCheckBtn.Text = "Check";
            this.EmailCheckBtn.UseVisualStyleBackColor = true;
            this.EmailCheckBtn.Click += new System.EventHandler(this.EmailCheckBtn_Click);
            // 
            // PhoneCheckBtn
            // 
            this.PhoneCheckBtn.Location = new System.Drawing.Point(28, 277);
            this.PhoneCheckBtn.Name = "PhoneCheckBtn";
            this.PhoneCheckBtn.Size = new System.Drawing.Size(75, 23);
            this.PhoneCheckBtn.TabIndex = 24;
            this.PhoneCheckBtn.Text = "Check";
            this.PhoneCheckBtn.UseVisualStyleBackColor = true;
            this.PhoneCheckBtn.Click += new System.EventHandler(this.PhoneCheckBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "회원가입";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 433);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneCheckBtn);
            this.Controls.Add(this.EmailCheckBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.E_mailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox E_mailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmailCheckBtn;
        private System.Windows.Forms.Button PhoneCheckBtn;
        private System.Windows.Forms.Label label6;
    }
}