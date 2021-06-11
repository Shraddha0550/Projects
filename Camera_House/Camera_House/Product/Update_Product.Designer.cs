namespace Camera_House
{
    partial class Update_Product
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.lb_Product_ID = new System.Windows.Forms.Label();
            this.tb_Prod_ID = new System.Windows.Forms.TextBox();
            this.lb_Update_Product = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Purchase_Price = new System.Windows.Forms.Label();
            this.tb_Purches_Price = new System.Windows.Forms.TextBox();
            this.lb_Sale_Price = new System.Windows.Forms.Label();
            this.tb_Sale_Price = new System.Windows.Forms.TextBox();
            this.lb_Company_Name = new System.Windows.Forms.Label();
            this.lb_Model_Name = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.lb_Description = new System.Windows.Forms.Label();
            this.tb_Company_Name = new System.Windows.Forms.TextBox();
            this.tb_Model_Name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(967, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(165, 53);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lb_Product_ID
            // 
            this.lb_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Product_ID.AutoSize = true;
            this.lb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Product_ID.Location = new System.Drawing.Point(292, 0);
            this.lb_Product_ID.Name = "lb_Product_ID";
            this.lb_Product_ID.Size = new System.Drawing.Size(125, 29);
            this.lb_Product_ID.TabIndex = 32;
            this.lb_Product_ID.Text = "Product ID";
            // 
            // tb_Prod_ID
            // 
            this.tb_Prod_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Prod_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Prod_ID.Location = new System.Drawing.Point(423, 3);
            this.tb_Prod_ID.Name = "tb_Prod_ID";
            this.tb_Prod_ID.Size = new System.Drawing.Size(414, 30);
            this.tb_Prod_ID.TabIndex = 0;
            this.tb_Prod_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // lb_Update_Product
            // 
            this.lb_Update_Product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Update_Product.AutoSize = true;
            this.lb_Update_Product.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Update_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Update_Product.Location = new System.Drawing.Point(603, 20);
            this.lb_Update_Product.Name = "lb_Update_Product";
            this.lb_Update_Product.Size = new System.Drawing.Size(271, 41);
            this.lb_Update_Product.TabIndex = 34;
            this.lb_Update_Product.Text = "Update Product";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_Update_Product);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 100);
            this.panel1.TabIndex = 56;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Purchase_Price, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Purches_Price, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Sale_Price, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Sale_Price, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Company_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Model_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Description, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Description, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Company_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Model_Name, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 250);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1480, 323);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // lb_Purchase_Price
            // 
            this.lb_Purchase_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Purchase_Price.AutoSize = true;
            this.lb_Purchase_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Purchase_Price.Location = new System.Drawing.Point(931, 0);
            this.lb_Purchase_Price.Name = "lb_Purchase_Price";
            this.lb_Purchase_Price.Size = new System.Drawing.Size(176, 29);
            this.lb_Purchase_Price.TabIndex = 10;
            this.lb_Purchase_Price.Text = "Purchase Price";
            // 
            // tb_Purches_Price
            // 
            this.tb_Purches_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Purches_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purches_Price.Location = new System.Drawing.Point(1113, 3);
            this.tb_Purches_Price.Name = "tb_Purches_Price";
            this.tb_Purches_Price.Size = new System.Drawing.Size(364, 30);
            this.tb_Purches_Price.TabIndex = 2;
            this.tb_Purches_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // lb_Sale_Price
            // 
            this.lb_Sale_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Sale_Price.AutoSize = true;
            this.lb_Sale_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sale_Price.Location = new System.Drawing.Point(983, 80);
            this.lb_Sale_Price.Name = "lb_Sale_Price";
            this.lb_Sale_Price.Size = new System.Drawing.Size(124, 29);
            this.lb_Sale_Price.TabIndex = 12;
            this.lb_Sale_Price.Text = "Sale Price";
            // 
            // tb_Sale_Price
            // 
            this.tb_Sale_Price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Sale_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sale_Price.Location = new System.Drawing.Point(1113, 83);
            this.tb_Sale_Price.Name = "tb_Sale_Price";
            this.tb_Sale_Price.Size = new System.Drawing.Size(364, 30);
            this.tb_Sale_Price.TabIndex = 3;
            this.tb_Sale_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Number);
            // 
            // lb_Company_Name
            // 
            this.lb_Company_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Company_Name.AutoSize = true;
            this.lb_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Company_Name.Location = new System.Drawing.Point(181, 0);
            this.lb_Company_Name.Name = "lb_Company_Name";
            this.lb_Company_Name.Size = new System.Drawing.Size(186, 29);
            this.lb_Company_Name.TabIndex = 6;
            this.lb_Company_Name.Text = "Company Name";
            // 
            // lb_Model_Name
            // 
            this.lb_Model_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Model_Name.AutoSize = true;
            this.lb_Model_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Model_Name.Location = new System.Drawing.Point(215, 80);
            this.lb_Model_Name.Name = "lb_Model_Name";
            this.lb_Model_Name.Size = new System.Drawing.Size(152, 29);
            this.lb_Model_Name.TabIndex = 8;
            this.lb_Model_Name.Text = "Model Name";
            // 
            // tb_Description
            // 
            this.tb_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Description.Location = new System.Drawing.Point(1113, 163);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(364, 74);
            this.tb_Description.TabIndex = 4;
            this.tb_Description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Alphanumeric);
            // 
            // lb_Description
            // 
            this.lb_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Description.AutoSize = true;
            this.lb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Description.Location = new System.Drawing.Point(972, 160);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(135, 29);
            this.lb_Description.TabIndex = 21;
            this.lb_Description.Text = "Description";
            // 
            // tb_Company_Name
            // 
            this.tb_Company_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Company_Name.Enabled = false;
            this.tb_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Company_Name.Location = new System.Drawing.Point(373, 3);
            this.tb_Company_Name.Name = "tb_Company_Name";
            this.tb_Company_Name.Size = new System.Drawing.Size(364, 30);
            this.tb_Company_Name.TabIndex = 32;
            this.tb_Company_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Model_Name
            // 
            this.tb_Model_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Model_Name.Enabled = false;
            this.tb_Model_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Model_Name.Location = new System.Drawing.Point(373, 83);
            this.tb_Model_Name.Name = "tb_Model_Name";
            this.tb_Model_Name.Size = new System.Drawing.Size(364, 30);
            this.tb_Model_Name.TabIndex = 33;
            this.tb_Model_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Alphanumeric);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Update, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Refresh, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(34, 624);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1443, 76);
            this.tableLayoutPanel2.TabIndex = 58;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(276, 9);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(169, 58);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(997, 9);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(169, 58);
            this.btn_Refresh.TabIndex = 18;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.lb_Product_ID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_Prod_ID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Search, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(90, 120);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1260, 83);
            this.tableLayoutPanel3.TabIndex = 59;
            // 
            // Update_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 826);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Update_Product";
            this.Text = "Update_Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Update_Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lb_Product_ID;
        private System.Windows.Forms.TextBox tb_Prod_ID;
        private System.Windows.Forms.Label lb_Update_Product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Purches_Price;
        private System.Windows.Forms.Label lb_Sale_Price;
        private System.Windows.Forms.TextBox tb_Sale_Price;
        private System.Windows.Forms.Label lb_Company_Name;
        private System.Windows.Forms.Label lb_Model_Name;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tb_Company_Name;
        private System.Windows.Forms.TextBox tb_Model_Name;
    }
}