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
    public partial class View_Distrubutor_Details : Form
    {
        Connection_File CF = new Connection_File();
        public View_Distrubutor_Details()
        {
            InitializeComponent();
        }

        private void View_Distrubutor_Details_Load(object sender, EventArgs e)
        {
            CF.Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select *From Dist_Details", CF.Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_View_Dist_Info.DataSource = dt;

            CF.Con_Close();
        }

        private void btn_Product_Details_List_Click(object sender, EventArgs e)
        {
            Product_List obj = new Product_List();
            obj.Show();
        }
    }
}
