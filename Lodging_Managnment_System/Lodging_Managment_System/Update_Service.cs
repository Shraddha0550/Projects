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
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Lodging_Managment_System_DB;Integrated Security=True");

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

            SqlDataAdapter sda = new SqlDataAdapter("Select *From R_Service Where  Cust_ID = " + tb_Cust_ID.Text + " ", Con);

            DataTable dt = new DataTable();

            dgv_Service.DataSource = dt;

            sda.Fill(dt);

            Con_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lodging_Managment_System_DBDataSet23.R_Service' table. You can move, or remove it, as needed.
            this.r_ServiceTableAdapter1.Fill(this.lodging_Managment_System_DBDataSet23.R_Service);

        }

        private void dgv_Service_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dgv_Service.SelectedRows.Count > 0)
            {
               tb_Charge.Text = dgv_Service.SelectedRows[0].Cells[1].Value.ToString();
               tb_Service.Text = dgv_Service.SelectedRows[0].Cells[2].Value.ToString();

           }
        
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            Con_Open();


            if (tb_Cust_ID.Text != "")
            {
                UserName = Global_Login.U_Name;

                SqlDataAdapter sda = new SqlDataAdapter("Update Rooms Set Charge =  " + tb_Charge.Text + " ,Service =  '" + tb_Service.Text + "' , UserName_Updt = '" + UserName + "'  Where Cust_ID = " + tb_Cust_ID.Text + "  ", Con);

                DataTable dt = new DataTable();


                sda.Fill(dt);


                MessageBox.Show("\t Update Room Succesfully \t");

            }
            else
            {
                MessageBox.Show(" Please Filled All Fields");
            }

            Con_Close();
        }
        public string UserName { get; set; }
    }
}
