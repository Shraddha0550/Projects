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

            try
            {
                SqlCommand cmd = new SqlCommand("Select Distinct(Company_Name) From Add_New_Product", CF.Con);

                var obj = cmd.ExecuteReader();
                cmb_Company_Name.Items.Clear();

                while (obj.Read())
                {
                    cmb_Company_Name.Items.Add(obj.GetString(obj.GetOrdinal("Company_Name")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
          
            CF.Con_Close();
        }

        private void cmb_Company_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            CF.Con_Open();

            try
            {
                cmb_Model_Name.Enabled = true;

                SqlCommand cmd = new SqlCommand("Select Model_Name From Add_New_Product Where Company_Name = '" + cmb_Company_Name.Text + "'", CF.Con);

                var obj = cmd.ExecuteReader();
                cmb_Model_Name.Items.Clear();

                while (obj.Read())
                {
                    cmb_Model_Name.Items.Add(obj.GetString(obj.GetOrdinal("Model_Name")));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }

            CF.Con_Close();

        }

        private void cmb_Model_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            CF.Con_Open();

            try
            {
                tb_Price.Enabled = true;
                SqlCommand cmd = new SqlCommand("Select *From Add_New_Product Where Company_Name = '" + cmb_Company_Name.Text + "' And Model_Name = '" + cmb_Model_Name.Text + "' ", CF.Con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Price.Text = obj["Sales_Price"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }
                obj.Close();
                cmd.Dispose();

                SqlCommand cmd1 = new SqlCommand("Select *From Add_New_Product Where Company_Name = '" + cmb_Company_Name.Text + "' And Model_Name = '" + cmb_Model_Name.Text + "' ", CF.Con);
                var obj1 = cmd1.ExecuteReader();

                if (obj1.Read())
                {
                    tb_Total_Stock.Text = obj1["Stock"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }
                obj1.Close();
                cmd1.Dispose();

                SqlCommand cmd2 = new SqlCommand("Select *From Add_Stock Where Company_Name = '" + cmb_Company_Name.Text + "' And Model_Name = '" + cmb_Model_Name.Text + "' ", CF.Con);
                var obj2 = cmd2.ExecuteReader();

                if (obj2.Read())
                {

                    tb_Prod_ID.Text = obj2["Prod_ID"].ToString();

                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
         
            CF.Con_Close();
        }

        private void btn_Total_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
                
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CF.Con_Open();
            try
            {
                if (tb_Customer_ID.Text != "" && cmb_Company_Name.Text != "" && cmb_Model_Name.Text != "" && tb_Stock_Quantity.Text != "" && tb_GST.Text != "" && tb_Total_Price.Text != "")
                {
                    int Total_Stock = Convert.ToInt32(tb_Total_Stock.Text);
                    int Quantity = Convert.ToInt32(tb_Stock_Quantity.Text);
                    int res = Total_Stock - Quantity;
                    SqlDataAdapter sda = new SqlDataAdapter("insert into Cust_Camera_Details values(" + tb_Customer_ID.Text + " , '" + dtp_Date.Text + "' , '" + cmb_Company_Name.Text + "','" + cmb_Model_Name.Text + "'," + tb_Price.Text + "," + tb_Stock_Quantity.Text + "," + tb_GST.Text + "," + tb_Total_Price.Text + "," + tb_Prod_ID.Text + "," + tb_Total_Stock.Text + ") Update Add_New_Product set Stock = " + res + "  where  Company_Name = '" + cmb_Company_Name.Text + "' AND Model_Name = '" + cmb_Model_Name.Text + "' ", CF.Con);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
               
            CF.Con_Close();
        }

        private void btn_Total_Bill_Click(object sender, EventArgs e)
        {
            try
            {
                double Rprice = 0;
                double Discount, Total, TPrice = 0;

                Rprice = double.Parse(tb_Bill.Text);
                Discount = double.Parse(tb_Discount.Text);

                Total = Rprice * (Discount / 100);
                TPrice = Rprice - Total;

                tb_Total_Bill.Text = TPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong...!!" + "\n\t" + ex.Message);
            }
          
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            CF.Con_Open();

            try
            {
                if (tb_Customer_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Discount.Text != "" && tb_Total_Bill.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Cust_Payment Values(" + tb_Customer_ID.Text + ",'" + tb_Name.Text + "','" + dtp_Date.Text + "'," + tb_Mobile_No.Text + ",'" + tb_Address.Text + "'," + tb_Bill.Text + "," + tb_Discount.Text + "," + tb_Total_Bill.Text + ")", CF.Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    MessageBox.Show("SuccesFully Added !! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sda.Dispose();
                    //Update_Stock();
                    clear_Text();
                    tb_Customer_ID.Text = Auto_Inc().ToString();
                    Refresh_Grid();


                }
                else
                {
                    MessageBox.Show("First Fill All Fields..!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
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
                SqlDataAdapter sda = new SqlDataAdapter("Select * From Cust_Camera_Details Where Cust_ID = " + tb_Customer_ID.Text + " ", CF.Con);

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

        private void tb_Price_TextChanged(object sender, EventArgs e)
        {
            tb_Stock_Quantity.Enabled = true;
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Stock_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void tb_GST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
    }
}
