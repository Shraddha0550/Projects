namespace Safeway_FX_Trader
{
    partial class MDIParent
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
            this.btn_View_User = new System.Windows.Forms.Button();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.btn_View_Refer_User = new System.Windows.Forms.Button();
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_nav.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_View_User
            // 
            this.btn_View_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_View_User.Location = new System.Drawing.Point(0, 234);
            this.btn_View_User.Name = "btn_View_User";
            this.btn_View_User.Size = new System.Drawing.Size(367, 59);
            this.btn_View_User.TabIndex = 5;
            this.btn_View_User.Text = "View User";
            this.btn_View_User.UseVisualStyleBackColor = true;
            this.btn_View_User.Click += new System.EventHandler(this.btn_View_User_Click);
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_User.Location = new System.Drawing.Point(0, 179);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(367, 59);
            this.btn_Add_User.TabIndex = 4;
            this.btn_Add_User.Text = "Add User";
            this.btn_Add_User.UseVisualStyleBackColor = true;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // btn_View_Refer_User
            // 
            this.btn_View_Refer_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_View_Refer_User.Location = new System.Drawing.Point(0, 288);
            this.btn_View_Refer_User.Name = "btn_View_Refer_User";
            this.btn_View_Refer_User.Size = new System.Drawing.Size(367, 59);
            this.btn_View_Refer_User.TabIndex = 8;
            this.btn_View_Refer_User.Text = "View Refer User";
            this.btn_View_Refer_User.UseVisualStyleBackColor = true;
            this.btn_View_Refer_User.Click += new System.EventHandler(this.btn_View_Refer_User_Click);
            // 
            // pnl_nav
            // 
            this.pnl_nav.Controls.Add(this.panel1);
            this.pnl_nav.Controls.Add(this.btn_Add_User);
            this.pnl_nav.Controls.Add(this.btn_View_Refer_User);
            this.pnl_nav.Controls.Add(this.btn_View_User);
            this.pnl_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_nav.Location = new System.Drawing.Point(0, 0);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(367, 702);
            this.pnl_nav.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 182);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAFEWAY-FX ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "   TRADER";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 702);
            this.Controls.Add(this.pnl_nav);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_nav.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btn_View_User;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.Button btn_View_Refer_User;
        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}



