using Lodging_Managment_System.CrystalReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lodging_Managment_System
{
    public partial class Reports : Form
    {
        SqlConnection con;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Reports()
        {
            InitializeComponent();
        }

        private void btn_Service_Rep_Click(object sender, EventArgs e)
        {
            crt_Service cryRpt = new crt_Service();
            cryRpt.Load("crt_Service.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            Visiblity();
        }

        private void btn_Room_Rep_Click(object sender, EventArgs e)
        {
            crt_Room cryRpt = new crt_Room();
            cryRpt.Load("crt_Room.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            Visiblity();
        }

        private void btn_Employee_Rep_Click(object sender, EventArgs e)
        {
            crt_Employee cryRpt = new crt_Employee();
            cryRpt.Load("crt_Employee.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            Visiblity();
        }

        private void btn_Check_Out_Rep_Click(object sender, EventArgs e)
        {
            crt_Check_Out cryRpt = new crt_Check_Out();
            cryRpt.Load("crt_Check_Out.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            Visiblity();
        }

        private void btn_Cust_Rep_MouseHover(object sender, EventArgs e)
        {
            pnl_Cust.Visible = true;
        }

        private void btn_Employee_Rep_MouseHover(object sender, EventArgs e)
        {
            pnl_Cust.Visible = false;
        }

        private void btn_Room_Rep_MouseHover(object sender, EventArgs e)
        {
            pnl_Cust.Visible = false;
        }

        private void btn_Service_Rep_MouseHover(object sender, EventArgs e)
        {
            pnl_Cust.Visible = false;
        }

        private void btn_Check_Out_Rep_MouseHover(object sender, EventArgs e)
        {
            pnl_Cust.Visible = false;
        }

        private void btn_Single_Cust_Click(object sender, EventArgs e)
        {
            //pnl_Search.Visible = true;
        }

        

       

        private void btn_Cust_List_Click(object sender, EventArgs e)
        {
            crt_Customer cryRpt = new crt_Customer();
            cryRpt.Load("crt_Customer.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            Visiblity();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\EXPRESS;Initial Catalog=Lodging_Managment_System_DB;Integrated Security=True");
            da = new SqlDataAdapter("Select Cust_Personal_Info.Cust_ID,Cust_Personal_Info.Name,Cust_Personal_Info.Booking_Date,Cust_Personal_Info.Mobile_Number,Cust_Personal_Info.Alternate_Mob_No,Cust_Personal_Info.Email,Cust_Personal_Info.DOB,Cust_Personal_Info.Address,Cust_Personal_Info.AdharCard_No,Cust_Personal_Info.PAN_No,Cust_Booking_Room_Info.Room_No,Cust_Booking_Room_Info.Check_In_Date,Cust_Booking_Room_Info.Check_Out_Date,Cust_Booking_Room_Info.Room_Type,Cust_Booking_Room_Info.Bed_Type,Cust_Booking_Room_Info.Day,Cust_Booking_Room_Info.Hrs,Cust_Booking_Room_Info.Total,Pay_Amount.Room_Bill,Pay_Amount.Discount,Pay_Amount.Total,Pay_Amount.Pay,Pay_Amount.Remaining From Cust_Personal_Info INNER JOIN Cust_Booking_Room_Info ON Cust_Personal_Info.Cust_ID = Cust_Booking_Room_Info.Cust_ID INNER JOIN Pay_Amount ON Cust_Personal_Info.Cust_ID = Pay_Amount.Cust_ID ", con);
            da.Fill(ds);
            crt_Single_Customer cryRpt = new crt_Single_Customer();
            cryRpt.Load("crt_Customer.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void btn_Single_Cust_Click_1(object sender, EventArgs e)
        {
            tb_Cust_ID.Visible = true;
            btn_Search.Visible = true;
            lb_Cust_ID.Visible = true;
        }

        public void Visiblity()
        {
            tb_Cust_ID.Visible = false;
            btn_Search.Visible = false;
            lb_Cust_ID.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
