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
    public partial class FRM_Manual_Control : Form
    {
        public FRM_Manual_Control()
        {
            InitializeComponent();
        }

        

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            HSB_YAxis_Control.Value = 256;
            VSB_XAxis_Control.Value = 256;
        }

        private void HSB_YAxis_Control_ValueChanged(object sender, EventArgs e)
        {
            CL_Global_Variables.Y_Manual_Control = HSB_YAxis_Control.Value;
        }

        private void VSB_XAxis_Control_ValueChanged(object sender, EventArgs e)
        {
            CL_Global_Variables.X_Manual_Control = VSB_XAxis_Control.Value;
        }
    }
}
