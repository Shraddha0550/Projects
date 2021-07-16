namespace Safeway_FX_Trader
{
    partial class frm_Twenty_Per_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_View_User = new System.Windows.Forms.Label();
            this.dgv_twentyCommUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_twentyCommUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_View_User
            // 
            this.lb_View_User.AutoSize = true;
            this.lb_View_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_View_User.Location = new System.Drawing.Point(411, 43);
            this.lb_View_User.Name = "lb_View_User";
            this.lb_View_User.Size = new System.Drawing.Size(442, 38);
            this.lb_View_User.TabIndex = 17;
            this.lb_View_User.Text = "20 Percentage Commission";
            // 
            // dgv_twentyCommUser
            // 
            this.dgv_twentyCommUser.AllowUserToAddRows = false;
            this.dgv_twentyCommUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_twentyCommUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_twentyCommUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_twentyCommUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_twentyCommUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_twentyCommUser.Location = new System.Drawing.Point(47, 245);
            this.dgv_twentyCommUser.Name = "dgv_twentyCommUser";
            this.dgv_twentyCommUser.RowTemplate.Height = 24;
            this.dgv_twentyCommUser.Size = new System.Drawing.Size(1158, 450);
            this.dgv_twentyCommUser.TabIndex = 16;
            // 
            // frm_Twenty_Per_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 738);
            this.Controls.Add(this.lb_View_User);
            this.Controls.Add(this.dgv_twentyCommUser);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frm_Twenty_Per_User";
            this.Text = "20 Per User";
            this.Load += new System.EventHandler(this.frm_Twenty_Per_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_twentyCommUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_View_User;
        private System.Windows.Forms.DataGridView dgv_twentyCommUser;
    }
}