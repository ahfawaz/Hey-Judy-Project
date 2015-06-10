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
    public partial class Form1 : Form
    {
        private Form2 Image_Screen = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void OneWay_CheckedChanged(object sender, EventArgs e)
        {
            if(OneWay.Checked)
            {
                ReturnDate.Enabled = false;
            }
        }

        private void RoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (RoundTrip.Checked)
            {
                ReturnDate.Enabled = true;
            }
        }

        private void Points_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            Image_Screen = new Form2(1);
            Image_Screen.Show();
        }

        private void Available_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(2000);
            Image_Screen = new Form2(2);
            Image_Screen.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            count += 0;
        }
    }
}
