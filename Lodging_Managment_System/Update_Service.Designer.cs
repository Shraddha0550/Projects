namespace Lodging_Managment_System
{
    partial class Update_Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Date = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.rServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lodging_Managment_System_DBDataSet16 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet16();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.r_ServiceTableAdapter = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet16TableAdapters.R_ServiceTableAdapter();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cust_ID = new System.Windows.Forms.Label();
            this.tb_Cust_ID = new System.Windows.Forms.TextBox();
            this.dgv_Service = new System.Windows.Forms.DataGridView();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rServiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lodging_Managment_System_DBDataSet23 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet23();
            this.lb_Charge = new System.Windows.Forms.Label();
            this.tb_Charge = new System.Windows.Forms.TextBox();
            this.lb_Service = new System.Windows.Forms.Label();
            this.tb_Service = new System.Windows.Forms.TextBox();
            this.r_ServiceTableAdapter1 = new Lodging_Managment_System.Lodging_Managment_System_DBDataSet23TableAdapters.R_ServiceTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet16)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rServiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet23)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Date
            // 
            this.dtp_Date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(778, 9);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(227, 34);
            this.dtp_Date.TabIndex = 17;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(115, 55);
            this.btn_Back.TabIndex = 32;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.03257F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.96743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 287F));
            this.tableLayoutPanel1.Controls.Add(this.dtp_Date, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Date, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 53);
            this.tableLayoutPanel1.TabIndex = 91;
            // 
            // lb_Date
            // 
            this.lb_Date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(654, 12);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(63, 29);
            this.lb_Date.TabIndex = 16;
            this.lb_Date.Text = "Date";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.bt_Update, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 512);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1005, 91);
            this.tableLayoutPanel3.TabIndex = 92;
            // 
            // bt_Update
            // 
            this.bt_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Update.BackColor = System.Drawing.SystemColors.Desktop;
            this.bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Update.Location = new System.Drawing.Point(412, 14);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(181, 62);
            this.bt_Update.TabIndex = 5;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = false;
            this.bt_Update.Click += new System.EventHandler(this.bt_Update_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(591, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(181, 50);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // rServiceBindingSource
            // 
            this.rServiceBindingSource.DataMember = "R_Service";
            this.rServiceBindingSource.DataSource = this.lodging_Managment_System_DBDataSet16;
            // 
            // lodging_Managment_System_DBDataSet16
            // 
            this.lodging_Managment_System_DBDataSet16.DataSetName = "Lodging_Managment_System_DBDataSet16";
            this.lodging_Managment_System_DBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 55);
            this.panel1.TabIndex = 94;
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
            this.button1.Location = new System.Drawing.Point(993, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 55);
            this.button1.TabIndex = 84;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 23);
            this.panel2.TabIndex = 93;
            // 
            // r_ServiceTableAdapter
            // 
            this.r_ServiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.89706F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.57353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.73039F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.79902F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Search, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cust_ID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cust_ID, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 141);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.58396F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1005, 62);
            this.tableLayoutPanel2.TabIndex = 90;
            // 
            // lb_Cust_ID
            // 
            this.lb_Cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Cust_ID.AutoSize = true;
            this.lb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cust_ID.Location = new System.Drawing.Point(7, 0);
            this.lb_Cust_ID.Name = "lb_Cust_ID";
            this.lb_Cust_ID.Size = new System.Drawing.Size(187, 29);
            this.lb_Cust_ID.TabIndex = 12;
            this.lb_Cust_ID.Text = "Cust_ID                ";
            // 
            // tb_Cust_ID
            // 
            this.tb_Cust_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cust_ID.Location = new System.Drawing.Point(200, 3);
            this.tb_Cust_ID.Name = "tb_Cust_ID";
            this.tb_Cust_ID.Size = new System.Drawing.Size(222, 34);
            this.tb_Cust_ID.TabIndex = 13;
            // 
            // dgv_Service
            // 
            this.dgv_Service.AllowUserToAddRows = false;
            this.dgv_Service.AllowUserToDeleteRows = false;
            this.dgv_Service.AutoGenerateColumns = false;
            this.dgv_Service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Service.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.chargeDataGridViewTextBoxColumn});
            this.dgv_Service.DataSource = this.rServiceBindingSource1;
            this.dgv_Service.Location = new System.Drawing.Point(3, 209);
            this.dgv_Service.Name = "dgv_Service";
            this.dgv_Service.ReadOnly = true;
            this.dgv_Service.RowTemplate.Height = 24;
            this.dgv_Service.Size = new System.Drawing.Size(1005, 229);
            this.dgv_Service.TabIndex = 95;
            this.dgv_Service.SelectionChanged += new System.EventHandler(this.dgv_Service_SelectionChanged);
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chargeDataGridViewTextBoxColumn
            // 
            this.chargeDataGridViewTextBoxColumn.DataPropertyName = "Charge";
            this.chargeDataGridViewTextBoxColumn.HeaderText = "Charge";
            this.chargeDataGridViewTextBoxColumn.Name = "chargeDataGridViewTextBoxColumn";
            this.chargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rServiceBindingSource1
            // 
            this.rServiceBindingSource1.DataMember = "R_Service";
            this.rServiceBindingSource1.DataSource = this.lodging_Managment_System_DBDataSet23;
            // 
            // lodging_Managment_System_DBDataSet23
            // 
            this.lodging_Managment_System_DBDataSet23.DataSetName = "Lodging_Managment_System_DBDataSet23";
            this.lodging_Managment_System_DBDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_Charge
            // 
            this.lb_Charge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Charge.AutoSize = true;
            this.lb_Charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Charge.Location = new System.Drawing.Point(452, 459);
            this.lb_Charge.Name = "lb_Charge";
            this.lb_Charge.Size = new System.Drawing.Size(92, 29);
            this.lb_Charge.TabIndex = 98;
            this.lb_Charge.Text = "Charge";
            // 
            // tb_Charge
            // 
            this.tb_Charge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Charge.Location = new System.Drawing.Point(590, 459);
            this.tb_Charge.Name = "tb_Charge";
            this.tb_Charge.Size = new System.Drawing.Size(235, 34);
            this.tb_Charge.TabIndex = 96;
            // 
            // lb_Service
            // 
            this.lb_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Service.AutoSize = true;
            this.lb_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Service.Location = new System.Drawing.Point(12, 459);
            this.lb_Service.Name = "lb_Service";
            this.lb_Service.Size = new System.Drawing.Size(136, 29);
            this.lb_Service.TabIndex = 97;
            this.lb_Service.Text = "Service       ";
            // 
            // tb_Service
            // 
            this.tb_Service.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Service.Location = new System.Drawing.Point(124, 459);
            this.tb_Service.Name = "tb_Service";
            this.tb_Service.Size = new System.Drawing.Size(235, 34);
            this.tb_Service.TabIndex = 99;
            // 
            // r_ServiceTableAdapter1
            // 
            this.r_ServiceTableAdapter1.ClearBeforeFill = true;
            // 
            // Update_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 642);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Service);
            this.Controls.Add(this.lb_Charge);
            this.Controls.Add(this.tb_Charge);
            this.Controls.Add(this.lb_Service);
            this.Controls.Add(this.dgv_Service);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Update_Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Service";
            this.Load += new System.EventHandler(this.Update_Service_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet16)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rServiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lodging_Managment_System_DBDataSet23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.BindingSource rServiceBindingSource;
        private Lodging_Managment_System_DBDataSet16 lodging_Managment_System_DBDataSet16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private Lodging_Managment_System_DBDataSet16TableAdapters.R_ServiceTableAdapter r_ServiceTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_Cust_ID;
        private System.Windows.Forms.Label lb_Cust_ID;
        private System.Windows.Forms.DataGridView dgv_Service;
        private System.Windows.Forms.Label lb_Charge;
        private System.Windows.Forms.TextBox tb_Charge;
        private System.Windows.Forms.Label lb_Service;
        private System.Windows.Forms.TextBox tb_Service;
        private Lodging_Managment_System_DBDataSet23 lodging_Managment_System_DBDataSet23;
        private System.Windows.Forms.BindingSource rServiceBindingSource1;
        private Lodging_Managment_System_DBDataSet23TableAdapters.R_ServiceTableAdapter r_ServiceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeDataGridViewTextBoxColumn;
    }
}