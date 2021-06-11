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
    public partial class Search_Customer : Form
    {
        Connection_File CF = new Connection_File();
        public Search_Customer()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            try
            {
                int var = Convert.ToInt32(tb_Customer_ID.Text);

                if (tb_Customer_ID.Text != "")
                {
                    if (var <= 1000)
                    {
                        MessageBox.Show("Invalid ID");
                        tb_Customer_ID.Clear();
                    }
                    else
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("Select Cust_Camera_Details.Cust_ID,Cust_Payment.Name,Cust_Payment.Mob_No,Cust_Payment.Address,Cust_Camera_Details.Date,Cust_Camera_Details.Company_Name,Cust_Camera_Details.Model_Name,Cust_Camera_Details.Price,Cust_Camera_Details.Stock,Cust_Camera_Details.GST,Cust_Camera_Details.Total,Cust_Payment.Bill,Cust_Payment.Discount,Cust_Payment.Total_Bill From Cust_Camera_Details INNER JOIN Cust_Payment ON Cust_Camera_Details.Cust_ID = Cust_Payment.Cust_ID Where Cust_Camera_Details.Cust_ID = " + tb_Customer_ID.Text + " ", CF.Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dgv_Customer_List.DataSource = dt;
                    }

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

        private void btn_Clear_Click(object sender, EventArgs e)
        { 
            CF.Con_Open();
            try
            {
                tb_Customer_ID.Text = "";
                SqlDataAdapter sda = new SqlDataAdapter("Select Cust_Camera_Details.Cust_ID,Cust_Payment.Name,Cust_Payment.Mob_No,Cust_Payment.Address,Cust_Camera_Details.Date,Cust_Camera_Details.Company_Name,Cust_Camera_Details.Model_Name,Cust_Camera_Details.Price,Cust_Camera_Details.Stock,Cust_Camera_Details.GST,Cust_Camera_Details.Total,Cust_Payment.Bill,Cust_Payment.Discount,Cust_Payment.Total_Bill From Cust_Camera_Details INNER JOIN Cust_Payment ON Cust_Camera_Details.Cust_ID = Cust_Payment.Cust_ID Where Cust_Camera_Details.Cust_ID = " + tb_Customer_ID.Text + " ", CF.Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgv_Customer_List.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
           
            CF.Con_Close();
        }

        private void tb_Customer_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
