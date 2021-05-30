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
    public partial class Update_Employee : Form
    {
        Connection_File CF = new Connection_File();
        public Update_Employee()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CF.Con_Open();
            if (tb_Employee_ID.Text != "")
            {
                 String res = "";

                if (rb_Male.Checked)
                {
                    res = rb_Male.Text;
                }
                else if (rb_Female.Checked)
                {
                    res = rb_Female.Text;
                }

                SqlDataAdapter sda = new SqlDataAdapter("Update Add_New_Employee Set  Name =  '" + tb_Name.Text + "',Address = '" + tb_Address.Text + "',Gender = '"+res+"',DOB = '" + dtp_DOB.Text + "',Email = '" + tb_Email_ID.Text + "',Hire_Date = '" + dtp_Hire_Date.Text + "',Mob_No = " + tb_Mobile_No.Text + ",Alt_Mob_No = "+tb_Alt_Mob_No.Text+",Aadhar_No = " + tb_Adhar_Card_No.Text + ",PAN_No = '" + tb_Pan_Card_No.Text + "',Salary = " + tb_Salary.Text + ",Bank_No = '" + tb_Account_No.Text + "' , IFC_Code = '"+tb_IFC_Code.Text+"'  Where Emp_ID = '"+tb_Employee_ID.Text+"' ", CF.Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);


                MessageBox.Show("SuccessFully Updated !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();

            }
            else
            {
                MessageBox.Show("Invalid ID");
            }

            CF.Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Add_New_Employee Where Emp_ID = '" + tb_Employee_ID.Text + "'", CF.Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                dtp_DOB.Text = obj["DOB"].ToString();
                tb_Email_ID.Text = obj.GetString(obj.GetOrdinal("Email"));
                dtp_Hire_Date.Text = obj["Hire_Date"].ToString();
                tb_Mobile_No.Text = obj["Mob_No"].ToString();
                tb_Adhar_Card_No.Text = obj["Aadhar_No"].ToString();
                tb_Pan_Card_No.Text = obj.GetString(obj.GetOrdinal("PAN_No"));
                tb_Salary.Text = obj["Salary"].ToString();
                tb_Account_No.Text = obj["Bank_No"].ToString();
                tb_Alt_Mob_No.Text = obj["Alt_Mob_No"].ToString();
                tb_IFC_Code.Text = obj.GetString(obj.GetOrdinal("IFC_Code"));
                String Gender = obj.GetString(obj.GetOrdinal("Gender"));
                if (Gender == "Male")
                {
                    rb_Male.Checked = true;
                }
                else
                {
                    rb_Female.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Employee ID Not Found", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Employee_ID.Text = "";
                tb_Employee_ID.Focus();
            }

            CF.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            tb_Account_No.Clear();
            tb_Address.Clear();
            tb_Adhar_Card_No.Clear();
            tb_Email_ID.Clear();
            tb_Employee_ID.Clear();
            tb_Mobile_No.Clear();
            tb_Name.Clear();
            tb_Pan_Card_No.Clear();
            tb_Salary.Clear();
            dtp_DOB.Text = "";
            dtp_Hire_Date.Text = "";
            tb_Alt_Mob_No.Text = "";
            tb_IFC_Code.Text = "";
            if (rb_Male.Checked)
            {
                rb_Male.Checked = false;
            }
            else
            {
                rb_Female.Checked = false;
            }
            
            
        }
    }
}
