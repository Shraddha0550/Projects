namespace Camera_House
{
    partial class View_All_Customer
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
            this.lb_View_All_Customers = new System.Windows.Forms.Label();
            this.dgv_Customer_List = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_View_All_Customers
            // 
            this.lb_View_All_Customers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_View_All_Customers.AutoSize = true;
            this.lb_View_All_Customers.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_View_All_Customers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_View_All_Customers.Location = new System.Drawing.Point(794, 38);
            this.lb_View_All_Customers.Name = "lb_View_All_Customers";
            this.lb_View_All_Customers.Size = new System.Drawing.Size(337, 41);
            this.lb_View_All_Customers.TabIndex = 28;
            this.lb_View_All_Customers.Text = "View All Customers";
            // 
            // dgv_Customer_List
            // 
            this.dgv_Customer_List.AllowUserToAddRows = false;
            this.dgv_Customer_List.AllowUserToDeleteRows = false;
            this.dgv_Customer_List.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_Customer_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customer_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_List.Location = new System.Drawing.Point(51, 167);
            this.dgv_Customer_List.Name = "dgv_Customer_List";
            this.dgv_Customer_List.ReadOnly = true;
            this.dgv_Customer_List.RowTemplate.Height = 24;
            this.dgv_Customer_List.Size = new System.Drawing.Size(1812, 588);
            this.dgv_Customer_List.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_View_All_Customers);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1863, 104);
            this.panel1.TabIndex = 32;
            // 
            // View_All_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Customer_List);
            this.Name = "View_All_Customer";
            this.Text = "View_All_Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_All_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_View_All_Customers;
        private System.Windows.Forms.DataGridView dgv_Customer_List;
        private System.Windows.Forms.Panel panel1;
    }
}