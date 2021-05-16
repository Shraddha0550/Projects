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
    public partial class Add_Model_Name : Form
    {
        Connection_File CF = new Connection_File();

        public Add_Model_Name()
        {
            InitializeComponent();
        }

        void Bind_Company_Name()
        {
            CF.Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Distinct(Company_Name) From Add_Company_Name";
            cmd.Connection = CF.Con;

            var obj = cmd.ExecuteReader();
            cmb_Company_Name.Items.Clear();

            while (obj.Read())
            {
                cmb_Company_Name.Items.Add(obj.GetSqlString(obj.GetOrdinal("Company_Name")));
            }

            CF.Con_Close();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            if(tb_ID.Text != "" && tb_Model_Name.Text != ""  && cmb_Company_Name.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("insert into Add_Model_Name(ID,Company_Name,Model_Name) Values('" + tb_ID.Text + "' , '" + cmb_Company_Name.Text + "','" + tb_Model_Name.Text + "')", CF.Con);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    MessageBox.Show("SuccesFully Added !! ","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cmb_Company_Name.SelectedIndex = -1;
                    tb_Model_Name.Text = "";
                    tb_ID.Text = Auto_Inc().ToString();
            }
            else
            {
                MessageBox.Show("First Fill All Fields..!!", "Failure",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            CF.Con_Close();
        }

        private void Add_Model_Name_Load(object sender, EventArgs e)
        {
            Bind_Company_Name();
            tb_ID.Text = Auto_Inc().ToString();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            cmb_Company_Name.SelectedIndex = -1;
            tb_Model_Name.Text = "";

            SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_Model_Name", CF.Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Model_Name_List.DataSource = dt;

            CF.Con_Close();
        }

        String Auto_Inc()
        {
            int Cnt = 0;
            String Var = "M-";

            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Model_Name) From  Add_Model_Name", CF.Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1 + Cnt;

            Cnt = 1 + Cnt;
            String count = Cnt.ToString();

            CF.Con_Close();

            return Var+count;
        }

       
    }
}
