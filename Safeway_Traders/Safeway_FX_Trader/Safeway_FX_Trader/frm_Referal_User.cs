using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safeway_FX_Trader
{
    public partial class frm_Referal_User : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\express;Initial Catalog=Safeway_FX_Trader_db;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        public frm_Referal_User()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select *From Add_User where Refer_ID = " + tb_Refer_ID.Text + " ", Con);

            DataTable dt = new DataTable();

            dgv_All_Users.DataSource = dt;

            sda.Fill(dt);

            Con.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if(tb_Refer_ID.Text != "")
            {
                DialogResult Res = MessageBox.Show("You Want To Refresh Information", "Are You sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Res == DialogResult.Yes)
                {
                    tb_Refer_ID.Clear();

                    Con.Open();

                    int val = 0;

                    SqlDataAdapter sda = new SqlDataAdapter("Select *From Add_User where Refer_ID = " + val + " ", Con);

                    DataTable dt = new DataTable();

                    dgv_All_Users.DataSource = dt;

                    sda.Fill(dt);

                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
          
        }

        private void Only_Num(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
