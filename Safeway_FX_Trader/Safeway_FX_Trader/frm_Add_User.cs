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
            int count = 0;
            int Cnt = 0;

            if (tb_Id.Text != "" && tb_Refer_Id.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && tb_Mail.Text != "" )
            {

                Cnt = Convert.ToInt32(textBox1.Text) + 1;

                SqlDataAdapter sda = new SqlDataAdapter("insert into Add_User(ID,Refer_ID,Name,Mob_No,E_Mail) Values(" + tb_Id.Text+","+tb_Refer_Id.Text+",'"+tb_Name.Text+"',"+tb_Mob_No.Text+",'"+tb_Mail.Text+"')Update Add_User set Count = "+ Cnt + "  where ID="+tb_Refer_Id.Text+" ",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Succesfull");
             
                tb_Id.Text = Convert.ToString(Auto_Incr());
                Refresh();

            }
            else if(tb_Id.Text != ""  && tb_Name.Text != "" && tb_Mob_No.Text != "" && tb_Mail.Text != "" )
            {

                SqlDataAdapter sda = new SqlDataAdapter("insert into Add_User(ID,Name,Mob_No,E_Mail,Count) Values(" + tb_Id.Text + ",'" + tb_Name.Text + "'," + tb_Mob_No.Text + ",'" + tb_Mail.Text + "',"+count+")", Con);
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
            tb_Mail.Clear();
            tb_Mob_No.Clear();
            tb_Name.Clear();
            tb_Refer_Id.Clear();
        }

        private void tb_Refer_Id_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Refer_Id.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * From Add_User where ID = " + tb_Refer_Id.Text + " ", Con);

                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {

                    textBox1.Text = obj["Count"].ToString();

                }
            }

            Con_Close();
        }
    }
}
