using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Camera_House
{
    public partial class Log_In : Form
    {
        Connection_File CF = new Connection_File();
        public Log_In()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            CF.Con_Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from  Login where Username = '" + tb_Username.Text + "'  And  Password = '" + tb_Password.Text + "'  ", CF.Con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show(" Login Sucessfull !!");

                MDI_Camera_House obj = new MDI_Camera_House();

                obj.Show();
              

            }
            else
            {
                MessageBox.Show(" Invalid Username And Password ");
                tb_Password.Clear();
                tb_Username.Clear();
                tb_Username.Focus();

            }
            CF.Con_Close();
        }
    }
}
