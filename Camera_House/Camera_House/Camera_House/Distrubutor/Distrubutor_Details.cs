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

            try
            {
                if (tb_Distrubutor_ID.Text != "" && tb_Company_Name.Text != "" && tb_Model_Name.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Dist_Product_List Values(" + tb_Distrubutor_ID.Text + " , '" + tb_Company_Name.Text + "' , '" + tb_Model_Name.Text + "')", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("Added Successfully..", "Success", MessageBoxButtons.OK);
                    tb_Model_Name.Clear();
                    tb_Company_Name.Clear();
                    Refresh_Grid();
                    btn_Save.Enabled = true;
                }
                else
                {
                    MessageBox.Show("First Fill All Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }

            CF.Con_Close();
        }


       

        void Refresh_Grid()
        {
            CF.Con_Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Dist_Product_List Where Dist_ID = " + tb_Distrubutor_ID.Text + " ", CF.Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgv_Product_List.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }

            CF.Con_Close();
        }

        private void Distrubutor_Details_Load(object sender, EventArgs e)
        {
            tb_Distrubutor_ID.Text = Auto_Inc().ToString();
      
        }

        int Auto_Inc()
        {
            int Cnt = 0;

            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Dist_ID) From  Dist_Details", CF.Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1001 + Cnt;

            CF.Con_Close();

            return Cnt;
        }
        
        void Data()
        {
            CF.Con_Open();

            int var = 0;
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Dist_Product_List Where Dist_ID = " + var + " ", CF.Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Product_List.DataSource = dt;

            CF.Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            try
            {
                if (tb_Distrubutor_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Pan_Card_No.Text != "" && tb_Email_ID.Text != "" && tb_Adhar_Card_No.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Dist_Details Values(" + tb_Distrubutor_ID.Text + " , '" + tb_Name.Text + "' , " + tb_Mobile_No.Text + " ," + tb_Alt_Mob_No.Text + " ,'" + tb_Address.Text + "' , '" + tb_Email_ID.Text + "' , " + tb_Adhar_Card_No.Text + " , '" + tb_Pan_Card_No.Text + "','" + tb_Account_No.Text + "','" + tb_IFC_Code.Text + "')", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("Added Successfully..", "Success", MessageBoxButtons.OK);
                    clear_Text();
                    tb_Distrubutor_ID.Text = Auto_Inc().ToString();
                    Refresh_Grid();
                }
                else
                {
                    MessageBox.Show("First Fill All Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }        

            CF.Con_Close();
        }

        void clear_Text()
        {
            tb_Address.Clear();
            tb_Adhar_Card_No.Clear();
            tb_Email_ID.Clear();
            tb_Mobile_No.Clear();
            tb_Name.Clear();
            tb_Alt_Mob_No.Clear();
            tb_IFC_Code.Clear();
            tb_Account_No.Clear();
            tb_Pan_Card_No.Clear();
            tb_Company_Name.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear_Text();
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

        private void Only_AlphNumeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
    }
}
