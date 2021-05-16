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
    public partial class Add_Company_Name : Form
    {
        Connection_File CF = new Connection_File();

        public Add_Company_Name()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            if (tb_ID.Text != "" && tb_Company_Name.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("insert into Add_Company_Name(ID,Company_Name) Values('" + tb_ID.Text + "' , '" + tb_Company_Name.Text + "')", CF.Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                MessageBox.Show("SuccesFully Added !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Company_Name.Text = "";
                tb_ID.Text = Auto_Inc().ToString();
              
                tb_ID.Focus();
            }
            else
            {
                MessageBox.Show("First Fill All Fields..!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CF.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CF.Con_Open();
            tb_Company_Name.Text = "";

            tb_ID.Focus();

            SqlDataAdapter sda = new SqlDataAdapter("Select * From Add_Company_Name ",CF.Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Company_Name_List.DataSource = dt;

            CF.Con_Close();
        }

        String Auto_Inc()
        {
            int Cnt = 0;
            String Var = "C-";

            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Company_Name) From  Add_Company_Name", CF.Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1 + Cnt;
            String count = Cnt.ToString();
          

            CF.Con_Close();

            return Var+count;
        }

        private void Add_Company_Name_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Auto_Inc().ToString();
        }
    }
}
