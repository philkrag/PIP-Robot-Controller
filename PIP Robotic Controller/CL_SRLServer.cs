using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIP_Robotic_Controller
{
    // ////////////////////////////////////////////////////////////

    // VERSION: 1.1
    // Created: 2018-08-21

    // Modifications:
    // 2018-08-21 :- Created.

    // ////////////////////////////////////////////////////////////

    class CL_SRLServer
    {

        //var reader = new Serial_Reader("COM3");

        public static string[] List_Com_Ports()
        {
            // Get a list of serial port names. 
            string[] List_Ports = SerialPort.GetPortNames();

            //Console.WriteLine("The following serial ports were found:");
            //string[] List_Ports = new string[ports];

            // Display each port name to the console. 
            //foreach (string port in List_Ports)
            //{
            //    //Console.WriteLine(port);
            //}

            return List_Ports;
        }

        private static SerialPort Serial_Port;

        public static void Serial_Reader(string portName)
        {
            
                Serial_Port = new SerialPort(portName);
                Serial_Port.Open();
                //CL_Global_Variables.Port_Connection_Made = true;
                CL_Global_Variables.Serial_Connected = true;
                Serial_Port.DataReceived += Serial_Port_DataReceived;
            
        }

        static void Serial_Port_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            
                CL_Global_Variables.Received_Message = Serial_Port.ReadLine();
            
        }

        public static void Dispose()
        {
            if (Serial_Port != null)
            {
                Serial_Port.Dispose();
                CL_Global_Variables.Serial_Connected = false;
            }
        }



    }
}
