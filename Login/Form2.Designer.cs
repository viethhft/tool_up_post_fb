namespace Login
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
            label1 = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 63);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "Email/SĐT:";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(182, 60);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(522, 39);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += txt_user_TextChanged;
            txt_user.KeyDown += txt_user_KeyDown;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(182, 187);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(522, 39);
            txt_pass.TabIndex = 3;
            txt_pass.TextChanged += txt_pass_TextChanged;
            txt_pass.KeyDown += txt_pass_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 190);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(541, 283);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(150, 46);
            btn_login.TabIndex = 4;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 357);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(label2);
            Controls.Add(txt_user);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Label label2;
        private Button btn_login;
    }
}