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
    public partial class Add_New_Customer : Form
    {
        Connection_File CF = new Connection_File();
        public Add_New_Customer()
        {
            InitializeComponent();
        }

        private void Add_New_Customer_Load(object sender, EventArgs e)
        {
            Bind_Comapany_Name();
            tb_Customer_ID.Text = Auto_Inc().ToString();

        }

        int Auto_Inc()
        {
            int Cnt = 0;

            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Count(Cust_ID) From  Cust_Payment", CF.Con);

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            Cnt = 1001 + Cnt;

            CF.Con_Close();

            return Cnt;
        }

        void Bind_Comapany_Name()
        {
            CF.Con_Open();

            SqlCommand cmd = new SqlCommand("Select Distinct(Company_Name) From Add_New_Product",CF.Con);

            var obj = cmd.ExecuteReader();
            cmb_Company_Name.Items.Clear();

            while(obj.Read())
            {
                cmb_Company_Name.Items.Add(obj.GetString(obj.GetOrdinal("Company_Name")));
            }
            CF.Con_Close();
        }

        private void cmb_Company_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            CF.Con_Open();
            cmb_Model_Name.Enabled = true;

            SqlCommand cmd = new SqlCommand("Select Model_Name From Add_New_Product Where Company_Name = '" + cmb_Company_Name.Text + "'", CF.Con);

            var obj = cmd.ExecuteReader();
            cmb_Model_Name.Items.Clear();

            while(obj.Read())
            {
                cmb_Model_Name.Items.Add(obj.GetString(obj.GetOrdinal("Model_Name")));
            }

            CF.Con_Close();

        }

        private void cmb_Model_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            CF.Con_Open();
            tb_Price.Enabled = true;
            SqlCommand cmd = new SqlCommand("Select *From Add_New_Product Where Company_Name = '"+cmb_Company_Name.Text+"' And Model_Name = '"+cmb_Model_Name.Text+"' ",CF.Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Price.Text = obj["Sales_Price"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }

            CF.Con_Close();
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            double Price = double.Parse(tb_Price.Text);
            int Quantity = Convert.ToInt32(tb_Stock_Quantity.Text);

            double res = Price * Quantity;
            int GST = Convert.ToInt32(tb_GST.Text);

            double CGST = res * GST / 100;
            double SGST = CGST;

            double Tax = CGST + SGST;
            double Total = res + Tax;

            tb_Total_Price.Text = Total.ToString();
                
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            if(tb_Customer_ID.Text != "" && cmb_Company_Name.Text != "" && cmb_Model_Name.Text != "" && tb_Stock_Quantity.Text != "" && tb_GST.Text != "" && tb_Total_Price.Text != "")
            {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into Cust_Camera_Details values("+tb_Customer_ID.Text+" , '"+dtp_Date.Text+"' , '"+cmb_Company_Name.Text+"','"+cmb_Model_Name.Text+"',"+tb_Price.Text+","+tb_Stock_Quantity.Text+","+tb_GST.Text+","+tb_Total_Price.Text+") ", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("SuccesFully Added !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else
            {
                     MessageBox.Show("First Fill All Fields..!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }


            SqlDataAdapter sda1 = new SqlDataAdapter("Select * From Cust_Camera_Details Where Cust_ID = " + tb_Customer_ID.Text + "", CF.Con);

            DataTable dt1 = new DataTable();

            sda1.Fill(dt1);

            dgv_Product_List.DataSource = dt1;

                int Price = Convert.ToInt32(tb_Total_Price.Text);
                if (tb_Bill.Text == "")
                {
                    tb_Bill.Text = Price.ToString();
                }
                else
                {
                    int Bill = Convert.ToInt32(tb_Bill.Text);
                    int Res = Price + Bill;
                    tb_Bill.Text = Res.ToString();
                }
               
            CF.Con_Close();
        }

        private void btn_Total_Bill_Click(object sender, EventArgs e)
        {
            double Rprice = 0;
            double Discount, Total, TPrice = 0;

            Rprice = double.Parse(tb_Bill.Text);
            Discount = double.Parse(tb_Discount.Text);

            Total = Rprice * (Discount / 100);
            TPrice = Rprice - Total;

            tb_Total_Bill.Text = TPrice.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            if(tb_Customer_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Discount.Text != "" && tb_Total_Bill.Text != "")
            {
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Cust_Payment Values("+tb_Customer_ID.Text+",'"+tb_Name.Text+"','"+dtp_Date.Text+"',"+tb_Mobile_No.Text+",'"+tb_Address.Text+"',"+tb_Bill.Text+","+tb_Discount.Text+","+tb_Total_Bill.Text+")", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("SuccesFully Added !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Text();
                    tb_Customer_ID.Text = Auto_Inc().ToString();
                     Refresh_Grid();

            }
            else
            {
                    MessageBox.Show("First Fill All Fields..!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

          

            CF.Con_Close();
        }

        void Refresh_Grid()
        {
            CF.Con_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * From Cust_Camera_Details Where Cust_ID = " + tb_Customer_ID.Text + " ", CF.Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Product_List.DataSource = dt;

            CF.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            clear_Text();
        }

        public void clear_Text()
        {
            tb_Address.Text = "";
            tb_Bill.Text = "";
            dtp_Date.Text = "";
            tb_Discount.Text = "";
            tb_GST.Text = "";
            tb_Mobile_No.Text = "";
            tb_Name.Text = "";
            tb_Price.Text = "";
            tb_Stock_Quantity.Text = "";
            tb_Total_Bill.Text = "";
            tb_Total_Price.Text = "";
            cmb_Company_Name.SelectedIndex = -1;
            cmb_Model_Name.SelectedIndex = -1;
        }

        private void tb_Stock_Quantity_TextChanged(object sender, EventArgs e)
        {
            tb_GST.Enabled = true;
        }

        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            btn_Total.Enabled = true;
        }

        private void tb_Total_Price_TextChanged(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            btn_Total_Bill.Enabled = true;
        }

        private void tb_Total_Bill_TextChanged(object sender, EventArgs e)
        {
            btn_Save.Enabled = true;
        }
    }
}
