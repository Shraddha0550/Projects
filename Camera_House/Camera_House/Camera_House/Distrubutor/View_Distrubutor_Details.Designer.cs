namespace Camera_House
{
    partial class View_Distrubutor_Details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_View_Dist_Details = new System.Windows.Forms.Label();
            this.dgv_View_Dist_Info = new System.Windows.Forms.DataGridView();
            this.btn_Product_Details_List = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Dist_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_View_Dist_Details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 103);
            this.panel1.TabIndex = 36;
            // 
            // lb_View_Dist_Details
            // 
            this.lb_View_Dist_Details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_View_Dist_Details.AutoSize = true;
            this.lb_View_Dist_Details.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_View_Dist_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_View_Dist_Details.Location = new System.Drawing.Point(711, 36);
            this.lb_View_Dist_Details.Name = "lb_View_Dist_Details";
            this.lb_View_Dist_Details.Size = new System.Drawing.Size(510, 41);
            this.lb_View_Dist_Details.TabIndex = 32;
            this.lb_View_Dist_Details.Text = "View Distrubutor Information";
            // 
            // dgv_View_Dist_Info
            // 
            this.dgv_View_Dist_Info.AllowUserToAddRows = false;
            this.dgv_View_Dist_Info.AllowUserToDeleteRows = false;
            this.dgv_View_Dist_Info.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_View_Dist_Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Dist_Info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgv_View_Dist_Info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_View_Dist_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Dist_Info.Location = new System.Drawing.Point(12, 196);
            this.dgv_View_Dist_Info.Name = "dgv_View_Dist_Info";
            this.dgv_View_Dist_Info.ReadOnly = true;
            this.dgv_View_Dist_Info.RowTemplate.Height = 24;
            this.dgv_View_Dist_Info.Size = new System.Drawing.Size(1804, 552);
            this.dgv_View_Dist_Info.TabIndex = 35;
            // 
            // btn_Product_Details_List
            // 
            this.btn_Product_Details_List.Location = new System.Drawing.Point(1615, 121);
            this.btn_Product_Details_List.Name = "btn_Product_Details_List";
            this.btn_Product_Details_List.Size = new System.Drawing.Size(201, 50);
            this.btn_Product_Details_List.TabIndex = 33;
            this.btn_Product_Details_List.Text = "Product Details List";
            this.btn_Product_Details_List.UseVisualStyleBackColor = true;
            this.btn_Product_Details_List.Click += new System.EventHandler(this.btn_Product_Details_List_Click);
            // 
            // View_Distrubutor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 826);
            this.Controls.Add(this.btn_Product_Details_List);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_View_Dist_Info);
            this.Name = "View_Distrubutor_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Distrubutor_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_Distrubutor_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Dist_Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_View_Dist_Details;
        private System.Windows.Forms.DataGridView dgv_View_Dist_Info;
        private System.Windows.Forms.Button btn_Product_Details_List;
    }
}