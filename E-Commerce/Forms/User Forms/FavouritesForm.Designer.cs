namespace E_Commerce.Forms
{
    partial class FavouritesForm
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
            btn_back_from_favF = new Button();
            dgv_favourites_FF = new DataGridView();
            btn_Remove_FF = new Button();
            txt_productName_FF = new TextBox();
            label_productName_FF = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_favourites_FF).BeginInit();
            SuspendLayout();
            // 
            // btn_back_from_favF
            // 
            btn_back_from_favF.BackColor = Color.Maroon;
            btn_back_from_favF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_back_from_favF.ForeColor = Color.White;
            btn_back_from_favF.Location = new Point(669, 371);
            btn_back_from_favF.Name = "btn_back_from_favF";
            btn_back_from_favF.Size = new Size(110, 58);
            btn_back_from_favF.TabIndex = 5;
            btn_back_from_favF.Text = "Back";
            btn_back_from_favF.UseVisualStyleBackColor = false;
            btn_back_from_favF.Click += btn_back_from_favF_Click;
            // 
            // dgv_favourites_FF
            // 
            dgv_favourites_FF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_favourites_FF.Location = new Point(14, 24);
            dgv_favourites_FF.Name = "dgv_favourites_FF";
            dgv_favourites_FF.RowHeadersWidth = 51;
            dgv_favourites_FF.Size = new Size(498, 405);
            dgv_favourites_FF.TabIndex = 4;
            dgv_favourites_FF.RowHeaderMouseDoubleClick += dgv_favourites_FF_RowHeaderMouseDoubleClick;
            // 
            // btn_Remove_FF
            // 
            btn_Remove_FF.BackColor = Color.FromArgb(75, 170, 154);
            btn_Remove_FF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btn_Remove_FF.ForeColor = Color.White;
            btn_Remove_FF.Location = new Point(558, 199);
            btn_Remove_FF.Name = "btn_Remove_FF";
            btn_Remove_FF.Size = new Size(207, 59);
            btn_Remove_FF.TabIndex = 6;
            btn_Remove_FF.Text = "Remove";
            btn_Remove_FF.UseVisualStyleBackColor = false;
            btn_Remove_FF.Click += btn_Remove_FF_Click;
            // 
            // txt_productName_FF
            // 
            txt_productName_FF.Location = new Point(558, 128);
            txt_productName_FF.Name = "txt_productName_FF";
            txt_productName_FF.ReadOnly = true;
            txt_productName_FF.Size = new Size(207, 30);
            txt_productName_FF.TabIndex = 7;
            // 
            // label_productName_FF
            // 
            label_productName_FF.AutoSize = true;
            label_productName_FF.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label_productName_FF.Location = new Point(558, 85);
            label_productName_FF.Name = "label_productName_FF";
            label_productName_FF.Size = new Size(128, 25);
            label_productName_FF.TabIndex = 8;
            label_productName_FF.Text = "Product Name";
            // 
            // FavouritesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 223, 186);
            ClientSize = new Size(800, 450);
            Controls.Add(label_productName_FF);
            Controls.Add(txt_productName_FF);
            Controls.Add(btn_Remove_FF);
            Controls.Add(btn_back_from_favF);
            Controls.Add(dgv_favourites_FF);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FavouritesForm";
            Text = "FavouritesForm";
            Load += FavouritesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_favourites_FF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back_from_favF;
        private DataGridView dgv_favourites_FF;
        private Button btn_Remove_FF;
        private TextBox txt_productName_FF;
        private Label label_productName_FF;
    }
}