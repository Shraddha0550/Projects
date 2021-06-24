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
    public partial class View_All_Rooms : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\EXPRESS;Initial Catalog=Lodging_Managment_System_DB;Integrated Security=True");


        public View_All_Rooms()
        {
            InitializeComponent();
        }

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

        private void btn_Add_Room_Click(object sender, EventArgs e)
        {
            Add_Room obj = new Add_Room();

            obj.MdiParent = this.MdiParent;
           
            obj.Show();
            this.Close();
        }

        private void View_All_Rooms_Load(object sender, EventArgs e)
        {
            Con_Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Rooms", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
            Con_Close();
        
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
