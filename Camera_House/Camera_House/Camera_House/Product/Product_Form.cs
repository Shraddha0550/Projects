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
    public partial class Product_Form : Form
    {
        Connection_File CF = new Connection_File();
        public Product_Form()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select *From Dist_Product_List Where Dist_ID = '" + tb_Dist_ID.Text + "' ", CF.Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Product_List.DataSource = dt;
        }
    }
}
