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
    public partial class Remove_Employee : Form
    {
        Connection_File CF = new Connection_File();
        public Remove_Employee()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            try
            {
                if (tb_Employee_ID.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select *From Add_New_Employee Where Emp_ID = '" + tb_Employee_ID.Text + "' ", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgv_Employee_List.DataSource = dt;
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            try
            {
                if (tb_Employee_ID.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Delete From Add_New_Employee Where Emp_ID = '" + tb_Employee_ID.Text + "'", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);


                    MessageBox.Show("Employee Deleted Successfully!! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID ", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            tb_Employee_ID.Text = "";
            String var = "0";
            CF.Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_New_Employee Where Emp_ID ='" + var + "' ", CF.Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Employee_List.DataSource = dt;
            CF.Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {

        }
    }
}
