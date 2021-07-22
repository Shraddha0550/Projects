namespace Camera_House
{
    partial class View_All_Employee
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
            this.dgv_Employee_List = new System.Windows.Forms.DataGridView();
            this.lb_View_All_Employee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Employee_List
            // 
            this.dgv_Employee_List.AllowUserToAddRows = false;
            this.dgv_Employee_List.AllowUserToDeleteRows = false;
            this.dgv_Employee_List.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_Employee_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_List.Location = new System.Drawing.Point(49, 193);
            this.dgv_Employee_List.Name = "dgv_Employee_List";
            this.dgv_Employee_List.ReadOnly = true;
            this.dgv_Employee_List.RowTemplate.Height = 24;
            this.dgv_Employee_List.Size = new System.Drawing.Size(1804, 552);
            this.dgv_Employee_List.TabIndex = 33;
            // 
            // lb_View_All_Employee
            // 
            this.lb_View_All_Employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_View_All_Employee.AutoSize = true;
            this.lb_View_All_Employee.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_View_All_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_View_All_Employee.Location = new System.Drawing.Point(711, 36);
            this.lb_View_All_Employee.Name = "lb_View_All_Employee";
            this.lb_View_All_Employee.Size = new System.Drawing.Size(332, 41);
            this.lb_View_All_Employee.TabIndex = 32;
            this.lb_View_All_Employee.Text = "View All Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_View_All_Employee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 103);
            this.panel1.TabIndex = 34;
            // 
            // View_All_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Employee_List);
            this.Name = "View_All_Employee";
            this.Text = "View_All_Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_All_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Employee_List;
        private System.Windows.Forms.Label lb_View_All_Employee;
        private System.Windows.Forms.Panel panel1;
    }
}