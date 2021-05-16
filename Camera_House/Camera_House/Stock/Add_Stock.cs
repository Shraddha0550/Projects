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
    public partial class Add_Stock : Form
    {
        Connection_File CF = new Connection_File();
        public Add_Stock()
        {
            InitializeComponent();
        }

        private void Add_Stock_Load(object sender, EventArgs e)
        {
            Bind_Company_Name();
            Bind_Distrubutor_Name();
            tb_Product_ID.Text = Auto_Inc().ToString();
        }

        int Auto_Inc()
        {
            int Cnt = 0;

            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(ID) From  Add_Stock", CF.Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1 + Cnt;

            CF.Con_Close();

            return Cnt;
        }


        void Bind_Company_Name()
        {

            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Distinct(Company_Name) From Add_New_Product", CF.Con);

            var obj = cmd.ExecuteReader();
            cmb_Company_Name.Items.Clear();

            while (obj.Read())
            {
                cmb_Company_Name.Items.Add(obj.GetString(obj.GetOrdinal("Company_Name")));
            }
            CF.Con_Close();
        }

        void Bind_Distrubutor_Name()
        {

            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Distinct(Name) From Dist_Details", CF.Con);

            var obj = cmd.ExecuteReader();     
            cmb_Distrubutor_Name.Items.Clear();

            while (obj.Read())
            {
                cmb_Distrubutor_Name.Items.Add(obj.GetString(obj.GetOrdinal("Name")));
            }
            CF.Con_Close();
        }

       

        private void cmb_Company_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Model_Name From Add_New_Product Where Company_Name = '" + cmb_Company_Name.Text + "'", CF.Con);

            var obj = cmd.ExecuteReader();
            cmb_Model_Name.Items.Clear();

            while (obj.Read())
            {
                cmb_Model_Name.Items.Add(obj.GetString(obj.GetOrdinal("Model_Name")));
            }

            CF.Con_Close();
        }

        private void cmb_Distrubutor_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select *From Add_New_Product Where Company_Name = '" + cmb_Company_Name.Text + "' And Model_Name = '" + cmb_Model_Name.Text + "' ", CF.Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Current_Stock.Text = obj["Stock"].ToString();
            }
           
            CF.Con_Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(cmb_Company_Name.Text != "" && cmb_Model_Name.Text != "" && cmb_Distrubutor_Name.Text != "" && tb_Total_Stock.Text != "" && tb_Stock_Added.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("insert into Add_Stock Values(" + tb_Product_ID.Text + " , '" + cmb_Company_Name.Text + "','" + cmb_Model_Name.Text + "','" + dtp_Date.Text + "'," + tb_Stock_Added.Text + "," + tb_Total_Stock.Text + " ) Update Add_New_Product set Stock = "+tb_Total_Stock.Text+"", CF.Con);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);


                    MessageBox.Show("SuccessFully Added !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Current_Stock.Clear();
                    tb_Stock_Added.Clear();
                    tb_Total_Stock.Clear();
                    cmb_Company_Name.SelectedIndex = -1;
                    cmb_Distrubutor_Name.SelectedIndex = -1;
                    cmb_Model_Name.SelectedIndex = -1;
                
            }
            else
            {
                MessageBox.Show("First Fill All Fields");
            }
          
        }
        
        private void btn_Total_STock_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(tb_Current_Stock.Text);
            int b = Convert.ToInt32(tb_Stock_Added.Text);
            int c = a + b;

            tb_Total_Stock.Text = c.ToString();
        }
    }
}
