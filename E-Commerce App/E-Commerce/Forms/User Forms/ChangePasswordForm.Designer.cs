namespace E_Commerce.Forms
{
    partial class ChangePasswordForm
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
            label2 = new Label();
            label_newPass = new Label();
            label_oldPass = new Label();
            txt_confirmPass = new TextBox();
            txt_newPass = new TextBox();
            txt_oldPass = new TextBox();
            btn_back_PassF = new Button();
            btn_changePass = new Button();
            check_viewPass_UF = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(211, 233);
            label2.Name = "label2";
            label2.Size = new Size(186, 28);
            label2.TabIndex = 10;
            label2.Text = "Confirm Password";
            // 
            // label_newPass
            // 
            label_newPass.AutoSize = true;
            label_newPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_newPass.ForeColor = Color.White;
            label_newPass.Location = new Point(241, 149);
            label_newPass.Name = "label_newPass";
            label_newPass.Size = new Size(151, 28);
            label_newPass.TabIndex = 11;
            label_newPass.Text = "New Password";
            // 
            // label_oldPass
            // 
            label_oldPass.AutoSize = true;
            label_oldPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_oldPass.ForeColor = Color.White;
            label_oldPass.Location = new Point(248, 71);
            label_oldPass.Name = "label_oldPass";
            label_oldPass.Size = new Size(142, 28);
            label_oldPass.TabIndex = 12;
            label_oldPass.Text = "Old Password";
            // 
            // txt_confirmPass
            // 
            txt_confirmPass.Location = new Point(421, 235);
            txt_confirmPass.Name = "txt_confirmPass";
            txt_confirmPass.Size = new Size(174, 27);
            txt_confirmPass.TabIndex = 7;
            txt_confirmPass.UseSystemPasswordChar = true;
            // 
            // txt_newPass
            // 
            txt_newPass.Location = new Point(421, 151);
            txt_newPass.Name = "txt_newPass";
            txt_newPass.Size = new Size(174, 27);
            txt_newPass.TabIndex = 8;
            txt_newPass.UseSystemPasswordChar = true;
            // 
            // txt_oldPass
            // 
            txt_oldPass.Location = new Point(421, 72);
            txt_oldPass.Name = "txt_oldPass";
            txt_oldPass.Size = new Size(174, 27);
            txt_oldPass.TabIndex = 9;
            txt_oldPass.UseSystemPasswordChar = true;
            // 
            // btn_back_PassF
            // 
            btn_back_PassF.BackColor = Color.Maroon;
            btn_back_PassF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_back_PassF.ForeColor = SystemColors.ButtonHighlight;
            btn_back_PassF.Location = new Point(697, 393);
            btn_back_PassF.Name = "btn_back_PassF";
            btn_back_PassF.Size = new Size(91, 45);
            btn_back_PassF.TabIndex = 5;
            btn_back_PassF.Text = "Back";
            btn_back_PassF.UseVisualStyleBackColor = false;
            btn_back_PassF.Click += btn_back_PassF_Click;
            // 
            // btn_changePass
            // 
            btn_changePass.BackColor = Color.FromArgb(225, 223, 186);
            btn_changePass.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btn_changePass.Location = new Point(260, 316);
            btn_changePass.Name = "btn_changePass";
            btn_changePass.Size = new Size(335, 44);
            btn_changePass.TabIndex = 6;
            btn_changePass.Text = "Change Password ";
            btn_changePass.UseVisualStyleBackColor = false;
            btn_changePass.Click += btn_changePass_Click;
            // 
            // check_viewPass_UF
            // 
            check_viewPass_UF.AutoSize = true;
            check_viewPass_UF.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_viewPass_UF.Location = new Point(421, 105);
            check_viewPass_UF.Name = "check_viewPass_UF";
            check_viewPass_UF.Size = new Size(121, 21);
            check_viewPass_UF.TabIndex = 38;
            check_viewPass_UF.Text = "Show Password";
            check_viewPass_UF.UseVisualStyleBackColor = true;
            check_viewPass_UF.CheckedChanged += check_viewPass_UF_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(421, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 21);
            checkBox1.TabIndex = 38;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(421, 268);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 21);
            checkBox2.TabIndex = 38;
            checkBox2.Text = "Show Password";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 170, 154);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(check_viewPass_UF);
            Controls.Add(label2);
            Controls.Add(label_newPass);
            Controls.Add(label_oldPass);
            Controls.Add(txt_confirmPass);
            Controls.Add(txt_newPass);
            Controls.Add(txt_oldPass);
            Controls.Add(btn_back_PassF);
            Controls.Add(btn_changePass);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label_newPass;
        private Label label_oldPass;
        private TextBox txt_confirmPass;
        private TextBox txt_newPass;
        private TextBox txt_oldPass;
        private Button btn_back_PassF;
        private Button btn_changePass;
        private CheckBox check_viewPass_UF;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}