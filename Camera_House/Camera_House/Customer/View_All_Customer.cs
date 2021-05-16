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
    public partial class View_All_Customer : Form
    {
        Connection_File CF = new Connection_File();
        public View_All_Customer()
        {
            InitializeComponent();
        }

        private void View_All_Customer_Load(object sender, EventArgs e)
        {
            CF.Con_Open();

           // SqlDataAdapter sda = new SqlDataAdapter("Select Cust_Payment.Cust_ID,Cust_Payment.Name,Cust_Payment.Mob_No,Cust_Camera_Details.Date,Cust_Camera_Details.Company_Name,Cust_Camera_Details.Model_Name,Cust_Camera_Details.Price,Cust_Camera_Details.Quantity,Cust_Camera_Details.GST,Cust_Camera_Details.Total,Cust_Payment.Bill,Cust_Payment.Discount,Cust_Payment.Total_Bill From Cust_Camera_Details INNER JOIN Cust_Payment ON Cust_Camera_Details.Cust_ID = Cust_Payment.Cust_ID ", CF.Con);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Cust_Payment", CF.Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Customer_List.DataSource = dt;

            CF.Con_Close();
        }
    }
}
