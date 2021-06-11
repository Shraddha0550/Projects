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
    public partial class Add_New_Employee : Form
    {
        Connection_File CF = new Connection_File();
        public Add_New_Employee()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CF.Con_Open();
            try
            {
                if (tb_Employee_ID.Text != "" && tb_Name.Text != "" && tb_Address.Text != "" && dtp_DOB.Text != "" && tb_Email_ID.Text != "" && dtp_Hire_Date.Text != "" && tb_Mobile_No.Text != "" && tb_Adhar_Card_No.Text != "" && tb_Pan_Card_No.Text != "" && tb_Salary.Text != "" && tb_Account_No.Text != "")
                {
                    String Gender = "";

                    if (rb_Male.Checked)
                    {
                        Gender = rb_Male.Text;
                    }
                    else if (rb_Female.Checked)
                    {
                        Gender = rb_Female.Text;
                    }

                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Add_New_Employee Values('" + tb_Employee_ID.Text + "','" + tb_Name.Text + "','" + tb_Address.Text + "','" + Gender + "','" + dtp_DOB.Text + "'," + tb_Mobile_No.Text + "," + tb_Alt_Mob_No.Text + ",'" + dtp_Hire_Date.Text + "','" + tb_Email_ID.Text + "'," + tb_Adhar_Card_No.Text + ",'" + tb_Pan_Card_No.Text + "'," + tb_Salary.Text + ",'" + tb_Account_No.Text + "','" + tb_IFC_Code.Text + "')", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("SuccesFully Added !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    tb_Employee_ID.Text = Auto_Inc().ToString();

                }
                else
                {
                    MessageBox.Show("First Fill All Fields..!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            clear();
        }

        public void clear()
        {
            tb_Account_No.Text = "";
            tb_Address.Text = "";
            tb_Adhar_Card_No.Text = "";
            tb_Email_ID.Text = "";
            tb_Mobile_No.Text = "";
            tb_Name.Text = "";
            tb_Pan_Card_No.Text = "";
            tb_Salary.Text = "";
            tb_Alt_Mob_No.Text = "";
            tb_IFC_Code.Text = "";
            dtp_DOB.Text = "";
            dtp_Hire_Date.Text = "";
            if (rb_Male.Checked)
            {
                rb_Male.Checked = false;
            }
            else
            {
                rb_Female.Checked = false;
            }
        }

        String Auto_Inc()
        {
            int Cnt = 0;
            String var = "Emp_";

            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Emp_ID) From  Add_New_Employee", CF.Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1 + Cnt;

            String count = Cnt.ToString();
            String res = var+count;


            CF.Con_Close();

            return res;
        }

        private void Add_New_Employee_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Text = Auto_Inc().ToString();
            tb_Employee_ID.Focus();
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Alphanumeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
    }
}
