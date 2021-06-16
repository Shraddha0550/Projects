namespace Lodging_Managment_System
{
    partial class Reports
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Cust_Rep = new System.Windows.Forms.Button();
            this.btn_Employee_Rep = new System.Windows.Forms.Button();
            this.btn_Room_Rep = new System.Windows.Forms.Button();
            this.btn_Service_Rep = new System.Windows.Forms.Button();
            this.btn_Check_Out_Rep = new System.Windows.Forms.Button();
            this.pnl_Cust = new System.Windows.Forms.Panel();
            this.btn_Cust_List = new System.Windows.Forms.Button();
            this.btn_Single_Cust = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Cust_ID = new System.Windows.Forms.TextBox();
            this.lb_Cust_ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Cust.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 155);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1301, 593);
            this.crystalReportViewer1.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(1241, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 84;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Cust_Rep
            // 
            this.btn_Cust_Rep.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Cust_Rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cust_Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cust_Rep.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Cust_Rep.Location = new System.Drawing.Point(0, 0);
            this.btn_Cust_Rep.Name = "btn_Cust_Rep";
            this.btn_Cust_Rep.Size = new System.Drawing.Size(175, 55);
            this.btn_Cust_Rep.TabIndex = 81;
            this.btn_Cust_Rep.Text = "Customer";
            this.btn_Cust_Rep.UseVisualStyleBackColor = false;
            this.btn_Cust_Rep.MouseHover += new System.EventHandler(this.btn_Cust_Rep_MouseHover);
            // 
            // btn_Employee_Rep
            // 
            this.btn_Employee_Rep.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Employee_Rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employee_Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_Rep.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Employee_Rep.Location = new System.Drawing.Point(175, 0);
            this.btn_Employee_Rep.Name = "btn_Employee_Rep";
            this.btn_Employee_Rep.Size = new System.Drawing.Size(188, 55);
            this.btn_Employee_Rep.TabIndex = 82;
            this.btn_Employee_Rep.Text = "Employee";
            this.btn_Employee_Rep.UseVisualStyleBackColor = false;
            this.btn_Employee_Rep.Click += new System.EventHandler(this.btn_Employee_Rep_Click);
            this.btn_Employee_Rep.MouseHover += new System.EventHandler(this.btn_Employee_Rep_MouseHover);
            // 
            // btn_Room_Rep
            // 
            this.btn_Room_Rep.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Room_Rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Room_Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Room_Rep.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Room_Rep.Location = new System.Drawing.Point(363, 0);
            this.btn_Room_Rep.Name = "btn_Room_Rep";
            this.btn_Room_Rep.Size = new System.Drawing.Size(184, 55);
            this.btn_Room_Rep.TabIndex = 85;
            this.btn_Room_Rep.Text = "Room";
            this.btn_Room_Rep.UseVisualStyleBackColor = false;
            this.btn_Room_Rep.Click += new System.EventHandler(this.btn_Room_Rep_Click);
            this.btn_Room_Rep.MouseHover += new System.EventHandler(this.btn_Room_Rep_MouseHover);
            // 
            // btn_Service_Rep
            // 
            this.btn_Service_Rep.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Service_Rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Service_Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Service_Rep.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Service_Rep.Location = new System.Drawing.Point(547, 0);
            this.btn_Service_Rep.Name = "btn_Service_Rep";
            this.btn_Service_Rep.Size = new System.Drawing.Size(184, 55);
            this.btn_Service_Rep.TabIndex = 86;
            this.btn_Service_Rep.Text = "Service";
            this.btn_Service_Rep.UseVisualStyleBackColor = false;
            this.btn_Service_Rep.Click += new System.EventHandler(this.btn_Service_Rep_Click);
            this.btn_Service_Rep.MouseHover += new System.EventHandler(this.btn_Service_Rep_MouseHover);
            // 
            // btn_Check_Out_Rep
            // 
            this.btn_Check_Out_Rep.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Check_Out_Rep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check_Out_Rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check_Out_Rep.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Check_Out_Rep.Location = new System.Drawing.Point(731, 0);
            this.btn_Check_Out_Rep.Name = "btn_Check_Out_Rep";
            this.btn_Check_Out_Rep.Size = new System.Drawing.Size(184, 55);
            this.btn_Check_Out_Rep.TabIndex = 87;
            this.btn_Check_Out_Rep.Text = "Check-Out";
            this.btn_Check_Out_Rep.UseVisualStyleBackColor = false;
            this.btn_Check_Out_Rep.Click += new System.EventHandler(this.btn_Check_Out_Rep_Click);
            this.btn_Check_Out_Rep.MouseHover += new System.EventHandler(this.btn_Check_Out_Rep_MouseHover);
            // 
            // pnl_Cust
            // 
            this.pnl_Cust.Controls.Add(this.btn_Cust_List);
            this.pnl_Cust.Controls.Add(this.btn_Single_Cust);
            this.pnl_Cust.Location = new System.Drawing.Point(0, 58);
            this.pnl_Cust.Name = "pnl_Cust";
            this.pnl_Cust.Size = new System.Drawing.Size(169, 97);
            this.pnl_Cust.TabIndex = 95;
            this.pnl_Cust.Visible = false;
            // 
            // btn_Cust_List
            // 
            this.btn_Cust_List.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cust_List.Location = new System.Drawing.Point(3, 45);
            this.btn_Cust_List.Name = "btn_Cust_List";
            this.btn_Cust_List.Size = new System.Drawing.Size(163, 49);
            this.btn_Cust_List.TabIndex = 1;
            this.btn_Cust_List.Text = "Customers List";
            this.btn_Cust_List.UseVisualStyleBackColor = true;
            this.btn_Cust_List.Click += new System.EventHandler(this.btn_Cust_List_Click);
            // 
            // btn_Single_Cust
            // 
            this.btn_Single_Cust.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Single_Cust.Location = new System.Drawing.Point(3, 0);
            this.btn_Single_Cust.Name = "btn_Single_Cust";
            this.btn_Single_Cust.Size = new System.Drawing.Size(163, 49);
            this.btn_Single_Cust.TabIndex = 0;
            this.btn_Single_Cust.Text = "Single Customer";
            this.btn_Single_Cust.UseVisualStyleBackColor = true;
            this.btn_Single_Cust.Click += new System.EventHandler(this.btn_Single_Cust_Click_1);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(923, 84);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(171, 42);
            this.btn_Search.TabIndex = 96;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Cust_ID
            // 
            this.tb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cust_ID.Location = new System.Drawing.Point(628, 88);
            this.tb_Cust_ID.Name = "tb_Cust_ID";
            this.tb_Cust_ID.Size = new System.Drawing.Size(228, 34);
            this.tb_Cust_ID.TabIndex = 97;
            this.tb_Cust_ID.Visible = false;
            // 
            // lb_Cust_ID
            // 
            this.lb_Cust_ID.AutoSize = true;
            this.lb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cust_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_Cust_ID.Location = new System.Drawing.Point(452, 88);
            this.lb_Cust_ID.Name = "lb_Cust_ID";
            this.lb_Cust_ID.Size = new System.Drawing.Size(146, 29);
            this.lb_Cust_ID.TabIndex = 98;
            this.lb_Cust_ID.Text = "Customer ID";
            this.lb_Cust_ID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.lb_Cust_ID);
            this.panel1.Controls.Add(this.tb_Cust_ID);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.pnl_Cust);
            this.panel1.Controls.Add(this.btn_Check_Out_Rep);
            this.panel1.Controls.Add(this.btn_Service_Rep);
            this.panel1.Controls.Add(this.btn_Room_Rep);
            this.panel1.Controls.Add(this.btn_Employee_Rep);
            this.panel1.Controls.Add(this.btn_Cust_Rep);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 155);
            this.panel1.TabIndex = 89;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 748);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rep_Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Cust.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Cust_Rep;
        private System.Windows.Forms.Button btn_Employee_Rep;
        private System.Windows.Forms.Button btn_Room_Rep;
        private System.Windows.Forms.Button btn_Service_Rep;
        private System.Windows.Forms.Button btn_Check_Out_Rep;
        private System.Windows.Forms.Panel pnl_Cust;
        private System.Windows.Forms.Button btn_Cust_List;
        private System.Windows.Forms.Button btn_Single_Cust;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Cust_ID;
        private System.Windows.Forms.Label lb_Cust_ID;
        private System.Windows.Forms.Panel panel1;
    }
}