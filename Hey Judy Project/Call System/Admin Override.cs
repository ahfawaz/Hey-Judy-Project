using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Call_System;

namespace Call_System
{
    public partial class Admin_Override : Form
    {
        public int Override;

        public Admin_Override()
        {
            InitializeComponent();
            Override = 0;
        }

        private bool button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text.Length == 0)
            {
                Error_Message.Visible = true;
                return false;
            }

            return true;
        }

        private void Admin_Button_Clicked(object sender, EventArgs e)
        {
            if (sender == button1)
           {
               if (this.textBox1.Text.Length == 0)
               {
                   Error_Message.Visible = true;
                   return;
               }
               else
               {
                   Override = 1;
                   Override_Value();
                   Close();
               }
           }
            else if (sender == button2)
           {
               Override = 0;
               Override_Value();
               Close();
           }

        }

        public int Override_Value()
        {
            return Override;
        }
    }
}
