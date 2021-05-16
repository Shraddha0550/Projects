namespace Camera_House
{
    partial class Add_Stock
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
            this.lb_Company_Name = new System.Windows.Forms.Label();
            this.cmb_Company_Name = new System.Windows.Forms.ComboBox();
            this.lb_Model_Name = new System.Windows.Forms.Label();
            this.cmb_Model_Name = new System.Windows.Forms.ComboBox();
            this.lb_Current_Stock = new System.Windows.Forms.Label();
            this.tb_Current_Stock = new System.Windows.Forms.TextBox();
            this.tb_Product_ID = new System.Windows.Forms.TextBox();
            this.lb_Product_ID = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Total_Stock = new System.Windows.Forms.TextBox();
            this.tb_Stock_Added = new System.Windows.Forms.TextBox();
            this.lb_Stock_Added = new System.Windows.Forms.Label();
            this.cmb_Distrubutor_Name = new System.Windows.Forms.ComboBox();
            this.lb_Distrubutor = new System.Windows.Forms.Label();
            this.btn_Total_STock = new System.Windows.Forms.Button();
            this.lb_Add_Stock = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Company_Name
            // 
            this.lb_Company_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Company_Name.AutoSize = true;
            this.lb_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Company_Name.Location = new System.Drawing.Point(298, 58);
            this.lb_Company_Name.Name = "lb_Company_Name";
            this.lb_Company_Name.Size = new System.Drawing.Size(186, 29);
            this.lb_Company_Name.TabIndex = 25;
            this.lb_Company_Name.Text = "Company Name";
            // 
            // cmb_Company_Name
            // 
            this.cmb_Company_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Company_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_Company_Name.FormattingEnabled = true;
            this.cmb_Company_Name.Location = new System.Drawing.Point(490, 61);
            this.cmb_Company_Name.Name = "cmb_Company_Name";
            this.cmb_Company_Name.Size = new System.Drawing.Size(482, 33);
            this.cmb_Company_Name.TabIndex = 27;
            this.cmb_Company_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Company_Name_SelectedIndexChanged);
            // 
            // lb_Model_Name
            // 
            this.lb_Model_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Model_Name.AutoSize = true;
            this.lb_Model_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Model_Name.Location = new System.Drawing.Point(302, 116);
            this.lb_Model_Name.Name = "lb_Model_Name";
            this.lb_Model_Name.Size = new System.Drawing.Size(182, 29);
            this.lb_Model_Name.TabIndex = 26;
            this.lb_Model_Name.Text = "Model Name     \r\n";
            // 
            // cmb_Model_Name
            // 
            this.cmb_Model_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Model_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Model_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_Model_Name.FormattingEnabled = true;
            this.cmb_Model_Name.Location = new System.Drawing.Point(490, 119);
            this.cmb_Model_Name.Name = "cmb_Model_Name";
            this.cmb_Model_Name.Size = new System.Drawing.Size(482, 33);
            this.cmb_Model_Name.TabIndex = 28;
            // 
            // lb_Current_Stock
            // 
            this.lb_Current_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Current_Stock.AutoSize = true;
            this.lb_Current_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Current_Stock.Location = new System.Drawing.Point(290, 232);
            this.lb_Current_Stock.Name = "lb_Current_Stock";
            this.lb_Current_Stock.Size = new System.Drawing.Size(194, 29);
            this.lb_Current_Stock.TabIndex = 29;
            this.lb_Current_Stock.Text = "Current Stock      ";
            // 
            // tb_Current_Stock
            // 
            this.tb_Current_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Current_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock.Location = new System.Drawing.Point(490, 235);
            this.tb_Current_Stock.Name = "tb_Current_Stock";
            this.tb_Current_Stock.Size = new System.Drawing.Size(482, 30);
            this.tb_Current_Stock.TabIndex = 30;
            // 
            // tb_Product_ID
            // 
            this.tb_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_ID.Location = new System.Drawing.Point(490, 3);
            this.tb_Product_ID.Name = "tb_Product_ID";
            this.tb_Product_ID.Size = new System.Drawing.Size(482, 30);
            this.tb_Product_ID.TabIndex = 32;
            // 
            // lb_Product_ID
            // 
            this.lb_Product_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Product_ID.AutoSize = true;
            this.lb_Product_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Product_ID.Location = new System.Drawing.Point(305, 0);
            this.lb_Product_ID.Name = "lb_Product_ID";
            this.lb_Product_ID.Size = new System.Drawing.Size(179, 29);
            this.lb_Product_ID.TabIndex = 31;
            this.lb_Product_ID.Text = "Product ID         ";
            // 
            // lb_Date
            // 
            this.lb_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(1077, 42);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(177, 29);
            this.lb_Date.TabIndex = 39;
            this.lb_Date.Text = "Date                   ";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(1307, 41);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(482, 30);
            this.dtp_Date.TabIndex = 40;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(830, 676);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(162, 59);
            this.btn_Add.TabIndex = 42;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Total_Stock, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Stock_Added, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_Stock_Added, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Distrubutor_Name, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Distrubutor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Product_ID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Company_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Model_Name, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Product_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Company_Name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Model_Name, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Current_Stock, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Current_Stock, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Total_STock, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(146, 218);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 413);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // tb_Total_Stock
            // 
            this.tb_Total_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Total_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Stock.Location = new System.Drawing.Point(490, 351);
            this.tb_Total_Stock.Name = "tb_Total_Stock";
            this.tb_Total_Stock.Size = new System.Drawing.Size(482, 30);
            this.tb_Total_Stock.TabIndex = 45;
            // 
            // tb_Stock_Added
            // 
            this.tb_Stock_Added.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Stock_Added.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock_Added.Location = new System.Drawing.Point(490, 293);
            this.tb_Stock_Added.Name = "tb_Stock_Added";
            this.tb_Stock_Added.Size = new System.Drawing.Size(482, 30);
            this.tb_Stock_Added.TabIndex = 45;
            // 
            // lb_Stock_Added
            // 
            this.lb_Stock_Added.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Stock_Added.AutoSize = true;
            this.lb_Stock_Added.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Stock_Added.Location = new System.Drawing.Point(292, 290);
            this.lb_Stock_Added.Name = "lb_Stock_Added";
            this.lb_Stock_Added.Size = new System.Drawing.Size(192, 29);
            this.lb_Stock_Added.TabIndex = 45;
            this.lb_Stock_Added.Text = "Stock Added       ";
            // 
            // cmb_Distrubutor_Name
            // 
            this.cmb_Distrubutor_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Distrubutor_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Distrubutor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_Distrubutor_Name.FormattingEnabled = true;
            this.cmb_Distrubutor_Name.Location = new System.Drawing.Point(490, 177);
            this.cmb_Distrubutor_Name.Name = "cmb_Distrubutor_Name";
            this.cmb_Distrubutor_Name.Size = new System.Drawing.Size(482, 33);
            this.cmb_Distrubutor_Name.TabIndex = 46;
            this.cmb_Distrubutor_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Distrubutor_Name_SelectedIndexChanged);
            // 
            // lb_Distrubutor
            // 
            this.lb_Distrubutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Distrubutor.AutoSize = true;
            this.lb_Distrubutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Distrubutor.Location = new System.Drawing.Point(283, 174);
            this.lb_Distrubutor.Name = "lb_Distrubutor";
            this.lb_Distrubutor.Size = new System.Drawing.Size(201, 29);
            this.lb_Distrubutor.TabIndex = 45;
            this.lb_Distrubutor.Text = "Distrubutor Name";
            // 
            // btn_Total_STock
            // 
            this.btn_Total_STock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Total_STock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Total_STock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Total_STock.Location = new System.Drawing.Point(322, 351);
            this.btn_Total_STock.Name = "btn_Total_STock";
            this.btn_Total_STock.Size = new System.Drawing.Size(162, 46);
            this.btn_Total_STock.TabIndex = 45;
            this.btn_Total_STock.Text = "Total Stock";
            this.btn_Total_STock.UseVisualStyleBackColor = true;
            this.btn_Total_STock.Click += new System.EventHandler(this.btn_Total_STock_Click);
            // 
            // lb_Add_Stock
            // 
            this.lb_Add_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Add_Stock.AutoSize = true;
            this.lb_Add_Stock.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add_Stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Add_Stock.Location = new System.Drawing.Point(808, 90);
            this.lb_Add_Stock.Name = "lb_Add_Stock";
            this.lb_Add_Stock.Size = new System.Drawing.Size(184, 41);
            this.lb_Add_Stock.TabIndex = 44;
            this.lb_Add_Stock.Text = "Add Stock";
            // 
            // Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 826);
            this.Controls.Add(this.lb_Add_Stock);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.lb_Date);
            this.Name = "Add_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Stock_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Company_Name;
        private System.Windows.Forms.ComboBox cmb_Company_Name;
        private System.Windows.Forms.Label lb_Model_Name;
        private System.Windows.Forms.ComboBox cmb_Model_Name;
        private System.Windows.Forms.Label lb_Current_Stock;
        private System.Windows.Forms.TextBox tb_Current_Stock;
        private System.Windows.Forms.TextBox tb_Product_ID;
        private System.Windows.Forms.Label lb_Product_ID;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Add_Stock;
        private System.Windows.Forms.ComboBox cmb_Distrubutor_Name;
        private System.Windows.Forms.Label lb_Distrubutor;
        private System.Windows.Forms.TextBox tb_Total_Stock;
        private System.Windows.Forms.TextBox tb_Stock_Added;
        private System.Windows.Forms.Label lb_Stock_Added;
        private System.Windows.Forms.Button btn_Total_STock;
    }
}