namespace E_Commerce.Forms
{
    partial class AdminForm
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
            btn_ShowUsers_AF = new Button();
            button2btn_ShowProducts_AF = new Button();
            btn_ShowCategories_AF = new Button();
            panelContainer = new Panel();
            btn_BackFromAF = new Button();
            SuspendLayout();
            // 
            // btn_ShowUsers_AF
            // 
            btn_ShowUsers_AF.BackColor = Color.FromArgb(54, 132, 107);
            btn_ShowUsers_AF.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_ShowUsers_AF.ForeColor = Color.White;
            btn_ShowUsers_AF.Location = new Point(0, 0);
            btn_ShowUsers_AF.Name = "btn_ShowUsers_AF";
            btn_ShowUsers_AF.Size = new Size(215, 59);
            btn_ShowUsers_AF.TabIndex = 0;
            btn_ShowUsers_AF.Text = "Show Users";
            btn_ShowUsers_AF.UseVisualStyleBackColor = false;
            btn_ShowUsers_AF.Click += btn_ShowUsers_AF_Click;
            // 
            // button2btn_ShowProducts_AF
            // 
            button2btn_ShowProducts_AF.BackColor = Color.FromArgb(54, 132, 107);
            button2btn_ShowProducts_AF.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            button2btn_ShowProducts_AF.ForeColor = Color.White;
            button2btn_ShowProducts_AF.Location = new Point(212, 0);
            button2btn_ShowProducts_AF.Name = "button2btn_ShowProducts_AF";
            button2btn_ShowProducts_AF.Size = new Size(215, 59);
            button2btn_ShowProducts_AF.TabIndex = 0;
            button2btn_ShowProducts_AF.Text = "Show Products";
            button2btn_ShowProducts_AF.UseVisualStyleBackColor = false;
            button2btn_ShowProducts_AF.Click += button2btn_ShowProducts_AF_Click;
            // 
            // btn_ShowCategories_AF
            // 
            btn_ShowCategories_AF.BackColor = Color.FromArgb(54, 132, 107);
            btn_ShowCategories_AF.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic);
            btn_ShowCategories_AF.ForeColor = Color.White;
            btn_ShowCategories_AF.Location = new Point(424, 0);
            btn_ShowCategories_AF.Name = "btn_ShowCategories_AF";
            btn_ShowCategories_AF.Size = new Size(215, 59);
            btn_ShowCategories_AF.TabIndex = 0;
            btn_ShowCategories_AF.Text = "Show Categories";
            btn_ShowCategories_AF.UseVisualStyleBackColor = false;
            btn_ShowCategories_AF.Click += btn_ShowCategories_AF_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(0, 60);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(789, 455);
            panelContainer.TabIndex = 0;
            // 
            // btn_BackFromAF
            // 
            btn_BackFromAF.BackColor = Color.Maroon;
            btn_BackFromAF.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_BackFromAF.ForeColor = Color.White;
            btn_BackFromAF.Location = new Point(635, 0);
            btn_BackFromAF.Name = "btn_BackFromAF";
            btn_BackFromAF.Size = new Size(154, 59);
            btn_BackFromAF.TabIndex = 1;
            btn_BackFromAF.Text = "Log Out";
            btn_BackFromAF.UseVisualStyleBackColor = false;
            btn_BackFromAF.Click += btn_BackFromAF_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 516);
            Controls.Add(btn_BackFromAF);
            Controls.Add(panelContainer);
            Controls.Add(btn_ShowCategories_AF);
            Controls.Add(button2btn_ShowProducts_AF);
            Controls.Add(btn_ShowUsers_AF);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ShowUsers_AF;
        private Button button2btn_ShowProducts_AF;
        private Button btn_ShowCategories_AF;
        private Panel panelContainer;
        private Button btn_BackFromAF;
    }
}