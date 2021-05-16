namespace Camera_House
{
    partial class View_All_Stocks
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
            this.dgv_All_Product = new System.Windows.Forms.DataGridView();
            this.lb_View_All_Product = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Product)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_All_Product
            // 
            this.dgv_All_Product.AllowUserToAddRows = false;
            this.dgv_All_Product.AllowUserToDeleteRows = false;
            this.dgv_All_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_All_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_All_Product.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_All_Product.Location = new System.Drawing.Point(53, 156);
            this.dgv_All_Product.Name = "dgv_All_Product";
            this.dgv_All_Product.ReadOnly = true;
            this.dgv_All_Product.RowTemplate.Height = 24;
            this.dgv_All_Product.Size = new System.Drawing.Size(1766, 622);
            this.dgv_All_Product.TabIndex = 33;
            // 
            // lb_View_All_Product
            // 
            this.lb_View_All_Product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_View_All_Product.AutoSize = true;
            this.lb_View_All_Product.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_View_All_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_View_All_Product.Location = new System.Drawing.Point(651, 38);
            this.lb_View_All_Product.Name = "lb_View_All_Product";
            this.lb_View_All_Product.Size = new System.Drawing.Size(303, 41);
            this.lb_View_All_Product.TabIndex = 32;
            this.lb_View_All_Product.Text = "View All Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_View_All_Product);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 103);
            this.panel1.TabIndex = 34;
            // 
            // View_All_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1902, 826);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_All_Product);
            this.Name = "View_All_Product";
            this.Text = "View_All_Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_All_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Product)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_All_Product;
        private System.Windows.Forms.Label lb_View_All_Product;
        private System.Windows.Forms.Panel panel1;
    }
}