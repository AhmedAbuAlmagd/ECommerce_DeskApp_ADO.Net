namespace E_Commerce.Forms
{
    partial class CategoriesForm
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
            btn_delete_CF = new Button();
            btn_update_CF = new Button();
            btn_add_CF = new Button();
            txt_categoryName_CF = new TextBox();
            label1 = new Label();
            dgv_Categories_CF = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Categories_CF).BeginInit();
            SuspendLayout();
            // 
            // btn_delete_CF
            // 
            btn_delete_CF.BackColor = Color.Maroon;
            btn_delete_CF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_delete_CF.ForeColor = SystemColors.ButtonFace;
            btn_delete_CF.Location = new Point(534, 319);
            btn_delete_CF.Name = "btn_delete_CF";
            btn_delete_CF.Size = new Size(112, 44);
            btn_delete_CF.TabIndex = 60;
            btn_delete_CF.Text = "Delete";
            btn_delete_CF.UseVisualStyleBackColor = false;
            btn_delete_CF.Click += btn_delete_CF_Click;
            // 
            // btn_update_CF
            // 
            btn_update_CF.BackColor = Color.FromArgb(48, 90, 112);
            btn_update_CF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_update_CF.ForeColor = SystemColors.ButtonFace;
            btn_update_CF.Location = new Point(652, 319);
            btn_update_CF.Name = "btn_update_CF";
            btn_update_CF.Size = new Size(112, 44);
            btn_update_CF.TabIndex = 59;
            btn_update_CF.Text = "Update";
            btn_update_CF.UseVisualStyleBackColor = false;
            btn_update_CF.Click += btn_update_CF_Click;
            // 
            // btn_add_CF
            // 
            btn_add_CF.BackColor = Color.FromArgb(54, 132, 107);
            btn_add_CF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_add_CF.ForeColor = SystemColors.ButtonFace;
            btn_add_CF.Location = new Point(534, 231);
            btn_add_CF.Name = "btn_add_CF";
            btn_add_CF.Size = new Size(230, 57);
            btn_add_CF.TabIndex = 58;
            btn_add_CF.Text = "Add";
            btn_add_CF.UseVisualStyleBackColor = false;
            btn_add_CF.Click += btn_add_CF_Click;
            // 
            // txt_categoryName_CF
            // 
            txt_categoryName_CF.Location = new Point(556, 159);
            txt_categoryName_CF.Name = "txt_categoryName_CF";
            txt_categoryName_CF.Size = new Size(186, 27);
            txt_categoryName_CF.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(571, 112);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 53;
            label1.Text = "Category Name";
            // 
            // dgv_Categories_CF
            // 
            dgv_Categories_CF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categories_CF.Location = new Point(1, -2);
            dgv_Categories_CF.Name = "dgv_Categories_CF";
            dgv_Categories_CF.RowHeadersWidth = 51;
            dgv_Categories_CF.Size = new Size(487, 452);
            dgv_Categories_CF.TabIndex = 52;
            dgv_Categories_CF.RowHeaderMouseDoubleClick += dgv_Categories_CF_RowHeaderMouseDoubleClick;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 170, 154);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete_CF);
            Controls.Add(btn_update_CF);
            Controls.Add(btn_add_CF);
            Controls.Add(txt_categoryName_CF);
            Controls.Add(label1);
            Controls.Add(dgv_Categories_CF);
            Name = "CategoriesForm";
            Text = "CategoriesForm";
            Load += CategoriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Categories_CF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete_CF;
        private Button btn_update_CF;
        private Button btn_add_CF;
        private TextBox txt_categoryName_CF;
        private Label label1;
        private DataGridView dgv_Categories_CF;
    }
}