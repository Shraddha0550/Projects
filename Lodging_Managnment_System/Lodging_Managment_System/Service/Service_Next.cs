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
    public partial class Service_Next : Form
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
        public Service_Next()
        {
            InitializeComponent();
        }

        private void Service_Next_Load(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
           
            Con_Close();
        }

        private void btn_Amount_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Amount.Text = "0";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    tb_Amount.Text = Convert.ToString(double.Parse(tb_Amount.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Service obj = new Service();
            obj.MdiParent = this.MdiParent;
            obj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Id_Click(object sender, EventArgs e)
        {
            Con.Open();

            try
            {
                if (tb_Cust_ID.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select *From R_Service Where  Cust_ID = " + tb_Cust_ID.Text + " ", Con);

                    DataTable dt = new DataTable();

                    dataGridView1.DataSource = dt;

                    sda.Fill(dt);
                }
                else
                {
                    MessageBox.Show("Fill Customer ID");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }




            Con_Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Con.Open();

            try {
                SqlDataAdapter sda = new SqlDataAdapter("Select *From R_Service  ", Con);

                DataTable dt = new DataTable();

                dataGridView1.DataSource = dt;

                sda.Fill(dt);

                tb_Amount.Clear();
                tb_Cust_ID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }



            Con_Close();
        }

       

      

       

       
            
            
            
            
        

      

       
    }
}
