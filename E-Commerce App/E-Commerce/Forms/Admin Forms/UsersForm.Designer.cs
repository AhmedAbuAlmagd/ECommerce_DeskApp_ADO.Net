namespace E_Commerce.Forms
{
    partial class UsersForm
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
            dgv_Users_UF = new DataGridView();
            txt_address_UF = new TextBox();
            txt_email_UF = new TextBox();
            txt_userName_UF = new TextBox();
            label5 = new Label();
            num_age_UF = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            txt_password_UF = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_add_UF = new Button();
            btn_update_UF = new Button();
            btn_delete_UF = new Button();
            label_Role = new Label();
            combo_Role_UF = new ComboBox();
            check_viewPass_UF = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Users_UF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_age_UF).BeginInit();
            SuspendLayout();
            // 
            // dgv_Users_UF
            // 
            dgv_Users_UF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Users_UF.Location = new Point(1, 187);
            dgv_Users_UF.Name = "dgv_Users_UF";
            dgv_Users_UF.RowHeadersWidth = 51;
            dgv_Users_UF.Size = new Size(536, 264);
            dgv_Users_UF.TabIndex = 0;
            dgv_Users_UF.RowHeaderMouseDoubleClick += dgv_Users_UF_RowHeaderMouseDoubleClick;
            // 
            // txt_address_UF
            // 
            txt_address_UF.ForeColor = SystemColors.ActiveCaptionText;
            txt_address_UF.Location = new Point(541, 71);
            txt_address_UF.Name = "txt_address_UF";
            txt_address_UF.Size = new Size(175, 27);
            txt_address_UF.TabIndex = 30;
            // 
            // txt_email_UF
            // 
            txt_email_UF.ForeColor = SystemColors.ActiveCaptionText;
            txt_email_UF.Location = new Point(154, 136);
            txt_email_UF.Name = "txt_email_UF";
            txt_email_UF.Size = new Size(175, 27);
            txt_email_UF.TabIndex = 28;
            // 
            // txt_userName_UF
            // 
            txt_userName_UF.ForeColor = SystemColors.ActiveCaptionText;
            txt_userName_UF.Location = new Point(154, 28);
            txt_userName_UF.Name = "txt_userName_UF";
            txt_userName_UF.Size = new Size(175, 27);
            txt_userName_UF.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(434, 71);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 27;
            label5.Text = "Address";
            // 
            // num_age_UF
            // 
            num_age_UF.ForeColor = SystemColors.ActiveCaptionText;
            num_age_UF.Location = new Point(541, 28);
            num_age_UF.Name = "num_age_UF";
            num_age_UF.Size = new Size(175, 27);
            num_age_UF.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(468, 28);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 25;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(76, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 24;
            label3.Text = "Email";
            // 
            // txt_password_UF
            // 
            txt_password_UF.ForeColor = SystemColors.ActiveCaptionText;
            txt_password_UF.Location = new Point(154, 71);
            txt_password_UF.Name = "txt_password_UF";
            txt_password_UF.Size = new Size(175, 27);
            txt_password_UF.TabIndex = 23;
            txt_password_UF.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(42, 72);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 22;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 21;
            label1.Text = "User Name";
            // 
            // btn_add_UF
            // 
            btn_add_UF.BackColor = Color.FromArgb(54, 132, 107);
            btn_add_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_add_UF.ForeColor = SystemColors.ButtonHighlight;
            btn_add_UF.Location = new Point(561, 207);
            btn_add_UF.Name = "btn_add_UF";
            btn_add_UF.Size = new Size(204, 55);
            btn_add_UF.TabIndex = 31;
            btn_add_UF.Text = "Add";
            btn_add_UF.UseVisualStyleBackColor = false;
            btn_add_UF.Click += btn_add_UF_Click;
            // 
            // btn_update_UF
            // 
            btn_update_UF.BackColor = Color.FromArgb(48, 90, 112);
            btn_update_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_update_UF.ForeColor = SystemColors.ButtonHighlight;
            btn_update_UF.Location = new Point(561, 289);
            btn_update_UF.Name = "btn_update_UF";
            btn_update_UF.Size = new Size(204, 55);
            btn_update_UF.TabIndex = 32;
            btn_update_UF.Text = "Update";
            btn_update_UF.UseVisualStyleBackColor = false;
            btn_update_UF.Click += btn_update_UF_Click;
            // 
            // btn_delete_UF
            // 
            btn_delete_UF.BackColor = Color.Maroon;
            btn_delete_UF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_delete_UF.ForeColor = SystemColors.ButtonHighlight;
            btn_delete_UF.Location = new Point(561, 369);
            btn_delete_UF.Name = "btn_delete_UF";
            btn_delete_UF.Size = new Size(204, 55);
            btn_delete_UF.TabIndex = 33;
            btn_delete_UF.Text = "Delete";
            btn_delete_UF.UseVisualStyleBackColor = false;
            btn_delete_UF.Click += btn_delete_UF_Click;
            // 
            // label_Role
            // 
            label_Role.AutoSize = true;
            label_Role.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label_Role.ForeColor = SystemColors.ButtonHighlight;
            label_Role.Location = new Point(464, 133);
            label_Role.Name = "label_Role";
            label_Role.Size = new Size(50, 25);
            label_Role.TabIndex = 27;
            label_Role.Text = "Role";
            // 
            // combo_Role_UF
            // 
            combo_Role_UF.ForeColor = SystemColors.ActiveCaptionText;
            combo_Role_UF.FormattingEnabled = true;
            combo_Role_UF.Location = new Point(541, 133);
            combo_Role_UF.Name = "combo_Role_UF";
            combo_Role_UF.Size = new Size(175, 28);
            combo_Role_UF.TabIndex = 34;
            // 
            // check_viewPass_UF
            // 
            check_viewPass_UF.AutoSize = true;
            check_viewPass_UF.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_viewPass_UF.ForeColor = SystemColors.ButtonHighlight;
            check_viewPass_UF.Location = new Point(154, 106);
            check_viewPass_UF.Name = "check_viewPass_UF";
            check_viewPass_UF.Size = new Size(121, 21);
            check_viewPass_UF.TabIndex = 35;
            check_viewPass_UF.Text = "Show Password";
            check_viewPass_UF.UseVisualStyleBackColor = true;
            check_viewPass_UF.CheckedChanged += check_viewPass_UF_CheckedChanged;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 170, 154);
            ClientSize = new Size(800, 450);
            Controls.Add(check_viewPass_UF);
            Controls.Add(combo_Role_UF);
            Controls.Add(btn_delete_UF);
            Controls.Add(btn_update_UF);
            Controls.Add(btn_add_UF);
            Controls.Add(txt_address_UF);
            Controls.Add(txt_email_UF);
            Controls.Add(txt_userName_UF);
            Controls.Add(label_Role);
            Controls.Add(label5);
            Controls.Add(num_age_UF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_password_UF);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Users_UF);
            Name = "UsersForm";
            Text = "Users_Form";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Users_UF).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_age_UF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Users_UF;
        private TextBox txt_address_UF;
        private TextBox txt_email_UF;
        private TextBox txt_userName_UF;
        private Label label5;
        private NumericUpDown num_age_UF;
        private Label label4;
        private Label label3;
        private TextBox txt_password_UF;
        private Label label2;
        private Label label1;
        private Button btn_add_UF;
        private Button btn_update_UF;
        private Button btn_delete_UF;
        private Label label_Role;
        private ComboBox combo_Role_UF;
        private CheckBox check_viewPass_UF;
    }
}