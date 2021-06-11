using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Camera_House
{
    public partial class Product_List : Form
    {
        Connection_File CF = new Connection_File();

        public Product_List()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select *From Dist_Product_List Where Dist_ID = " + tb_ID.Text + " ", CF.Con);
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

        private void Product_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camera_House_DBDataSet.Dist_Product_List' table. You can move, or remove it, as needed.
            this.dist_Product_ListTableAdapter.Fill(this.camera_House_DBDataSet.Dist_Product_List);
            // TODO: This line of code loads data into the 'camera_House_DBDataSet.Dist_Product_List' table. You can move, or remove it, as needed.


        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
