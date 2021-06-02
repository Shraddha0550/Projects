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
    public partial class Update_Service : Form
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

        public Update_Service()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Service obj = new Service();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        

        public string UserName_Updt { get; set; }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select *From R_Service Where  Cust_ID = " + tb_Cust_ID.Text + " ", Con);

                DataTable dt = new DataTable();

                dgv_Service.DataSource = dt;

                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }


            Con_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Service_Load(object sender, EventArgs e)
        {
            Bind_Data();
        }
        void Bind_Data()
        {
            Con_Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From R_Service", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Service.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
           
            Con_Close();
        }

        private void dgv_Service_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (dgv_Service.SelectedRows.Count > 0)
                {
                    tb_Charge.Text = dgv_Service.SelectedRows[0].Cells[1].Value.ToString();
                    tb_Service.Text = dgv_Service.SelectedRows[0].Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }

        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            try
            {
                if (tb_Cust_ID.Text != "" && tb_Service.Text != "" && tb_Charge.Text != "")
                {
                    UserName = Global_Login.U_Name;

                    SqlDataAdapter sda = new SqlDataAdapter("Update R_Service Set Charge =  " + tb_Charge.Text + " ,Service =  '" + tb_Service.Text + "' , UserName_Update = '" + UserName + "'  Where Cust_ID = " + tb_Cust_ID.Text + "  And Date = '" + dtp_Date.Text + "' ", Con);

                    DataTable dt = new DataTable();


                    sda.Fill(dt);


                    MessageBox.Show("\t Update Room Succesfully \t");

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
    }
}
