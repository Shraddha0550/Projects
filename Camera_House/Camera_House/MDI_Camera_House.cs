using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Camera_House
{
    public partial class MDI_Camera_House : Form
    {
        private int childFormNumber = 0;

        public MDI_Camera_House()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btn_Customer_MouseHover(object sender, EventArgs e)
        {
            pnl_Customer.Visible = true;
            pnl_Employee.Visible = false;
            pnl_Product.Visible = false;
            pnl_Stock.Visible = false;
            pnl_Distrubutor.Visible = false;
        }

        private void btn_Employee_MouseHover(object sender, EventArgs e)
        {
            pnl_Employee.Visible = true;
            pnl_Customer.Visible = false;
            pnl_Product.Visible = false;
            pnl_Stock.Visible = false;
            pnl_Distrubutor.Visible = false;
        }

        private void btn_Product_MouseHover(object sender, EventArgs e)
        {
            pnl_Product.Visible = true;
            pnl_Employee.Visible = false;
            pnl_Customer.Visible = false;
            pnl_Stock.Visible = false;
            pnl_Distrubutor.Visible = false;
        }
        public void hidepanel()
        {
            pnl_Product.Visible = false;
            pnl_Employee.Visible = false;
            pnl_Customer.Visible = false;
            pnl_Stock.Visible = false;
            pnl_Distrubutor.Visible = false;
        }
        private void btn_Stock_MouseHover(object sender, EventArgs e)
        {
            pnl_Distrubutor.Visible = false;
            pnl_Product.Visible = false;
            pnl_Employee.Visible = false;
            pnl_Customer.Visible = false;
            pnl_Stock.Visible = true;
        }

        private void btn_Distrubutor_MouseHover(object sender, EventArgs e)
        {
            pnl_Distrubutor.Visible = true;
            pnl_Product.Visible = false;
            pnl_Employee.Visible = false;
            pnl_Customer.Visible = false;
            pnl_Stock.Visible = false;
        }
       

        private void btn_Add_New_Customer_Click(object sender, EventArgs e)
        {
            Add_New_Customer obj = new Add_New_Customer();
            obj.MdiParent = this;
           // obj.WindowState = FormWindowState.Maximized;
            obj.Show();
            hidepanel();
        }

        private void btn_Update_Customer_Details_Click(object sender, EventArgs e)
        {
            Update_Customer obj = new Update_Customer();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Search_Customer_Click(object sender, EventArgs e)
        {
            Search_Customer obj = new Search_Customer();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_View_All_Customer_Click(object sender, EventArgs e)
        {
            View_All_Customer obj = new View_All_Customer();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            Add_New_Employee obj = new Add_New_Employee();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Update_Employee_Details_Click(object sender, EventArgs e)
        {
            Update_Employee obj = new Update_Employee();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Search_Employee_Click(object sender, EventArgs e)
        {
            Search_Employee obj = new Search_Employee();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_View_All_Employee_Click(object sender, EventArgs e)
        {
            View_All_Employee obj = new View_All_Employee();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Remove_Employee_Click(object sender, EventArgs e)
        {
            Remove_Employee obj = new Remove_Employee();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            Add_New_Product obj = new Add_New_Product();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Update_Product_Details_Click(object sender, EventArgs e)
        {
            Update_Product obj = new Update_Product();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();

        }

        private void btn_Search_Product_Click(object sender, EventArgs e)
        {
            Search_Product obj = new Search_Product();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_View_All_Product_Click(object sender, EventArgs e)
        {
            View_All_Stocks obj = new View_All_Stocks();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Remove_Product_Click(object sender, EventArgs e)
        {
            Remove_Product obj = new Remove_Product();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Add_Compony_Name_Click(object sender, EventArgs e)
        {
            Add_Company_Name obj = new Add_Company_Name();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Add_Model_Name_Click(object sender, EventArgs e)
        {
            Add_Model_Name obj = new Add_Model_Name();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Add_Distrubutor_Click(object sender, EventArgs e)
        {
            Distrubutor_Details obj = new Distrubutor_Details();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void Btn_Add_Stock_Click(object sender, EventArgs e)
        {
            Add_Stock obj = new Add_Stock();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

        private void btn_Stock_Details_Click(object sender, EventArgs e)
        {
            View_Stock obj = new View_Stock();
            obj.MdiParent = this;
            obj.Show();
            hidepanel();
        }

       

       
    }
}