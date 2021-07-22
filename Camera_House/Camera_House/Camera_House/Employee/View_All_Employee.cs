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
    public partial class View_All_Employee : Form
    {
        Connection_File CF = new Connection_File();
        public View_All_Employee()
        {
            InitializeComponent();
        }

        private void View_All_Employee_Load(object sender, EventArgs e)
        {
            CF.Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select *From Add_New_Employee", CF.Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Employee_List.DataSource = dt;

            CF.Con_Close();
        }
    }
}
