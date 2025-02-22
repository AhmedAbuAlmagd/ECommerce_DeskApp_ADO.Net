namespace E_Commerce.Forms
{
    partial class ProductsForm
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
            combo_category_PF = new ComboBox();
            btn_delete_PF = new Button();
            btn_update_PF = new Button();
            btn_add_PF = new Button();
            txt_productName_PF = new TextBox();
            label_Role = new Label();
            num_price_PF = new NumericUpDown();
            label4 = new Label();
            label1 = new Label();
            dgv_Products_PF = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)num_price_PF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Products_PF).BeginInit();
            SuspendLayout();
            // 
            // combo_category_PF
            // 
            combo_category_PF.FormattingEnabled = true;
            combo_category_PF.Location = new Point(613, 52);
            combo_category_PF.Name = "combo_category_PF";
            combo_category_PF.Size = new Size(175, 28);
            combo_category_PF.TabIndex = 51;
            // 
            // btn_delete_PF
            // 
            btn_delete_PF.BackColor = Color.Maroon;
            btn_delete_PF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_delete_PF.ForeColor = SystemColors.ButtonHighlight;
            btn_delete_PF.Location = new Point(498, 350);
            btn_delete_PF.Name = "btn_delete_PF";
            btn_delete_PF.Size = new Size(141, 44);
            btn_delete_PF.TabIndex = 50;
            btn_delete_PF.Text = "Delete";
            btn_delete_PF.UseVisualStyleBackColor = false;
            btn_delete_PF.Click += btn_delete_PF_Click;
            // 
            // btn_update_PF
            // 
            btn_update_PF.BackColor = Color.FromArgb(48, 90, 112);
            btn_update_PF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_update_PF.ForeColor = Color.White;
            btn_update_PF.Location = new Point(645, 350);
            btn_update_PF.Name = "btn_update_PF";
            btn_update_PF.Size = new Size(143, 44);
            btn_update_PF.TabIndex = 49;
            btn_update_PF.Text = "Update";
            btn_update_PF.UseVisualStyleBackColor = false;
            btn_update_PF.Click += btn_update_PF_Click;
            // 
            // btn_add_PF
            // 
            btn_add_PF.BackColor = Color.FromArgb(54, 132, 107);
            btn_add_PF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_add_PF.ForeColor = Color.White;
            btn_add_PF.Location = new Point(498, 275);
            btn_add_PF.Name = "btn_add_PF";
            btn_add_PF.Size = new Size(290, 44);
            btn_add_PF.TabIndex = 48;
            btn_add_PF.Text = "Add";
            btn_add_PF.UseVisualStyleBackColor = false;
            btn_add_PF.Click += btn_add_PF_Click;
            // 
            // txt_productName_PF
            // 
            txt_productName_PF.Location = new Point(613, 119);
            txt_productName_PF.Name = "txt_productName_PF";
            txt_productName_PF.Size = new Size(175, 27);
            txt_productName_PF.TabIndex = 46;
            // 
            // label_Role
            // 
            label_Role.AutoSize = true;
            label_Role.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label_Role.ForeColor = SystemColors.ButtonHighlight;
            label_Role.Location = new Point(509, 52);
            label_Role.Name = "label_Role";
            label_Role.Size = new Size(88, 25);
            label_Role.TabIndex = 44;
            label_Role.Text = "Category";
            // 
            // num_price_PF
            // 
            num_price_PF.Location = new Point(613, 175);
            num_price_PF.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            num_price_PF.Name = "num_price_PF";
            num_price_PF.Size = new Size(175, 27);
            num_price_PF.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(544, 177);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 41;
            label4.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(472, 118);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 37;
            label1.Text = "Product Name";
            // 
            // dgv_Products_PF
            // 
            dgv_Products_PF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Products_PF.Location = new Point(2, -1);
            dgv_Products_PF.Name = "dgv_Products_PF";
            dgv_Products_PF.RowHeadersWidth = 51;
            dgv_Products_PF.Size = new Size(464, 449);
            dgv_Products_PF.TabIndex = 36;
            dgv_Products_PF.RowHeaderMouseDoubleClick += dgv_Products_PF_RowHeaderMouseDoubleClick;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 170, 154);
            ClientSize = new Size(800, 450);
            Controls.Add(combo_category_PF);
            Controls.Add(btn_delete_PF);
            Controls.Add(btn_update_PF);
            Controls.Add(btn_add_PF);
            Controls.Add(txt_productName_PF);
            Controls.Add(label_Role);
            Controls.Add(num_price_PF);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dgv_Products_PF);
            Name = "ProductsForm";
            Text = "ProductsForm";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)num_price_PF).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Products_PF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox combo_category_PF;
        private Button btn_delete_PF;
        private Button btn_update_PF;
        private Button btn_add_PF;
        private TextBox txt_productName_PF;
        private Label label_Role;
        private NumericUpDown num_price_PF;
        private Label label4;
        private Label label1;
        private DataGridView dgv_Products_PF;
    }
}