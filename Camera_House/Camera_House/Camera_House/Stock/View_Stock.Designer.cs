namespace Camera_House
{
    partial class View_Stock
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
            this.dgv_Stocks = new System.Windows.Forms.DataGridView();
            this.lb_Add_Stock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stocks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Stocks
            // 
            this.dgv_Stocks.AllowUserToAddRows = false;
            this.dgv_Stocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stocks.Location = new System.Drawing.Point(85, 240);
            this.dgv_Stocks.Name = "dgv_Stocks";
            this.dgv_Stocks.RowTemplate.Height = 24;
            this.dgv_Stocks.Size = new System.Drawing.Size(1228, 518);
            this.dgv_Stocks.TabIndex = 0;
            // 
            // lb_Add_Stock
            // 
            this.lb_Add_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Add_Stock.AutoSize = true;
            this.lb_Add_Stock.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add_Stock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Add_Stock.Location = new System.Drawing.Point(382, 112);
            this.lb_Add_Stock.Name = "lb_Add_Stock";
            this.lb_Add_Stock.Size = new System.Drawing.Size(554, 45);
            this.lb_Add_Stock.TabIndex = 45;
            this.lb_Add_Stock.Text = "View All Stocks Added Details";
            // 
            // View_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 826);
            this.Controls.Add(this.lb_Add_Stock);
            this.Controls.Add(this.dgv_Stocks);
            this.Name = "View_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Stocks;
        private System.Windows.Forms.Label lb_Add_Stock;
    }
}