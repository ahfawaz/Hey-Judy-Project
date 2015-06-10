using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Call_System
{
    public partial class Next_Call_Setup : Form
    {
        public int nCall_Duration;
        public int nStart_Time;
        public int nDelay_Time;
        public string sCall_ID;
        public string sCall_Numb;

        public Next_Call_Setup()
        {
            InitializeComponent();

            sCall_ID = CallerID.Text;
            sCall_Numb = CallerNumber.Text;
            Update_Delay();
            Update_Duration();
            Update_StartAt();
        }


        void Update_Delay()
        {
            decimal temp = 0;
            temp = WaitTime_Mins.Value * 60 + WaitTime_Secs.Value;
            temp = temp * 1000;
            nDelay_Time = (int)temp;
        }

        private void WaitTime_Secs_ValueChanged(object sender, EventArgs e)
        {
            if (WaitTime_Secs.Value == 60)
            {
                WaitTime_Mins.Value++;
                WaitTime_Secs.Value = 0;
            }

            else if (WaitTime_Secs.Value == -1 && WaitTime_Mins.Value > 0)
            {
                WaitTime_Mins.Value--;
                WaitTime_Secs.Value = 59;
            }

            Update_Delay();
            this.Update();
        }

        //Make sure the other events don't step on each other's toes while this function is runnign
        private bool bWorking = false;
        
        void Update_Duration()
        {
            decimal temp = 0;
            temp = Duration_Hours.Value * 60 + Duration_Mins.Value;
            temp = temp * 60 + Duration_Secs.Value;
            temp = temp * 1000;
            nCall_Duration = (int)temp;
        }

        private void Duration_Changed(object sender, EventArgs e)
        {
            if (!bWorking)
            {
                bWorking = true;
                if (Duration_Secs.Value == 60)
                {
                    Duration_Mins.Value++;
                    Duration_Secs.Value = 0;
                }

                else if (Duration_Secs.Value == -1)
                {
                    Duration_Mins.Value--;
                    Duration_Secs.Value = 59;
                }

                if (Duration_Mins.Value == 60)
                {
                    Duration_Hours.Value++;
                    Duration_Mins.Value = 0;
                }

                else if (Duration_Mins.Value == -1)
                {
                    Duration_Hours.Value--;
                    Duration_Mins.Value = 59;
                }

                if (Duration_Hours.Value == -1)
                {
                    Duration_Hours.Value = Duration_Mins.Value = Duration_Secs.Value = 0;
                }
                Update_Duration();
                bWorking = false;
            }
        }

        void Update_StartAt()
        {
            decimal temp = 0;
            temp = StartAt_Hours.Value * 60 + StartAt_Mins.Value;
            temp = temp * 60 + StartAt_Secs.Value;
            temp = temp * 1000;
            nStart_Time = (int)temp;
        }
        private void TimeStart_Changed(object sender, EventArgs e)
        {
            if (!bWorking)
            {
                bWorking = true;
                if (StartAt_Secs.Value == 60)
                {
                    StartAt_Mins.Value++;
                    StartAt_Secs.Value = 0;
                }

                else if (StartAt_Secs.Value == -1)
                {
                    StartAt_Mins.Value--;
                    StartAt_Secs.Value = 59;
                }

                if (StartAt_Mins.Value == 60)
                {
                    StartAt_Hours.Value++;
                    StartAt_Mins.Value = 0;
                }

                else if (StartAt_Mins.Value == -1)
                {
                    StartAt_Hours.Value--;
                    StartAt_Mins.Value = 59;
                }

                if (StartAt_Hours.Value == -1)
                {
                    StartAt_Hours.Value = StartAt_Mins.Value = StartAt_Secs.Value = 0;
                }
                Update_StartAt();
                bWorking = false;
            }
        }

        private void CallerNumber_TextChanged(object sender, EventArgs e)
        {
            sCall_ID = CallerID.Text;
            sCall_Numb = CallerNumber.Text;
        }
    }
}
