using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lodging_Managment_System
{
    public partial class View_All_Customer : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\EXPRESS;Initial Catalog=Lodging_Managment_System_DB;Integrated Security=True");

        public View_All_Customer()
        {
            InitializeComponent();
        }

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void btn_Search_Customer_Click(object sender, EventArgs e)
        {
            Search_Customer obj = new Search_Customer();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_All_Customer_Load(object sender, EventArgs e)
        {
            Con.Open();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Cust_Personal_Info.Cust_ID,Cust_Personal_Info.Name,Cust_Personal_Info.Booking_Date,Cust_Personal_Info.Mobile_Number,Cust_Personal_Info.Alternate_Mob_No,Cust_Personal_Info.Email,Cust_Personal_Info.DOB,Cust_Personal_Info.Address,Cust_Personal_Info.AdharCard_No,Cust_Personal_Info.PAN_No,Cust_Booking_Room_Info.Room_No,Cust_Booking_Room_Info.Check_In_Date,Cust_Booking_Room_Info.Check_Out_Date,Cust_Booking_Room_Info.Room_Type,Cust_Booking_Room_Info.Bed_Type,Cust_Booking_Room_Info.Day,Cust_Booking_Room_Info.Hrs,Cust_Booking_Room_Info.Total,Pay_Amount.Room_Bill,Pay_Amount.Discount,Pay_Amount.Total,Pay_Amount.Pay,Pay_Amount.Remaining From Cust_Personal_Info INNER JOIN Cust_Booking_Room_Info ON Cust_Personal_Info.Cust_ID = Cust_Booking_Room_Info.Cust_ID INNER JOIN Pay_Amount ON Cust_Personal_Info.Cust_ID = Pay_Amount.Cust_ID ", Con);
                DataTable dt = new DataTable();


                sda.Fill(dt);

                dgv_Data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }


            Con_Close();
        }
    }
}
