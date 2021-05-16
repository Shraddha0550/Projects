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
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_New_Product Where Prod_ID = " + tb_Product_ID.Text + "", CF.Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgv_Product_List.DataSource = dt;
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

            CF.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            tb_Product_ID.Text = "";
            int var = 0;
            CF.Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_New_Product Where Prod_ID =" + var + " ", CF.Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Product_List.DataSource = dt;
            CF.Con_Close();
        }

    }
}
