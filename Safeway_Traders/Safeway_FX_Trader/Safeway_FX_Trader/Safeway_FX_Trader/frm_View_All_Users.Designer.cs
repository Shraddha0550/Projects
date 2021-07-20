namespace Safeway_FX_Trader
{
    partial class frm_View_All_Users
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
            this.dgv_All_Users = new System.Windows.Forms.DataGridView();
            this.lb_View_User = new System.Windows.Forms.Label();
            this.lb_User_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_User_ID = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_All_Users
            // 
            this.dgv_All_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_All_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_All_Users.Location = new System.Drawing.Point(65, 207);
            this.dgv_All_Users.Name = "dgv_All_Users";
            this.dgv_All_Users.RowTemplate.Height = 24;
            this.dgv_All_Users.Size = new System.Drawing.Size(963, 493);
            this.dgv_All_Users.TabIndex = 0;
            // 
            // lb_View_User
            // 
            this.lb_View_User.AutoSize = true;
            this.lb_View_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_View_User.Location = new System.Drawing.Point(438, 31);
            this.lb_View_User.Name = "lb_View_User";
            this.lb_View_User.Size = new System.Drawing.Size(225, 38);
            this.lb_View_User.TabIndex = 3;
            this.lb_View_User.Text = "View All User";
            // 
            // lb_User_ID
            // 
            this.lb_User_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_User_ID.AutoSize = true;
            this.lb_User_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User_ID.Location = new System.Drawing.Point(206, 136);
            this.lb_User_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_User_ID.Name = "lb_User_ID";
            this.lb_User_ID.Size = new System.Drawing.Size(115, 32);
            this.lb_User_ID.TabIndex = 13;
            this.lb_User_ID.Text = "User ID ";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(671, 129);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(169, 44);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_User_ID
            // 
            this.tb_User_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_User_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User_ID.Location = new System.Drawing.Point(346, 133);
            this.tb_User_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_User_ID.Name = "tb_User_ID";
            this.tb_User_ID.Size = new System.Drawing.Size(273, 38);
            this.tb_User_ID.TabIndex = 11;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Refresh.Location = new System.Drawing.Point(859, 129);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(169, 44);
            this.btn_Refresh.TabIndex = 20;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_View_All_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 734);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lb_User_ID);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_User_ID);
            this.Controls.Add(this.lb_View_User);
            this.Controls.Add(this.dgv_All_Users);
            this.Name = "frm_View_All_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_All_Users";
            this.Load += new System.EventHandler(this.frm_View_All_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_All_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_All_Users;
        private System.Windows.Forms.Label lb_View_User;
        private System.Windows.Forms.Label lb_User_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_User_ID;
        private System.Windows.Forms.Button btn_Refresh;
    }
}