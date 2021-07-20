using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safeway_FX_Trader
{
    public partial class frm_Add_User : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\express;Initial Catalog=Safeway_FX_Trader_db;Integrated Security=True");

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

        public frm_Add_User()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Con.Open();

            if(tb_Id.Text != "" && tb_Refer_Id.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && tb_Mail.Text != "" && tb_Adhar_No.Text != "")
            {

                SqlDataAdapter sda = new SqlDataAdapter("insert into Add_User Values("+tb_Id.Text+","+tb_Refer_Id.Text+",'"+tb_Name.Text+"',"+tb_Mob_No.Text+",'"+tb_Mail.Text+"',"+tb_Adhar_No.Text+")",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Succesfull");
                tb_Id.Text = Convert.ToString(Auto_Incr());
                Refresh();
            }
            else if(tb_Id.Text != ""  && tb_Name.Text != "" && tb_Mob_No.Text != "" && tb_Mail.Text != "" && tb_Adhar_No.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("insert into Add_User(ID,Name,Mob_No,E_Mail,Adhar_No) Values(" + tb_Id.Text + ",'" + tb_Name.Text + "'," + tb_Mob_No.Text + ",'" + tb_Mail.Text + "'," + tb_Adhar_No.Text + ")", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Succesfull");
                tb_Id.Text = Convert.ToString(Auto_Incr());
                Refresh();
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!");
            }

            Con.Close();
        }

        private void frm_Add_User_Load(object sender, EventArgs e)
        {
            tb_Id.Text = Convert.ToString(Auto_Incr());
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(ID) From  Add_User", Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1 + Cnt;

            Con_Close();

            return Cnt;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
            Refresh();
        }

        public void Refresh()
        {
            tb_Adhar_No.Clear();
            tb_Mail.Clear();
            tb_Mob_No.Clear();
            tb_Name.Clear();
            tb_Refer_Id.Clear();
        }
    }
}
