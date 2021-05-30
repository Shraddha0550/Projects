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
    public partial class Update_Room_Booking_Details : Form
    {
        double Val = 0, pay = 0;
        double Prev_Bill;
        SqlConnection Con = new SqlConnection(@"Data Source=.\EXPRESS;Initial Catalog=Lodging_Managment_System_DB;Integrated Security=True");

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

        public Update_Room_Booking_Details()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Cust_Booking_Room_Info where Cust_ID = " + tb_Cust_ID.Text + " And Room_No = " + cmb_Room_No.Text + "", Con);

            var obj12 = cmd.ExecuteReader();

            if (obj12.Read())
            {
                dtp_Ckeck_In_Date.Text = (obj12["Check_In_Date"].ToString());
                dtp_Check_Out_Date.Text = (obj12["Check_Out_Date"].ToString());
                cb__Room_Type.Text = obj12.GetString(obj12.GetOrdinal("Room_Type"));
                cb_Bed_Type.Text = obj12.GetString(obj12.GetOrdinal("Bed_Type"));
                tb_Day.Text = (obj12["Day"].ToString());
                tb_Hrs.Text = (obj12["Hrs"].ToString());
                tb_Amount.Text = (obj12["Amount"].ToString());
                tb_Total.Text = (obj12["Total"].ToString());

                Prev_Bill = Convert.ToDouble(tb_Total.Text);

            }
            else
            {
                MessageBox.Show("Invaild Roll Number...");
                tb_Cust_ID.Clear();
                tb_Cust_ID.Focus();
            }
            obj12.Close();
            Con_Close();

        }

        private void dtp_Check_Out_Date_ValueChanged(object sender, EventArgs e)
        {

            DateTime date1 = dtp_Ckeck_In_Date.Value.Date;
            DateTime date2 = dtp_Check_Out_Date.Value.Date;

            int Days = ((TimeSpan)(date2 - date1)).Days;

            tb_Day.Text = Days.ToString();
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            tb_Total.Text = (Convert.ToInt32(tb_Day.Text) * Convert.ToDecimal(tb_Amount.Text)).ToString();

            Con_Open();

            SqlCommand cmd1 = new SqlCommand("Select * From Pay_Amount where Cust_ID = " + tb_Cust_ID.Text + " ", Con);

            var obj1 = cmd1.ExecuteReader();

            if (obj1.Read())
            {
                tb_Prev_Room_Bill.Text = (obj1["Room_Bill"].ToString());
                Val = Convert.ToDouble(tb_Prev_Room_Bill.Text);
                tb_Discount.Text = (obj1["Discount"].ToString());

                tb_Pay.Text = (obj1["Pay"]).ToString();
                pay = Convert.ToDouble(tb_Pay.Text);

            }
            else
            {
                MessageBox.Show("Invaild Roll Number...");
                tb_Cust_ID.Clear();
                tb_Cust_ID.Focus();
            }
            Con_Close();
           
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Update Cust_Booking_Room_Info Set Check_Out_Date = '" + dtp_Check_Out_Date.Text + "' , Day = " + tb_Day.Text + " , Hrs = " + tb_Hrs.Text + " , Total = " + tb_Total.Text + " where Cust_ID = " + tb_Cust_ID.Text + " And Room_No = " + cmb_Room_No.Text + "", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            Con_Close();


            Con_Open();

            UserName_Updt = Global_Login.U_Name;

            SqlDataAdapter s = new SqlDataAdapter("Update Pay_Amount Set Room_Bill = " + tb_Total.Text + " ,Total = " + tb_Bill.Text + " , Remaining = " + tb_Remaining.Text + " , UserName_Updt = '" + UserName_Updt + "' where Cust_ID = " + tb_Cust_ID.Text + " ", Con);

            DataTable d = new DataTable();

            s.Fill(d);

            MessageBox.Show("Update Successfully..", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tb_Amount.Clear();

            tb_Cust_ID.Clear();
            tb_Day.Clear();
            tb_Hrs.Clear();
            tb_Prev_Room_Bill.Clear();

            tb_Total.Clear();
            cmb_Room_No.SelectedIndex = -1;
            cb__Room_Type.SelectedIndex = -1;
            cb_Bed_Type.SelectedIndex = -1;
            tb_Discount.Text = "";
            tb_Pay.Text = "";
            tb_Bill.Text = "";
            tb_Remaining.Text = "";

            Con_Close();
           
        }

        public string UserName { get; set; }

        public string UserName_Updt { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cm = new SqlCommand("select * From Cust_Booking_Room_Info where Cust_ID = " + tb_Cust_ID.Text + "", Con);

            var obj1 = cm.ExecuteReader();

            while (obj1.Read())
            {
                cmb_Room_No.Items.Add(obj1["Room_No"].ToString());

            }
            obj1.Close();
            Con_Close();
        }

        private void btn_Generate_Bill_Click(object sender, EventArgs e)
        {
            tb_Pay.Text = pay.ToString();
            double Total, TPrice = 0;

            double Rprice = Convert.ToDouble(tb_Total.Text);
            double Discount = Convert.ToDouble(tb_Discount.Text);

            Total = Rprice * (Discount / 100);
            TPrice = Rprice - Total;

            tb_Bill.Text = TPrice.ToString();
        }

        private void btn_Remaining_Click(object sender, EventArgs e)
        {
            tb_Remaining.Text = (Convert.ToDouble(tb_Bill.Text) - Convert.ToDouble(tb_Pay.Text)).ToString();
        }

        private void cmb_Room_No_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Next.Visible = false;
            btn_Search.Visible = true;
        }
    }
}
