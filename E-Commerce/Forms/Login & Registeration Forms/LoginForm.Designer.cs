
namespace E_Commerce
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txt_password_LF = new TextBox();
            btn_login_LF = new Button();
            txt_userName_LF = new TextBox();
            btn_backFromLogin = new Button();
            check_viewPass_UF = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 85);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 174);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txt_password_LF
            // 
            txt_password_LF.Location = new Point(167, 179);
            txt_password_LF.Name = "txt_password_LF";
            txt_password_LF.Size = new Size(175, 27);
            txt_password_LF.TabIndex = 6;
            txt_password_LF.UseSystemPasswordChar = true;
            // 
            // btn_login_LF
            // 
            btn_login_LF.BackColor = Color.FromArgb(75, 170, 154);
            btn_login_LF.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_login_LF.ForeColor = Color.White;
            btn_login_LF.Location = new Point(167, 255);
            btn_login_LF.Name = "btn_login_LF";
            btn_login_LF.Size = new Size(155, 48);
            btn_login_LF.TabIndex = 7;
            btn_login_LF.Text = "Login";
            btn_login_LF.UseVisualStyleBackColor = false;
            btn_login_LF.Click += btn_login_LF_Click;
            // 
            // txt_userName_LF
            // 
            txt_userName_LF.Location = new Point(167, 89);
            txt_userName_LF.Name = "txt_userName_LF";
            txt_userName_LF.Size = new Size(175, 27);
            txt_userName_LF.TabIndex = 8;
            // 
            // btn_backFromLogin
            // 
            btn_backFromLogin.BackColor = Color.Maroon;
            btn_backFromLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_backFromLogin.ForeColor = Color.White;
            btn_backFromLogin.Location = new Point(12, 395);
            btn_backFromLogin.Name = "btn_backFromLogin";
            btn_backFromLogin.Size = new Size(112, 43);
            btn_backFromLogin.TabIndex = 9;
            btn_backFromLogin.Text = "Back";
            btn_backFromLogin.UseVisualStyleBackColor = false;
            btn_backFromLogin.Click += btn_backFromLogin_Click;
            // 
            // check_viewPass_UF
            // 
            check_viewPass_UF.AutoSize = true;
            check_viewPass_UF.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_viewPass_UF.Location = new Point(187, 212);
            check_viewPass_UF.Name = "check_viewPass_UF";
            check_viewPass_UF.Size = new Size(121, 21);
            check_viewPass_UF.TabIndex = 37;
            check_viewPass_UF.Text = "Show Password";
            check_viewPass_UF.UseVisualStyleBackColor = true;
            check_viewPass_UF.CheckedChanged += check_viewPass_UF_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Moccasin;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(394, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 223, 186);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(check_viewPass_UF);
            Controls.Add(btn_backFromLogin);
            Controls.Add(txt_userName_LF);
            Controls.Add(btn_login_LF);
            Controls.Add(txt_password_LF);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_password_LF;
        private Button btn_login_LF;
        private TextBox txt_userName_LF;
        private Button btn_backFromLogin;
        private CheckBox check_viewPass_UF;
        private PictureBox pictureBox1;
    }
}