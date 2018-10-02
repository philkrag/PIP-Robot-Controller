using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIP_Robotic_Controller
{
    public partial class Form1 : Form
    {
        int Push_Button_1_Current = 000;
        int Push_Button_1_Memory = 000;

        int X_Axis_Current = 256;
        int X_Axis_Memory = 256;

        int Y_Axis_Current = 256;
        int Y_Axis_Memory = 256;


        public Form1()
        {
            InitializeComponent();
        }


        private int Invert(int input)
        {
            int value = 256;
            if (input < 256)
            {
                value = 256 + (256 - input);
            }
            else
            {
                value = 256 - (input - 256);
            }

            return value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string[] Message_Breakdown = CL_Global_Variables.Received_Message.Split(':');

            try
            {                
                CL_Global_Variables.Push_Button_1 = Convert.ToInt32(Message_Breakdown[0]);
                CL_Global_Variables.X_Manual_Control = Convert.ToInt32(Message_Breakdown[1])/2;
                CL_Global_Variables.Y_Manual_Control = Convert.ToInt32(Message_Breakdown[2])/2;
            }
            catch { }


            Push_Button_1_Current = CL_Global_Variables.Push_Button_1;
            X_Axis_Current = CL_Global_Variables.X_Manual_Control;
            Y_Axis_Current = CL_Global_Variables.Y_Manual_Control;

            bool Change_Flag = false;

            if (Push_Button_1_Current != Push_Button_1_Memory)
            {
                Push_Button_1_Memory = Push_Button_1_Current;
                Change_Flag = true;
            }

            if (X_Axis_Current!= X_Axis_Memory)
            {                
                X_Axis_Memory = X_Axis_Current;
                Change_Flag = true;
            }

            if (Y_Axis_Current != Y_Axis_Memory)
            {
                Y_Axis_Memory = Y_Axis_Current;
                Change_Flag = true;
            }

            if (Change_Flag)
            {
                CL_TCPClient.Connect("002:001:" + X_Axis_Current.ToString().PadLeft(3, '0') + ":"+ Y_Axis_Current.ToString().PadLeft(3, '0') + ":256:"+ Push_Button_1_Current.ToString().PadLeft(3, '0'));
                Change_Flag = false;
            }



            }

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
        FRM_Manual_Control FRM_Manual_Control = new FRM_Manual_Control();
            FRM_Manual_Control.Show();
        }

        private void NUD_Repsonse_Timer_ValueChanged(object sender, EventArgs e)
        {
            TMR_Sample_Engine.Interval = Convert.ToInt32(NUD_Repsonse_Timer.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BW_Serial_Engine.RunWorkerAsync();
            CMB_Port_Listing.Items.AddRange(CL_SRLServer.List_Com_Ports());
            BW_Serial_Engine.RunWorkerAsync();
        }

        


        private void BTN_Refresh_Ports_Click(object sender, EventArgs e)
        {
            CMB_Port_Listing.Items.AddRange(CL_SRLServer.List_Com_Ports());
        }

        private void TMR_Display_Engine_Tick(object sender, EventArgs e)
        {

            if (CL_Global_Variables.BW_Serial_Engine_Running)
            { pictureBox1.BackColor = Color.Blue; }
            else
            { pictureBox1.BackColor = Color.White; }

            textBox2.Text = CL_Global_Variables.Received_Message;
            textBox1.Text = CL_Global_Variables.Selected_Com_Port;

            if (CL_Global_Variables.Serial_Connected) { IND_Serial_Connected.BackColor = Color.Green; }
            else { IND_Serial_Connected.BackColor = Color.Red; }
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            if (!CL_Global_Variables.BW_Serial_Engine_Running)
            {
                CL_Global_Variables.BW_Serial_Engine_Running = true;
            }
            else
            {
                CL_Global_Variables.BW_Serial_Engine_Running = false;
            }
        }

        private void BW_Serial_Engine_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BW_Serial_Engine.RunWorkerAsync();

        }

        private void BW_Serial_Engine_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BW_Serial_Engine_DoWork(object sender, DoWorkEventArgs e)
        {

            if (CL_Global_Variables.BW_Serial_Engine_Running)
            {
                if (!CL_Global_Variables.Serial_Connected) {
                    CL_SRLServer.Serial_Reader(CL_Global_Variables.Selected_Com_Port);
                    //CL_SRLServer.Serial_Reader("COM4");
                }
            }
            else
            {
                if (CL_Global_Variables.Serial_Connected)
                {
                    CL_SRLServer.Dispose();
                }
            }
        }

        private void CMB_Port_Listing_SelectedIndexChanged(object sender, EventArgs e)
        {
            CL_Global_Variables.Selected_Com_Port = CMB_Port_Listing.Text;
        }
    }
}
