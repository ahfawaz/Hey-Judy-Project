using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Call_System
{
    public partial class Form1 : Form
    {
        public SoundPlayer RingTone;
        public SoundPlayer HangUp;
        public SoundPlayer Song;

        public Form1()
        {
            InitializeComponent();
            Main_Screen.Visible = false;
            Login_Screen.Dock = DockStyle.Fill;
            Delay_Tick.Stop();
            Call_Timer.Stop();
            Program_Timer.Stop();
            RingTone = new SoundPlayer("../../Resources/telephone ring.wav");
            HangUp = new SoundPlayer("../../Resources/Hang Up.wav");
            //Song = new SoundPlayer("../../Resources/DJ_Sona_Ethereal_Nosaj_Thing_x_Pretty_Lights.wav");
            //Song.Play();
        }

        #region Login Screen
        //Login Members
        public bool bInfo = false;
        private bool bLogin_Correct = false;

        public bool BLogin_Correct
        {
            get { return bLogin_Correct; }
            set { bLogin_Correct = value; }
        }

        //Login Functions
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            if (bInfo)
            {
                this.Login_Data.Clear();
                this.Password_Data.Clear();
                Invalid_Info.Visible = false;
                bInfo = false;
            }
            else
                this.Close();
        }

        private void Login_Info(object sender, EventArgs e)
        {
            bInfo = true;
        }

        private void Admin_Override_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Login_Screen.Enabled = false;
            Admin_Override form2 = new Admin_Override();
            int _data = -1;
            form2.Enabled = true;
            form2.ShowDialog();
            _data = form2.Override;

            if (_data == 1)
            {
                //Deactivate the Login Screen
                Login_Screen.Visible = false;
                Login_Screen.Dock = DockStyle.None;
                Login_Screen.Enabled = false;

                //Activate the Main Screen
                Main_Screen.Enabled = true;
                Main_Screen.Dock = DockStyle.Fill;
                Main_Screen.Visible = true;
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (!UserID_Check(Login_Data.Text) || !Password_Check(Password_Data.Text))
            {
                this.Login_Data.Clear();
                this.Password_Data.Clear();
                Invalid_Info.Visible = true;
                bInfo = false;
                return;
            }

            else
            {
                //Deactivate the Login Screen
                Login_Screen.Visible = false;
                Login_Screen.Dock = DockStyle.None;
                Login_Screen.Enabled = false;

                //Activate the Main Screen
                Main_Screen.Enabled = true;
                Main_Screen.Dock = DockStyle.Fill;
                Main_Screen.Visible = true;
            }
        }

        private bool UserID_Check(string _ID)
        {
            string UserID_Check = "112233";
            for (int i = 0; i < 5; i++)
            {
                if (_ID == UserID_Check)
                    return true;
            }

            return false;
        }

        private bool Password_Check(string _ID)
        {
            string UserID_Check = "112233";
            for (int i = 0; i < 5; i++)
            {
                if (_ID == UserID_Check)
                    return true;
               
            }

            return false;
        }
        private void Login_Button_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Login_Button_Click(sender, e);
        }
        #endregion


        public int nDuration = 0;
        public int nStart_Time;
        public int nEnd_Time;
        public int nDelay_Time = 15000;
        public int nPTimer; //Used for misc items in the program. (Reusable)
        public string CallerID = "Unknown Caller";
        public string CallerNumb = "1 888 888 8888";
        public bool bWaiting = false;
        public bool bStartAt = false;
        public bool bCalling = false;
        public bool bInCall = false;
        public bool bEndless = false;
        public bool bCallEnded = false;

        private void End_Call_Transition()
        {
            Call_Img.Visible = false;
            Call_Text.Location = new Point(272, 117);
            Call_Text.Text = "Call Ended";
            Call_Timer.Stop();
            Program_Timer.Start();
            nPTimer = 0;
            bCallEnded = true;
            Caller_Info.Visible = true;
            Call_Duration.Visible = true;
            End_Button.Enabled = false;
            RingTone.Stop();
            HangUp.PlayLooping();
           
        }

        private void Update_Duration_Timer()
        {
            int total_secs = nDuration / 1000;
            int total_mins = total_secs / 60;
            int total_hours = total_mins / 60;
            int corrected_mins = total_mins - (total_hours * 60);
            int corrected_secs = total_secs - (total_mins * 60);

            string secs = "00", mins = "00", hours = "00";

            if (corrected_secs < 10 && corrected_secs > 0)
                secs = "0" + corrected_secs.ToString();
            else if (corrected_secs >= 10)
                secs = corrected_secs.ToString();

            if (corrected_mins < 10 && corrected_mins > 0)
                mins = "0" + corrected_mins.ToString();
            else if (corrected_mins >= 10)
                mins = corrected_mins.ToString();

            if (total_hours < 10 && total_hours > 0)
                hours = "0" + total_hours.ToString();
            else if (total_hours >= 10)
                hours = total_hours.ToString();

            Call_Duration.Text = hours + " : " + mins + " : " + secs;
        }

        private void Call_Timer_Tick(object sender, EventArgs e)
        {
            nDuration += Call_Timer.Interval;
            Update_Duration_Timer();

            if (bEndless == false && nDuration >= nEnd_Time)
            {
                End_Call_Transition();
            }
        }

        private void Update_Delay_Time()
        {
            if (nPTimer > 0)
            {
                int total_mins = nPTimer / 60000;
                int total_secs = nPTimer / 1000 - total_mins * 60;
                Delay_Timer.Text = "Delay Time: " + total_mins.ToString() + " : " + total_secs.ToString();
            }
            else
            {
                Delay_Timer.Visible = false;
                Call_Text.Visible = true;
                Caller_Info.Visible = true;

                //If we're not starting in the middle of a call.
                if (bStartAt == false)
                {
                    bCalling = true;

                    //Call Text is now visible and saying there is a call coming in.
                    Call_Text.Text = "Incoming Call...";
                    Call_Text.Location = new Point(254, 117);

                    //Caller info is now visible to the operator
                    Caller_Info.Location = new Point(254, 249);
                    Caller_Info.Text = CallerID + "\n\n" + CallerNumb;

                    //Change the call button text to answer and make ingore available
                    End_Button.Enabled = true;
                    RingTone.PlayLooping();
                }
                else
                {
                    //We're now in the call, let the duration time know to keep an eye on the time.
                    //if duration_limit is 0 then the time is unlimited.
                    Call_Text.Text = "In Call";
                    Call_Text.Location = new Point(300, 117);
                    Call_Timer.Start();
                    Call_Duration.Visible = true;

                    Caller_Info.Location = new Point(248, 149);
                    Caller_Info.Text = CallerID + "\n" + CallerNumb;
                    Answer_Button.Enabled = false;

                    nDuration = nStart_Time;
                    Update_Duration_Timer();

                    //Let the program know that it's in a call atm.
                    bInCall = true;
                }

                //Stop showing the waiting for call text
                Wait_Text.Visible = false;

                //Reset this timer for later use.
                nPTimer = 0;

                Delay_Tick.Stop();
                
            }

        }

        //We're updating the information to let the program know when to start a call and at what time.
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(bWaiting)
            {
                Delay_Tick.Stop();
            }

            DialogResult result;
            Next_Call_Setup form2 = new Next_Call_Setup();
            form2.Enabled = true;
            result = form2.ShowDialog();

            if (result == DialogResult.OK)
            {
                CallerID = form2.sCall_ID;
                CallerNumb = form2.sCall_Numb;
                nEnd_Time = form2.nCall_Duration;
                nStart_Time = form2.nStart_Time;
                nDelay_Time = form2.nDelay_Time;
                nPTimer = nDelay_Time;

                Delay_Tick.Start();
                Delay_Timer.Visible = true;
                Update_Delay_Time();
                bWaiting = true;

                if (nStart_Time > 0)
                    bStartAt = true;
                if (nEnd_Time == 0)
                    bEndless = true; 
            }

            if(bWaiting && result == DialogResult.Cancel)
            {
                Delay_Tick.Start();
            }

        }

        private void Delay_Tick_Tick(object sender, EventArgs e)
        {
            nPTimer -= Delay_Tick.Interval;
            Update_Delay_Time();
        }

        private void Answer_Button_Click(object sender, EventArgs e)
        {
            if (bWaiting)
            {
                //We're now in the call, let the duration time know to keep an eye on the time.
                //if duration_limit is 0 then the time is unlimited.
                Call_Text.Text = "In Call";
                Call_Text.Location = new Point(300, 117);
                Call_Timer.Start();
                Call_Duration.Visible = true;
                Call_Img.Visible = true;

                Caller_Info.Location = new Point(248, 149);
                Caller_Info.Text = CallerID + "\n" + CallerNumb;
                Answer_Button.Enabled = false;

                //Let the program know that it's in a call atm.
                bInCall = true;
                bCalling = false;
                RingTone.Stop();
            }
            else
            {
                bWaiting = true;
                nPTimer = nDelay_Time;
                Delay_Tick.Start();
                Delay_Timer.Visible = true;
                Update_Delay_Time();

                if (nStart_Time > 0)
                    bStartAt = true;
                if (nEnd_Time == 0)
                    bEndless = true;
            }
        }

        private void Update_End_Call()
        {
            Caller_Info.Visible = !Caller_Info.Visible;
            Call_Duration.Visible = !Call_Duration.Visible;

            if (nPTimer >= 5000)
            {
                Program_Timer.Stop();
                Call_Text.Visible = false;
                Caller_Info.Visible = false;
                Call_Duration.Visible = false;
                Answer_Button.Enabled = true;
                Wait_Text.Visible = true;
                bCalling = false;
                bInCall = false;
                bCallEnded = false;
                bWaiting = false;
                HangUp.Stop();
            }
        }

        private void Program_Timer_Tick(object sender, EventArgs e)
        {
            nPTimer += Program_Timer.Interval;

            if (bCallEnded)
                Update_End_Call();
        }

        private void End_Button_Click(object sender, EventArgs e)
        {
            RingTone.Stop();
            End_Call_Transition();
        }

    }
}
