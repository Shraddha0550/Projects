namespace Camera_House
{
    partial class Update_Employee
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
            this.lb_Update_Employee = new System.Windows.Forms.Label();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lb_Employee_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.lb_Salary = new System.Windows.Forms.Label();
            this.tb_Pan_Card_No = new System.Windows.Forms.TextBox();
            this.lb_Pan_Card_No = new System.Windows.Forms.Label();
            this.tb_Adhar_Card_No = new System.Windows.Forms.TextBox();
            this.lb_Adhar_Card_No = new System.Windows.Forms.Label();
            this.lb_Hire_Date = new System.Windows.Forms.Label();
            this.dtp_Hire_Date = new System.Windows.Forms.DateTimePicker();
            this.lb_Account_No = new System.Windows.Forms.Label();
            this.tb_Account_No = new System.Windows.Forms.TextBox();
            this.lb_Email_ID = new System.Windows.Forms.Label();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.lb_IFC_Code = new System.Windows.Forms.Label();
            this.tb_IFC_Code = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.lb_DOB = new System.Windows.Forms.Label();
            this.lb_Mobile_No = new System.Windows.Forms.Label();
            this.lb_Alternate_Mob_No = new System.Windows.Forms.Label();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Alt_Mob_No = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Update_Employee
            // 
            this.lb_Update_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Update_Employee.AutoSize = true;
            this.lb_Update_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Update_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Update_Employee.Location = new System.Drawing.Point(682, 39);
            this.lb_Update_Employee.Name = "lb_Update_Employee";
            this.lb_Update_Employee.Size = new System.Drawing.Size(337, 46);
            this.lb_Update_Employee.TabIndex = 22;
            this.lb_Update_Employee.Text = "Update Employee";
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Employee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(357, 3);
            this.tb_Employee_ID.MaxLength = 20;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(348, 30);
            this.tb_Employee_ID.TabIndex = 26;
            this.tb_Employee_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lb_Employee_ID
            // 
            this.lb_Employee_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Employee_ID.AutoSize = true;
            this.lb_Employee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Employee_ID.Location = new System.Drawing.Point(200, 0);
            this.lb_Employee_ID.Name = "lb_Employee_ID";
            this.lb_Employee_ID.Size = new System.Drawing.Size(151, 29);
            this.lb_Employee_ID.TabIndex = 27;
            this.lb_Employee_ID.Text = "Employee ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(809, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(152, 52);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Update, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Refresh, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(197, 718);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1102, 79);
            this.tableLayoutPanel3.TabIndex = 50;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(191, 12);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(169, 54);
            this.btn_Update.TabIndex = 43;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(742, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(169, 54);
            this.btn_Refresh.TabIndex = 42;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.lb_Employee_ID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_Employee_ID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Search, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(197, 141);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1062, 76);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Salary, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Salary, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Pan_Card_No, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Pan_Card_No, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Adhar_Card_No, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Adhar_Card_No, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Hire_Date, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_Hire_Date, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Account_No, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Account_No, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_Email_ID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Email_ID, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_IFC_Code, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_IFC_Code, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Address, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Address, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Gender, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gb_Gender, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_DOB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Mobile_No, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Alternate_Mob_No, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtp_DOB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Mobile_No, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Alt_Mob_No, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(197, 242);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.36482F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.7931F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1494, 453);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(1122, 263);
            this.tb_Salary.MaxLength = 5;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(369, 30);
            this.tb_Salary.TabIndex = 25;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lb_Salary
            // 
            this.lb_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Salary.AutoSize = true;
            this.lb_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Salary.Location = new System.Drawing.Point(952, 260);
            this.lb_Salary.Name = "lb_Salary";
            this.lb_Salary.Size = new System.Drawing.Size(164, 29);
            this.lb_Salary.TabIndex = 24;
            this.lb_Salary.Text = "Salary              ";
            // 
            // tb_Pan_Card_No
            // 
            this.tb_Pan_Card_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Pan_Card_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pan_Card_No.Location = new System.Drawing.Point(1122, 198);
            this.tb_Pan_Card_No.MaxLength = 10;
            this.tb_Pan_Card_No.Name = "tb_Pan_Card_No";
            this.tb_Pan_Card_No.Size = new System.Drawing.Size(369, 30);
            this.tb_Pan_Card_No.TabIndex = 23;
            this.tb_Pan_Card_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_AlphNumeric);
            // 
            // lb_Pan_Card_No
            // 
            this.lb_Pan_Card_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Pan_Card_No.AutoSize = true;
            this.lb_Pan_Card_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pan_Card_No.Location = new System.Drawing.Point(947, 195);
            this.lb_Pan_Card_No.Name = "lb_Pan_Card_No";
            this.lb_Pan_Card_No.Size = new System.Drawing.Size(169, 29);
            this.lb_Pan_Card_No.TabIndex = 22;
            this.lb_Pan_Card_No.Text = "Pan Card No   ";
            // 
            // tb_Adhar_Card_No
            // 
            this.tb_Adhar_Card_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Adhar_Card_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhar_Card_No.Location = new System.Drawing.Point(1122, 133);
            this.tb_Adhar_Card_No.MaxLength = 12;
            this.tb_Adhar_Card_No.Name = "tb_Adhar_Card_No";
            this.tb_Adhar_Card_No.Size = new System.Drawing.Size(369, 30);
            this.tb_Adhar_Card_No.TabIndex = 21;
            this.tb_Adhar_Card_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lb_Adhar_Card_No
            // 
            this.lb_Adhar_Card_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Adhar_Card_No.AutoSize = true;
            this.lb_Adhar_Card_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Adhar_Card_No.Location = new System.Drawing.Point(944, 130);
            this.lb_Adhar_Card_No.Name = "lb_Adhar_Card_No";
            this.lb_Adhar_Card_No.Size = new System.Drawing.Size(172, 29);
            this.lb_Adhar_Card_No.TabIndex = 20;
            this.lb_Adhar_Card_No.Text = "Adhar Card No";
            // 
            // lb_Hire_Date
            // 
            this.lb_Hire_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Hire_Date.AutoSize = true;
            this.lb_Hire_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hire_Date.Location = new System.Drawing.Point(948, 0);
            this.lb_Hire_Date.Name = "lb_Hire_Date";
            this.lb_Hire_Date.Size = new System.Drawing.Size(168, 29);
            this.lb_Hire_Date.TabIndex = 16;
            this.lb_Hire_Date.Text = "Hire Date         ";
            // 
            // dtp_Hire_Date
            // 
            this.dtp_Hire_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Hire_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Hire_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Hire_Date.Location = new System.Drawing.Point(1122, 3);
            this.dtp_Hire_Date.Name = "dtp_Hire_Date";
            this.dtp_Hire_Date.Size = new System.Drawing.Size(369, 30);
            this.dtp_Hire_Date.TabIndex = 17;
            // 
            // lb_Account_No
            // 
            this.lb_Account_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Account_No.AutoSize = true;
            this.lb_Account_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Account_No.Location = new System.Drawing.Point(948, 325);
            this.lb_Account_No.Name = "lb_Account_No";
            this.lb_Account_No.Size = new System.Drawing.Size(168, 29);
            this.lb_Account_No.TabIndex = 30;
            this.lb_Account_No.Text = "Bank Acc No   ";
            // 
            // tb_Account_No
            // 
            this.tb_Account_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Account_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account_No.Location = new System.Drawing.Point(1122, 328);
            this.tb_Account_No.Name = "tb_Account_No";
            this.tb_Account_No.Size = new System.Drawing.Size(369, 30);
            this.tb_Account_No.TabIndex = 31;
            this.tb_Account_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_AlphNumeric);
            // 
            // lb_Email_ID
            // 
            this.lb_Email_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Email_ID.AutoSize = true;
            this.lb_Email_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email_ID.Location = new System.Drawing.Point(947, 65);
            this.lb_Email_ID.Name = "lb_Email_ID";
            this.lb_Email_ID.Size = new System.Drawing.Size(169, 29);
            this.lb_Email_ID.TabIndex = 12;
            this.lb_Email_ID.Text = "Email ID           ";
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Email_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(1122, 68);
            this.tb_Email_ID.MaxLength = 30;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(369, 30);
            this.tb_Email_ID.TabIndex = 13;
            // 
            // lb_IFC_Code
            // 
            this.lb_IFC_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_IFC_Code.AutoSize = true;
            this.lb_IFC_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IFC_Code.Location = new System.Drawing.Point(952, 390);
            this.lb_IFC_Code.Name = "lb_IFC_Code";
            this.lb_IFC_Code.Size = new System.Drawing.Size(164, 29);
            this.lb_IFC_Code.TabIndex = 34;
            this.lb_IFC_Code.Text = "IFC Code        ";
            // 
            // tb_IFC_Code
            // 
            this.tb_IFC_Code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_IFC_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IFC_Code.Location = new System.Drawing.Point(1122, 393);
            this.tb_IFC_Code.Name = "tb_IFC_Code";
            this.tb_IFC_Code.Size = new System.Drawing.Size(369, 30);
            this.tb_IFC_Code.TabIndex = 35;
            this.tb_IFC_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_AlphNumeric);
            // 
            // lb_Name
            // 
            this.lb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(226, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(144, 29);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Name           ";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(376, 3);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(367, 30);
            this.tb_Name.TabIndex = 3;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // lb_Address
            // 
            this.lb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(232, 65);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(138, 29);
            this.lb_Address.TabIndex = 10;
            this.lb_Address.Text = "Address      ";
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(376, 68);
            this.tb_Address.MaxLength = 70;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(367, 30);
            this.tb_Address.TabIndex = 11;
            this.tb_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // lb_Gender
            // 
            this.lb_Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(234, 130);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(136, 29);
            this.lb_Gender.TabIndex = 9;
            this.lb_Gender.Text = "Gender       ";
            // 
            // gb_Gender
            // 
            this.gb_Gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(376, 133);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(367, 58);
            this.gb_Gender.TabIndex = 29;
            this.gb_Gender.TabStop = false;
            // 
            // rb_Female
            // 
            this.rb_Female.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(187, 10);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(98, 29);
            this.rb_Female.TabIndex = 8;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female\r\n";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(26, 10);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(76, 29);
            this.rb_Male.TabIndex = 7;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // lb_DOB
            // 
            this.lb_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DOB.AutoSize = true;
            this.lb_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DOB.Location = new System.Drawing.Point(233, 195);
            this.lb_DOB.Name = "lb_DOB";
            this.lb_DOB.Size = new System.Drawing.Size(137, 29);
            this.lb_DOB.TabIndex = 6;
            this.lb_DOB.Text = "DOB            ";
            // 
            // lb_Mobile_No
            // 
            this.lb_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Mobile_No.AutoSize = true;
            this.lb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mobile_No.Location = new System.Drawing.Point(233, 260);
            this.lb_Mobile_No.Name = "lb_Mobile_No";
            this.lb_Mobile_No.Size = new System.Drawing.Size(137, 29);
            this.lb_Mobile_No.TabIndex = 18;
            this.lb_Mobile_No.Text = "Mobile No  ";
            // 
            // lb_Alternate_Mob_No
            // 
            this.lb_Alternate_Mob_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Alternate_Mob_No.AutoSize = true;
            this.lb_Alternate_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Alternate_Mob_No.Location = new System.Drawing.Point(238, 325);
            this.lb_Alternate_Mob_No.Name = "lb_Alternate_Mob_No";
            this.lb_Alternate_Mob_No.Size = new System.Drawing.Size(132, 29);
            this.lb_Alternate_Mob_No.TabIndex = 32;
            this.lb_Alternate_Mob_No.Text = "Alt Mob No";
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(376, 198);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(367, 30);
            this.dtp_DOB.TabIndex = 5;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(376, 263);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(367, 30);
            this.tb_Mobile_No.TabIndex = 19;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Alt_Mob_No
            // 
            this.tb_Alt_Mob_No.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Alt_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alt_Mob_No.Location = new System.Drawing.Point(376, 328);
            this.tb_Alt_Mob_No.MaxLength = 10;
            this.tb_Alt_Mob_No.Name = "tb_Alt_Mob_No";
            this.tb_Alt_Mob_No.Size = new System.Drawing.Size(367, 30);
            this.tb_Alt_Mob_No.TabIndex = 33;
            this.tb_Alt_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // Update_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 826);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.lb_Update_Employee);
            this.Name = "Update_Employee";
            this.Text = "Update_Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Update_Employee;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lb_Employee_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Label lb_Salary;
        private System.Windows.Forms.TextBox tb_Pan_Card_No;
        private System.Windows.Forms.Label lb_Pan_Card_No;
        private System.Windows.Forms.TextBox tb_Adhar_Card_No;
        private System.Windows.Forms.Label lb_Adhar_Card_No;
        private System.Windows.Forms.Label lb_Hire_Date;
        private System.Windows.Forms.DateTimePicker dtp_Hire_Date;
        private System.Windows.Forms.Label lb_Account_No;
        private System.Windows.Forms.TextBox tb_Account_No;
        private System.Windows.Forms.Label lb_Email_ID;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.Label lb_IFC_Code;
        private System.Windows.Forms.TextBox tb_IFC_Code;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label lb_DOB;
        private System.Windows.Forms.Label lb_Mobile_No;
        private System.Windows.Forms.Label lb_Alternate_Mob_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Alt_Mob_No;
    }
}