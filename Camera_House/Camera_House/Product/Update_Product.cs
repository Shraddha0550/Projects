using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Camera_House
{
    public partial class Update_Product : Form
    {
        Connection_File CF = new Connection_File();
        public Update_Product()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            if(tb_Prod_ID.Text != "")
            {
                int val = Convert.ToInt32(tb_Prod_ID.Text);
                if (val <= 100)
                {
                    MessageBox.Show("Invalid ID");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Select * From Add_New_Product Where Prod_ID = " + tb_Prod_ID.Text + "", CF.Con);
                    var obj = cmd.ExecuteReader();

                    if (obj.Read())
                    {
                        tb_Purches_Price.Text = obj["Purches_Price"].ToString();
                        tb_Description.Text = obj.GetString(obj.GetOrdinal("Discription"));
                        tb_Sale_Price.Text = obj["Sales_Price"].ToString();
                        tb_Company_Name.Text = obj.GetString(obj.GetOrdinal("Company_Name"));
                        tb_Model_Name.Text = obj.GetString(obj.GetOrdinal("Model_Name"));


                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }

          

            CF.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            tb_Company_Name.Clear();
            tb_Description.Clear();
            tb_Model_Name.Clear();
            tb_Prod_ID.Clear();
            tb_Purches_Price.Clear();
            tb_Sale_Price.Clear();
            tb_Prod_ID.Focus();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            if (tb_Prod_ID.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Update Add_New_Product Set Purches_Price = " + tb_Purches_Price.Text + ",Sales_Price = " + tb_Sale_Price.Text + ", Discription = '" + tb_Description.Text + "' Where Prod_ID = " + tb_Prod_ID.Text + " ", CF.Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                MessageBox.Show("SuccessFully Updated !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();

            }
            else
            {
                MessageBox.Show("Invalid ID");
            }

            CF.Con_Close();

        }

        private void Update_Product_Load(object sender, EventArgs e)
        {
            tb_Prod_ID.Focus();
        }
    }
}
