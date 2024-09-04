using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Login.Views.Usuarios
{
    public partial class frm_Usuarios : Form
    {
        SerialPort _arduino;
        string codigo="";
        public frm_Usuarios()
        {
            InitializeComponent();
            _arduino = new SerialPort();
            _arduino.PortName = "COM4";
            _arduino.BaudRate = 9600;
            _arduino.Open();


        }

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void frm_Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_arduino.IsOpen) {
                _arduino.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_arduino.Write("E");
            
            txt_nombre.Text = _arduino.Read().ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            _arduino.Write("F");
        }
    }
}
