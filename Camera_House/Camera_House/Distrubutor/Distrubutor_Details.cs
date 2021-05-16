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
    public partial class Distrubutor_Details : Form
    {
        Connection_File CF = new Connection_File();
        public Distrubutor_Details()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CF.Con_Open();
            if(tb_Distrubutor_ID.Text != "" && tb_Company_Name.Text != "" && tb_Model_Name.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert into Dist_Product_List Values("+tb_Distrubutor_ID.Text+" , '"+tb_Company_Name.Text+"' , '"+tb_Model_Name.Text+"')",CF.Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Added Successfully.." , "Success" , MessageBoxButtons.OK);
                tb_Model_Name.Clear();
                tb_Company_Name.Clear();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CF.Con_Close();
        }


        void Refresh_Grid()
        {
            CF.Con_Open();

            int var = 0;
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Dist_Details Where Distrubutor_ID = " + var + " ", CF.Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Product_List.DataSource = dt;

            CF.Con_Close();
        }

        private void Distrubutor_Details_Load(object sender, EventArgs e)
        {
            Refresh_Grid();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh_Grid();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CF.Con_Open();
            if (tb_Distrubutor_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != ""  && tb_Pan_Card_No.Text != "" && tb_Email_ID.Text != "" && tb_Adhar_Card_No.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert into Dist_Details Values(" + tb_Distrubutor_ID.Text + " , '" + tb_Name.Text + "' ,"+tb_Mobile_No.Text+" , '"+tb_Address.Text+"' , '"+tb_Email_ID.Text+"' , "+tb_Adhar_Card_No.Text+" , '"+tb_Pan_Card_No.Text+"',"+tb_Alt_Mob_No.Text+","+tb_Account_No.Text+",'"+tb_IFC_Code.Text+"')", CF.Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Added Successfully..", "Success", MessageBoxButtons.OK);
                clear_Text();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CF.Con_Close();
        }

        void clear_Text()
        {
            tb_Address.Clear();
            tb_Adhar_Card_No.Clear();
            tb_Distrubutor_ID.Clear();
            tb_Email_ID.Clear();
            tb_Mobile_No.Clear();
            tb_Name.Clear();
            tb_Pan_Card_No.Clear();
            tb_Company_Name.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
