namespace E_Commerce
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            btn_register_RF = new Button();
            txt_password_RF = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            num_age_RF = new NumericUpDown();
            label5 = new Label();
            txt_userName_RF = new TextBox();
            txt_email_RF = new TextBox();
            txt_address_RF = new TextBox();
            label6 = new Label();
            label_Login_RF = new LinkLabel();
            check_viewPass_UF = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)num_age_RF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_register_RF
            // 
            btn_register_RF.BackColor = Color.FromArgb(75, 170, 154);
            btn_register_RF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_register_RF.ForeColor = Color.White;
            btn_register_RF.Location = new Point(460, 321);
            btn_register_RF.Margin = new Padding(3, 2, 3, 2);
            btn_register_RF.Name = "btn_register_RF";
            btn_register_RF.Size = new Size(298, 44);
            btn_register_RF.TabIndex = 12;
            btn_register_RF.Text = "Register";
            btn_register_RF.UseVisualStyleBackColor = false;
            btn_register_RF.Click += btn_register_RF_Click;
            // 
            // txt_password_RF
            // 
            txt_password_RF.Location = new Point(583, 98);
            txt_password_RF.Margin = new Padding(3, 2, 3, 2);
            txt_password_RF.Name = "txt_password_RF";
            txt_password_RF.Size = new Size(175, 27);
            txt_password_RF.TabIndex = 11;
            txt_password_RF.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(460, 102);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(448, 54);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 8;
            label1.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(484, 165);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(494, 219);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 15;
            label4.Text = "Age";
            // 
            // num_age_RF
            // 
            num_age_RF.Location = new Point(583, 216);
            num_age_RF.Margin = new Padding(3, 2, 3, 2);
            num_age_RF.Name = "num_age_RF";
            num_age_RF.Size = new Size(175, 27);
            num_age_RF.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(468, 270);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 17;
            label5.Text = "Address";
            // 
            // txt_userName_RF
            // 
            txt_userName_RF.Location = new Point(583, 50);
            txt_userName_RF.Margin = new Padding(3, 2, 3, 2);
            txt_userName_RF.Name = "txt_userName_RF";
            txt_userName_RF.Size = new Size(175, 27);
            txt_userName_RF.TabIndex = 19;
            // 
            // txt_email_RF
            // 
            txt_email_RF.Location = new Point(583, 164);
            txt_email_RF.Margin = new Padding(3, 2, 3, 2);
            txt_email_RF.Name = "txt_email_RF";
            txt_email_RF.Size = new Size(175, 27);
            txt_email_RF.TabIndex = 19;
            // 
            // txt_address_RF
            // 
            txt_address_RF.Location = new Point(583, 269);
            txt_address_RF.Margin = new Padding(3, 2, 3, 2);
            txt_address_RF.Name = "txt_address_RF";
            txt_address_RF.Size = new Size(175, 27);
            txt_address_RF.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(470, 375);
            label6.Name = "label6";
            label6.Size = new Size(182, 20);
            label6.TabIndex = 21;
            label6.Text = "Already have an account : ";
            // 
            // label_Login_RF
            // 
            label_Login_RF.AutoSize = true;
            label_Login_RF.Location = new Point(647, 375);
            label_Login_RF.Name = "label_Login_RF";
            label_Login_RF.Size = new Size(46, 20);
            label_Login_RF.TabIndex = 22;
            label_Login_RF.TabStop = true;
            label_Login_RF.Text = "Login";
            label_Login_RF.LinkClicked += label_Login_RF_LinkClicked;
            // 
            // check_viewPass_UF
            // 
            check_viewPass_UF.AutoSize = true;
            check_viewPass_UF.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_viewPass_UF.Location = new Point(583, 131);
            check_viewPass_UF.Margin = new Padding(3, 2, 3, 2);
            check_viewPass_UF.Name = "check_viewPass_UF";
            check_viewPass_UF.Size = new Size(121, 21);
            check_viewPass_UF.TabIndex = 36;
            check_viewPass_UF.Text = "Show Password";
            check_viewPass_UF.UseVisualStyleBackColor = true;
            check_viewPass_UF.CheckedChanged += check_viewPass_UF_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-19, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 223, 186);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(check_viewPass_UF);
            Controls.Add(label_Login_RF);
            Controls.Add(label6);
            Controls.Add(txt_address_RF);
            Controls.Add(txt_email_RF);
            Controls.Add(txt_userName_RF);
            Controls.Add(label5);
            Controls.Add(num_age_RF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_register_RF);
            Controls.Add(txt_password_RF);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)num_age_RF).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_register_RF;
        private TextBox txt_password_RF;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private NumericUpDown num_age_RF;
        private Label label5;
        private TextBox txt_userName_RF;
        private TextBox txt_email_RF;
        private TextBox txt_address_RF;
        private Label label6;
        private LinkLabel label_Login_RF;
        private CheckBox check_viewPass_UF;
        private PictureBox pictureBox1;
    }
}