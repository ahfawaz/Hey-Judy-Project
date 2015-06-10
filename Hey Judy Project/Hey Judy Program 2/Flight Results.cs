using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hey_Judy_Program_2
{
    public partial class Form2 : Form
    {
        public Form2(int pic_numb)
        {
            InitializeComponent();
            if (pic_numb == 1)
            {
                image1.Load("../../Resources/Image_1.png");
            }
            else if (pic_numb == 2)
            {
                image1.Load("../../Resources/Image_2.png");
            }
            image1.Update();

        }
    }
}
