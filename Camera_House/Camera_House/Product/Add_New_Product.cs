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
    public partial class Add_New_Product : Form
    {
        Connection_File CF = new Connection_File();
        public Add_New_Product()
        {
            InitializeComponent();
        }
       
        private void Add_New_Product_Load(object sender, EventArgs e)
        {
            Bind_Company_Name();
            tb_Product_ID.Text = Auto_Inc().ToString();
        }

        void Bind_Company_Name()
        {
            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Distinct(Company_Name) From Add_Company_Name", CF.Con);

            var obj = cmd.ExecuteReader();
            cmb_Company_Name.Items.Clear();

            while (obj.Read())
            {
                cmb_Company_Name.Items.Add(obj.GetString(obj.GetOrdinal("Company_Name")));
            }

            CF.Con_Close();

        }

        public void clear()
        {
            tb_Product_ID.Text = "";
            tb_Description.Text = "";
            tb_Purches_Price.Text = "";
            tb_Sale_Price.Text = "";
            cmb_Company_Name.SelectedIndex = -1;
            cmb_Model_Name.SelectedIndex = -1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            int Stock = 0;
            if (tb_Product_ID.Text != ""  && cmb_Company_Name.Text != "" && cmb_Model_Name.Text != "" && tb_Purches_Price.Text != "" && tb_Sale_Price.Text != "" )
            {
                SqlDataAdapter sda = new SqlDataAdapter("insert into Add_New_Product(Prod_ID,Company_Name,Model_Name,Purches_Price,Sales_Price,Discription,Stock) Values(" + tb_Product_ID.Text + " , '" + cmb_Company_Name.Text + "','" + cmb_Model_Name.Text + "'," + tb_Purches_Price.Text + "," + tb_Sale_Price.Text + ", '" + tb_Description.Text + "'," + Stock + " )", CF.Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);
              

                MessageBox.Show("SuccessFully Added !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
               
             
            }
            else
            {
                MessageBox.Show("First Fill All Fields..!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            CF.Con_Close();
        }

        private void cmb_Company_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Model_Name From Add_Model_Name Where Company_Name = '"+cmb_Company_Name.Text+"' ",CF.Con);

            var obj = cmd.ExecuteReader();
            cmb_Model_Name.Items.Clear();

            while (obj.Read())
            {
                cmb_Model_Name.Items.Add(obj.GetString(obj.GetOrdinal("Model_Name")));
            }

            CF.Con_Close();
        }

       
         private void btn_Refresh_Click(object sender, EventArgs e)
         {
             clear();
            
         }

         int Auto_Inc()
         {
             int Cnt = 0;

             CF.Con_Open();

             SqlCommand cmd = new SqlCommand("Select Count(Prod_ID) From  Add_New_Product", CF.Con);

             Cnt = Convert.ToInt32(cmd.ExecuteScalar());

             Cnt = 101 + Cnt;

             CF.Con_Close();

             return Cnt;
         }

        }
 }

