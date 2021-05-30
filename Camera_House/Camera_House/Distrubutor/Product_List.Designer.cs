namespace Camera_House
{
    partial class Product_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_View_Product_Items = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_Product_List = new System.Windows.Forms.DataGridView();
            this.camera_House_DBDataSet = new Camera_House.Camera_House_DBDataSet();
            this.distProductListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dist_Product_ListTableAdapter = new Camera_House.Camera_House_DBDataSetTableAdapters.Dist_Product_ListTableAdapter();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camera_House_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distProductListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lb_View_Product_Items);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 103);
            this.panel1.TabIndex = 37;
            // 
            // lb_View_Product_Items
            // 
            this.lb_View_Product_Items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_View_Product_Items.AutoSize = true;
            this.lb_View_Product_Items.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_View_Product_Items.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_View_Product_Items.Location = new System.Drawing.Point(312, 36);
            this.lb_View_Product_Items.Name = "lb_View_Product_Items";
            this.lb_View_Product_Items.Size = new System.Drawing.Size(338, 41);
            this.lb_View_Product_Items.TabIndex = 32;
            this.lb_View_Product_Items.Text = "View Product Items";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(233, 164);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(141, 25);
            this.lb_ID.TabIndex = 38;
            this.lb_ID.Text = "Distrubutor ID :";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(405, 159);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(251, 30);
            this.tb_ID.TabIndex = 39;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(701, 150);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(150, 47);
            this.btn_Search.TabIndex = 40;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_Product_List
            // 
            this.dgv_Product_List.AllowUserToAddRows = false;
            this.dgv_Product_List.AutoGenerateColumns = false;
            this.dgv_Product_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn});
            this.dgv_Product_List.DataSource = this.distProductListBindingSource;
            this.dgv_Product_List.Location = new System.Drawing.Point(213, 260);
            this.dgv_Product_List.Name = "dgv_Product_List";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Product_List.RowTemplate.Height = 24;
            this.dgv_Product_List.Size = new System.Drawing.Size(711, 234);
            this.dgv_Product_List.TabIndex = 41;
            // 
            // camera_House_DBDataSet
            // 
            this.camera_House_DBDataSet.DataSetName = "Camera_House_DBDataSet";
            this.camera_House_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // distProductListBindingSource
            // 
            this.distProductListBindingSource.DataMember = "Dist_Product_List";
            this.distProductListBindingSource.DataSource = this.camera_House_DBDataSet;
            // 
            // dist_Product_ListTableAdapter
            // 
            this.dist_Product_ListTableAdapter.ClearBeforeFill = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "Company_Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company_Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "Model_Name";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Model_Name";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 548);
            this.Controls.Add(this.dgv_Product_List);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.panel1);
            this.Name = "Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_List";
            this.Load += new System.EventHandler(this.Product_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camera_House_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distProductListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_View_Product_Items;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_Product_List;
        private Camera_House_DBDataSet camera_House_DBDataSet;
        private System.Windows.Forms.BindingSource distProductListBindingSource;
        private Camera_House_DBDataSetTableAdapters.Dist_Product_ListTableAdapter dist_Product_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
    }
}