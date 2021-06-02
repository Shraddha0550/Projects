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
    public partial class Update_Rooms : Form
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

        public Update_Rooms()
        {
            InitializeComponent();
        }

      
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Add_Room obj = new Add_Room();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            Con_Open();

            try
            {
                SqlCommand cmd = new SqlCommand("Select * From Rooms where RoomNo = " + tb_Room_No.Text + " ", Con);

                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    cb_Room_Type.Text = obj.GetString(obj.GetOrdinal("RoomType"));
                    cb_Bed_Type.Text = obj.GetString(obj.GetOrdinal("BedType"));
                    tb_Room_Specification.Text = obj.GetString(obj.GetOrdinal("Specification"));
                    tb_Amount_Day.Text = (obj["Amount_Day"].ToString());
                    tb_Per_Hrs.Text = (obj["Per_Hrs"].ToString());

                }
                else
                {
                    MessageBox.Show("Invaild Room Number...");
                    tb_Room_No.Clear();
                    tb_Room_No.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }



            Con_Close();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            try
            {
                if (tb_Room_No.Text != "" && cb_Room_Type.Text != "" && cb_Bed_Type.Text != "" && tb_Amount_Day.Text != "")
                {
                    UserName = Global_Login.U_Name;
                    double Day = double.Parse(tb_Amount_Day.Text);
                    double Hrs = double.Parse(tb_Per_Hrs.Text);


                    if (Day <= Hrs)
                    {
                        MessageBox.Show("Please Fill Correct Amount !!");
                        tb_Per_Hrs.Text = "";
                        tb_Amount_Day.Text = "";
                    }
                    else
                    {
                        SqlDataAdapter sda = new SqlDataAdapter("Update Rooms Set RoomType =  '" + cb_Room_Type.Text + "' , BedType =  '" + cb_Bed_Type.Text + "' , Amount_Day =  " + tb_Amount_Day.Text + " , Specification = '" + tb_Room_Specification.Text + "' , UserName_Updt = '" + UserName + "' , Per_Hrs = " + tb_Per_Hrs.Text + " Where RoomNo = " + tb_Room_No.Text + "  ", Con);

                        DataTable dt = new DataTable();

                        sda.Fill(dt);

                        MessageBox.Show("\t Update Room Succesfully \t");

                        tb_Room_No.Clear();
                        tb_Amount_Day.Clear();
                        tb_Per_Hrs.Text = "";
                        tb_Room_Specification.Clear();
                        cb_Bed_Type.SelectedIndex = -1;
                        cb_Room_Type.SelectedIndex = -1;

                    }
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

            Con_Close();
           
        }

        public string UserName { get; set; }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
