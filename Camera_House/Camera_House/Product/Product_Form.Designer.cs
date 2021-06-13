namespace Camera_House
{
    partial class Product_Form
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
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.lb_Distrubutor_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Dist_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Location = new System.Drawing.Point(106, 227);
            this.dgv_Product_List.Name = "dgv_Product_List";
            this.dgv_Product_List.RowTemplate.Height = 24;
            this.dgv_Product_List.Size = new System.Drawing.Size(819, 395);
            this.dgv_Product_List.TabIndex = 0;
            // 
            // lb_Distrubutor_ID
            // 
            this.lb_Distrubutor_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Distrubutor_ID.AutoSize = true;
            this.lb_Distrubutor_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Distrubutor_ID.Location = new System.Drawing.Point(135, 137);
            this.lb_Distrubutor_ID.Name = "lb_Distrubutor_ID";
            this.lb_Distrubutor_ID.Size = new System.Drawing.Size(188, 32);
            this.lb_Distrubutor_ID.TabIndex = 3;
            this.lb_Distrubutor_ID.Text = "Distrubutor ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(718, 124);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 58);
            this.btn_Search.TabIndex = 31;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Dist_ID
            // 
            this.tb_Dist_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Dist_ID.Location = new System.Drawing.Point(351, 137);
            this.tb_Dist_ID.Name = "tb_Dist_ID";
            this.tb_Dist_ID.Size = new System.Drawing.Size(299, 38);
            this.tb_Dist_ID.TabIndex = 32;
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 709);
            this.Controls.Add(this.tb_Dist_ID);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lb_Distrubutor_ID);
            this.Controls.Add(this.dgv_Product_List);
            this.Name = "Product_Form";
            this.Text = "Product_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Product_List;
        private System.Windows.Forms.Label lb_Distrubutor_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Dist_ID;
    }
}