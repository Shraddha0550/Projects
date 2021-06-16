using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lodging_Managment_System.Gallary
{
    public partial class Image_Gallary : Form
    {
        int i = 0;
        public Image_Gallary()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            i++;

            if (i > 7)
            {
                i = 1;
            }
            changeImage(i);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            i--;

            if (i < 1)
            {
                i = 6;
            }
            changeImage(i);
        }

        private void changeImage(int num)
        {
            switch (num)
            {
                case 1:
                   pictureBox1.Image = Properties.Resources.img_1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.img_2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.img_6;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.img_10;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.img_2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.img_1;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.img_7;
                    break;

            }

        }
    }
}
