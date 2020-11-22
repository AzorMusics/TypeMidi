using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midi;

namespace TypeMidi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach(InputDevice input in InputDevice.InstalledDevices)
            {
                comboBox1.Items.Add(input.Name);
            }
        }

        public InputDevice inputDevice;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                inputDevice = Midi.InputDevice.InstalledDevices[comboBox1.SelectedIndex];
            }
            catch
            {
                MessageBox.Show("Please select a Input Device", "TypeMidi by Azor");
                return;
            }

            if (radioButton1.Checked) // Logitech SDK
            {
                Gmidi.Init();
            }
            else if (radioButton2.Checked)  // Razer SDK
            {
                Rmidi.Init();
            }
            else if (radioButton3.Checked)  // Corsair ICue SDK
            {
                MessageBox.Show("Corsair ICue SDK not available in this version.", "TypeMidi by Azor");
            }
            else
            {
                MessageBox.Show("Please select your Keyboard Type", "TypeMidi by Azor");
            }

            if (!inputDevice.IsOpen)
            {
                inputDevice.Open();
                inputDevice.NoteOn += NoteOn;
                inputDevice.NoteOff += NoteOff;
                inputDevice.StartReceiving(null);
            }
        }

        private void NoteOn(NoteOnMessage msg)
        {
            if(radioButton1.Checked) // Logitech SDK
            {
                Gmidi.palette_led((int)msg.Pitch, msg.Velocity);
            }
            else if(radioButton2.Checked)  // Razer SDK
            {
                Rmidi.palette_led((int)msg.Pitch, msg.Velocity);    
            }
            else if(radioButton3.Checked)  // Corsair ICue SDK
            {
                MessageBox.Show("Corsair ICue SDK not available in this version.", "TypeMidi by Azor");
            }
        }

        private void NoteOff(NoteOffMessage msg)
        {
            Gmidi.palette_led((int)msg.Pitch, 0);
        }

    }
}
