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
    public partial class View_All_Stocks : Form
    {
        Connection_File CF = new Connection_File();
        public View_All_Stocks()
        {
            InitializeComponent();
        }

        private void View_All_Product_Load(object sender, EventArgs e)
        {
            CF.Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_New_Product",CF.Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_All_Product.DataSource = dt;

            CF.Con_Close();
        }

    }
}
