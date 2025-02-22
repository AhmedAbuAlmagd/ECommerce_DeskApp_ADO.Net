namespace E_Commerce
{
    partial class UserForm
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
            dgv_products_UF = new DataGridView();
            btn_addFavourite_UF = new Button();
            btn_viewFavourite_UF = new Button();
            btn_LogOut = new Button();
            label3 = new Label();
            txt_categoryName_UF = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_price_UF = new TextBox();
            txt_productName_UF = new TextBox();
            btn_changePass = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_products_UF).BeginInit();
            SuspendLayout();
            // 
            // dgv_products_UF
            // 
            dgv_products_UF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products_UF.Location = new Point(12, 23);
            dgv_products_UF.Name = "dgv_products_UF";
            dgv_products_UF.RowHeadersWidth = 51;
            dgv_products_UF.Size = new Size(419, 403);
            dgv_products_UF.TabIndex = 0;
            dgv_products_UF.RowHeaderMouseDoubleClick += dgv_products_UF_RowHeaderMouseDoubleClick;
            // 
            // btn_addFavourite_UF
            // 
            btn_addFavourite_UF.BackColor = Color.FromArgb(75, 170, 154);
            btn_addFavourite_UF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btn_addFavourite_UF.ForeColor = Color.White;
            btn_addFavourite_UF.Location = new Point(463, 273);
            btn_addFavourite_UF.Name = "btn_addFavourite_UF";
            btn_addFavourite_UF.Size = new Size(152, 53);
            btn_addFavourite_UF.TabIndex = 1;
            btn_addFavourite_UF.Text = "Add to Favorites";
            btn_addFavourite_UF.UseVisualStyleBackColor = false;
            btn_addFavourite_UF.Click += btn_addFavourite_UF_Click;
            // 
            // btn_viewFavourite_UF
            // 
            btn_viewFavourite_UF.BackColor = Color.FromArgb(75, 170, 154);
            btn_viewFavourite_UF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btn_viewFavourite_UF.ForeColor = Color.White;
            btn_viewFavourite_UF.Location = new Point(636, 273);
            btn_viewFavourite_UF.Name = "btn_viewFavourite_UF";
            btn_viewFavourite_UF.Size = new Size(152, 53);
            btn_viewFavourite_UF.TabIndex = 2;
            btn_viewFavourite_UF.Text = "View Favorites";
            btn_viewFavourite_UF.UseVisualStyleBackColor = false;
            btn_viewFavourite_UF.Click += btn_viewFavourite_UF_Click;
            // 
            // btn_LogOut
            // 
            btn_LogOut.BackColor = Color.Maroon;
            btn_LogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_LogOut.ForeColor = Color.White;
            btn_LogOut.Location = new Point(636, 373);
            btn_LogOut.Name = "btn_LogOut";
            btn_LogOut.Size = new Size(152, 53);
            btn_LogOut.TabIndex = 3;
            btn_LogOut.Text = "Log Out";
            btn_LogOut.UseVisualStyleBackColor = false;
            btn_LogOut.Click += btn_LogOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(531, 176);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 23;
            label3.Text = "Price";
            // 
            // txt_categoryName_UF
            // 
            txt_categoryName_UF.Location = new Point(602, 129);
            txt_categoryName_UF.Name = "txt_categoryName_UF";
            txt_categoryName_UF.ReadOnly = true;
            txt_categoryName_UF.Size = new Size(175, 27);
            txt_categoryName_UF.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(442, 132);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 20;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(452, 84);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 19;
            label1.Text = "Product Name";
            label1.Click += label1_Click;
            // 
            // txt_price_UF
            // 
            txt_price_UF.AllowDrop = true;
            txt_price_UF.Location = new Point(602, 175);
            txt_price_UF.Name = "txt_price_UF";
            txt_price_UF.ReadOnly = true;
            txt_price_UF.Size = new Size(175, 27);
            txt_price_UF.TabIndex = 25;
            // 
            // txt_productName_UF
            // 
            txt_productName_UF.Location = new Point(602, 81);
            txt_productName_UF.Name = "txt_productName_UF";
            txt_productName_UF.ReadOnly = true;
            txt_productName_UF.Size = new Size(175, 27);
            txt_productName_UF.TabIndex = 26;
            // 
            // btn_changePass
            // 
            btn_changePass.BackColor = Color.FromArgb(48, 90, 112);
            btn_changePass.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_changePass.ForeColor = Color.White;
            btn_changePass.Location = new Point(463, 373);
            btn_changePass.Name = "btn_changePass";
            btn_changePass.Size = new Size(152, 53);
            btn_changePass.TabIndex = 27;
            btn_changePass.Text = "Change my password";
            btn_changePass.UseVisualStyleBackColor = false;
            btn_changePass.Click += btn_changePass_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(225, 223, 186);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 451);
            Controls.Add(btn_changePass);
            Controls.Add(txt_productName_UF);
            Controls.Add(txt_price_UF);
            Controls.Add(label3);
            Controls.Add(txt_categoryName_UF);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_LogOut);
            Controls.Add(btn_viewFavourite_UF);
            Controls.Add(btn_addFavourite_UF);
            Controls.Add(dgv_products_UF);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products_UF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_products_UF;
        private Button btn_addFavourite_UF;
        private Button btn_viewFavourite_UF;
        private Button btn_LogOut;
        private Label label3;
        private TextBox txt_categoryName_UF;
        private Label label2;
        private Label label1;
        private TextBox txt_price_UF;
        private TextBox txt_productName_UF;
        private Button btn_changePass;
    }
}