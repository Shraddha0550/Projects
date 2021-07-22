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
    public partial class Remove_Product : Form
    {
        Connection_File CF = new Connection_File();
        public Remove_Product()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            

            if (tb_Product_ID.Text != "")
            {
                int val = Convert.ToInt32(tb_Product_ID.Text);
                if (val <= 100)
                {
                    MessageBox.Show("Invalid ID");
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_New_Product Where Prod_ID = " + tb_Product_ID.Text + "", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgv_Product_List.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }

            CF.Con_Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CF.Con_Open();
            try
            {
                if (tb_Product_ID.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Delete From Add_New_Product Where Prod_ID = " + tb_Product_ID.Text + "", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("Product Is Deleted..");
                    refresh();

                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
           

            CF.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            CF.Con_Open();
            try
            {
                tb_Product_ID.Text = "";
                int var = 0;
              
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_New_Product Where Prod_ID =" + var + " ", CF.Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgv_Product_List.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
         
            CF.Con_Close();
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
