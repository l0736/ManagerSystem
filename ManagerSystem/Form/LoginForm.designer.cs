namespace ManagerSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_textBox_Account = new System.Windows.Forms.TextBox();
            this.Login_textBox_Password = new System.Windows.Forms.TextBox();
            this.Login_button_Login = new System.Windows.Forms.Button();
            this.Login_button_Exit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(81, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "登錄系統";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "帳號 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "密碼 :";
            // 
            // Login_textBox_Account
            // 
            this.Login_textBox_Account.Location = new System.Drawing.Point(87, 100);
            this.Login_textBox_Account.Name = "Login_textBox_Account";
            this.Login_textBox_Account.Size = new System.Drawing.Size(162, 22);
            this.Login_textBox_Account.TabIndex = 16;
            // 
            // Login_textBox_Password
            // 
            this.Login_textBox_Password.Location = new System.Drawing.Point(87, 147);
            this.Login_textBox_Password.Name = "Login_textBox_Password";
            this.Login_textBox_Password.PasswordChar = '*';
            this.Login_textBox_Password.Size = new System.Drawing.Size(162, 22);
            this.Login_textBox_Password.TabIndex = 17;
            // 
            // Login_button_Login
            // 
            this.Login_button_Login.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Login_button_Login.Location = new System.Drawing.Point(55, 207);
            this.Login_button_Login.Name = "Login_button_Login";
            this.Login_button_Login.Size = new System.Drawing.Size(75, 31);
            this.Login_button_Login.TabIndex = 18;
            this.Login_button_Login.Text = "登 錄";
            this.Login_button_Login.UseVisualStyleBackColor = true;
            this.Login_button_Login.Click += new System.EventHandler(this.login_system_btn_login_Click);
            // 
            // Login_button_Exit
            // 
            this.Login_button_Exit.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Login_button_Exit.Location = new System.Drawing.Point(173, 207);
            this.Login_button_Exit.Name = "Login_button_Exit";
            this.Login_button_Exit.Size = new System.Drawing.Size(75, 31);
            this.Login_button_Exit.TabIndex = 19;
            this.Login_button_Exit.Text = "退 出";
            this.Login_button_Exit.UseVisualStyleBackColor = true;
            this.Login_button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(159, 177);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 12);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "還沒辦帳號嗎？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Login_button_Exit);
            this.Controls.Add(this.Login_button_Login);
            this.Controls.Add(this.Login_textBox_Password);
            this.Controls.Add(this.Login_textBox_Account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_system";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox Login_textBox_Account;
        private System.Windows.Forms.TextBox Login_textBox_Password;
        private System.Windows.Forms.Button Login_button_Login;
        private System.Windows.Forms.Button Login_button_Exit;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}