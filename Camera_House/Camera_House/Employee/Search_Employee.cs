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
    public partial class Search_Employee : Form
    {
        Connection_File CF = new Connection_File();
        public Search_Employee()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CF.Con_Open();
            if (tb_Employee_ID.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select *From Add_New_Employee Where Emp_ID = '" + tb_Employee_ID.Text + "' ", CF.Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgv_Employee_List.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Employee ID Not Found", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            CF.Con_Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

            tb_Employee_ID.Text = "";
            String var = "0";
            CF.Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_New_Employee Where Emp_ID ='" + var + "' ", CF.Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Employee_List.DataSource = dt;
            CF.Con_Close();
        }
    }
}
