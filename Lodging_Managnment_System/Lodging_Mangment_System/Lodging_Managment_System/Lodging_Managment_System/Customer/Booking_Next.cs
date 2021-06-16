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
    public partial class Booking_Next : Form
    {
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
        public Booking_Next()
        {
            InitializeComponent();
        }

        private void Booking_Next_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet.Rooms' table. You can move, or remove it, as needed.
           // this.roomsTableAdapter.Fill(this.lodging_Managment_System_DBDataSet.Rooms);
         
                tb_Cust_ID.Text = Convert.ToString(Auto_Incr1());
            btn_Hrs_Add.Visible = false;

        }

        private void dtp_Check_Out_Date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date1 = dtp_Ckeck_In_Date.Value.Date;
                DateTime date2 = dtp_Check_Out_Date.Value.Date;

                int Days = ((TimeSpan)(date2 - date1)).Days;

                tb_Day.Text = Days.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }

        }

        private void btn_View_Available_Rooms_Click(object sender, EventArgs e)
        {
            Con_Open();

            try
            {
                if (tb_Day.Text != "0")
                {
                    btn_Hrs_Add.Visible = false;
                }
                if (tb_Day.Text == "0")
                {
                    btn_Add.Visible = false;
                }

                SqlDataAdapter sda = new SqlDataAdapter("Select * From  Rooms where RoomType = '" + cb__Room_Type.Text + "' And BedType = '" + cb_Bed_Type.Text + "' And Reserve = 'NO' ", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgv_Available_Room.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }


            Con_Close();
        }

        private void tb_Day_TextChanged(object sender, EventArgs e)
        {
            if (tb_Day.Text == "0")
            {
                tb_Hrs.Enabled = true;
                btn_Hrs_Add.Visible = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("RoomNo");
                dt.Columns.Add("RoomType");
                dt.Columns.Add("BedType");
                dt.Columns.Add("Amount_Day");

                foreach (DataGridViewRow drv in dgv_Available_Room.Rows)
                {
                    bool chkboxselect = Convert.ToBoolean(drv.Cells["Choice"].Value);
                    if (chkboxselect)
                    {
                        dt.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[4].Value);
                        drv.DefaultCellStyle.BackColor = Color.Gray;
                        drv.DefaultCellStyle.ForeColor = Color.Aqua;

                    }
                    dgv_Destination.DataSource = dt;
                }

                Con.Open();

                SqlCommand cm = new SqlCommand("select *From Rooms where RoomNo = " + tb_Room_No.Text + "", Con);

                var obj1 = cm.ExecuteReader();


                if (obj1.Read())
                {
                    tb_Amount.Text = (obj1["Amount_Day"].ToString());
                }
                else
                {
                    MessageBox.Show("Inavlid ");
                }


                int numRow = dgv_Destination.Rows.Count;
                int count = numRow - 1;

                tb_Count_Of_Rooms.Text = count.ToString();

                string Total = (Convert.ToInt32(tb_Day.Text) * Convert.ToDecimal(tb_Amount.Text)).ToString();
                tb_Total.Text = Total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }


            Con.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Con_Open();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From  Rooms ", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgv_Available_Room.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }


            Con_Close();
        }

        private void dgv_Available_Room_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Available_Room.SelectedRows.Count > 0)
                {
                    tb_Room_No.Text = dgv_Available_Room.SelectedRows[0].Cells[1].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            
            Pay_Amount obj = new Pay_Amount();
            obj.MdiParent = this.MdiParent;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Close();
        }

        private void btn_Hrs_Add_Click(object sender, EventArgs e)
        {
           
           
                DataTable dt = new DataTable();
                dt.Columns.Add("RoomNo");
                dt.Columns.Add("RoomType");
                dt.Columns.Add("BedType");
                dt.Columns.Add("Per_Hrs");

                foreach (DataGridViewRow drv in dgv_Available_Room.Rows)
                {
                    bool chkboxselect = Convert.ToBoolean(drv.Cells["Choice"].Value);
                    if (chkboxselect)
                    {
                        dt.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[7].Value);
                        drv.DefaultCellStyle.BackColor = Color.Gray;
                        drv.DefaultCellStyle.ForeColor = Color.Aqua;

                    }
                    dgv_Destination.DataSource = dt;

                try
                {
                    Con_Open();

                    SqlCommand cm = new SqlCommand("select *From Rooms where RoomNo = " + tb_Room_No.Text + "", Con);

                    var obj1 = cm.ExecuteReader();


                    if (obj1.Read())
                    {
                        tb_Amount.Text = (obj1["Per_Hrs"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Inavlid ");
                    }

                    int numRow = dgv_Destination.Rows.Count;
                    int count = numRow - 1;

                    tb_Count_Of_Rooms.Text = count.ToString();

                    string Total = (Convert.ToInt32(tb_Hrs.Text) * Convert.ToDecimal(tb_Amount.Text)).ToString();
                    tb_Total.Text = Total;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
                }

                  Con_Close();

            }
        }

        private void btn_Allote_Room_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Day.Text != "0")
                {
                    int Hrs = 0;

                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Cust_Booking_Room_Info(Check_In_Date,Check_Out_Date,Room_Type,Bed_Type,Count_Of_Rooms,Room_No,Day,Hrs,Amount,Total,Cust_ID) values('" + dtp_Ckeck_In_Date.Text + "' , '" + dtp_Check_Out_Date.Text + "' , '" + cb__Room_Type.Text + "' , '" + cb_Bed_Type.Text + "' , " + tb_Count_Of_Rooms.Text + " , " + tb_Room_No.Text + ", " + tb_Day.Text + " , " + Hrs + " , " + tb_Amount.Text + " , " + tb_Total.Text + " , " + tb_Cust_ID.Text + " )Update Rooms set Reserve = 'YES'  where RoomNo = '" + tb_Room_No.Text + "' ", Con);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    MessageBox.Show("Succesfull");

                    tb_Count_Of_Rooms.Clear();
                    tb_Amount.Clear();
                    tb_Total.Clear();
                    tb_Room_No.Clear();
                    cb_Bed_Type.SelectedIndex = -1;
                    cb__Room_Type.SelectedIndex = -1;
                    tb_Day.Clear();
                    

                }
                else if (tb_Day.Text == "0")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Cust_Booking_Room_Info(Check_In_Date,Check_Out_Date,Room_Type,Bed_Type,Count_Of_Rooms,Room_No,Day,Hrs,Amount,Total,Cust_ID) values('" + dtp_Ckeck_In_Date.Text + "' , '" + dtp_Check_Out_Date.Text + "' , '" + cb__Room_Type.Text + "' , '" + cb_Bed_Type.Text + "' , " + tb_Count_Of_Rooms.Text + " , " + tb_Room_No.Text + ", " + tb_Day.Text + " , " + tb_Hrs.Text + " , " + tb_Amount.Text + " , " + tb_Total.Text + " , " + tb_Cust_ID.Text + " )Update Rooms set Reserve = 'YES'  where RoomNo = '" + tb_Room_No.Text + "' ", Con);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    MessageBox.Show("Succesfull");
                    tb_Count_Of_Rooms.Clear();
                    tb_Amount.Clear();
                    tb_Total.Clear();
                    tb_Room_No.Clear();
                    cb_Bed_Type.SelectedIndex = -1;
                    cb__Room_Type.SelectedIndex = -1;
                    tb_Hrs.Clear();


                }
                else
                {
                    MessageBox.Show(" Please Filled All Fields");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }

        }


        int Auto_Incr1()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Cust_ID) From  Pay_Amount", Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1001 + Cnt ;

            Con_Close();

            return Cnt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pay_Amount obj = new Pay_Amount();
            obj.MdiParent = this.MdiParent;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Booking1 obj = new frm_Booking1();
            obj.MdiParent = this.MdiParent;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}