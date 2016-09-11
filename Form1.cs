using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OculusOnOffForms
{
    public partial class Form1 : Form
    {
        private NotifyIcon notifyIcon;

        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            Hide();

        }

        //This Starts the Oculus
        private void turnOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\StopOculus.bat");
            ProcessStartInfo info = new ProcessStartInfo(@"C:\StartOculus.bat");
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process processChild = Process.Start(info);

            {
                    this.notifyIcon1.BalloonTipText = "Oculus has been turned On";
                    this.notifyIcon1.BalloonTipTitle = "Oculus Switch";
                    this.notifyIcon1.Icon = new Icon(@"C:\Oculus.ico");
                    this.notifyIcon1.Visible = true;
                    this.notifyIcon1.ShowBalloonTip(5);
                    this.notifyIcon1.Icon = new Icon(@"C:\OculusGreen2.ico");
                }

        }

        //This Stops the Oculus
        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\StopOculus.bat");
            // MessageBox.Show("Oculus has been turned Off");
            ProcessStartInfo info = new ProcessStartInfo(@"C:\StopOculus.bat");
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process processChild = Process.Start(info);
            {
                    this.notifyIcon1.BalloonTipText = "Oculus has been turned Off";
                    this.notifyIcon1.BalloonTipTitle = "Oculus Switch";
                    this.notifyIcon1.Icon = new Icon(@"C:\Oculus.ico");
                    this.notifyIcon1.Visible = true;
                    this.notifyIcon1.ShowBalloonTip(5);
                    this.notifyIcon1.Icon = new Icon(@"C:\OculusRed2.ico");
                }
        }

        //This opens a dialog box of how to use the App
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                " -This app must run at 'Admin' privileges to work.\n - Close any instances of this app, right click the app and choose\n 'Run This Program As An Administrator'.",

                "Created by @awalkingspastic");
        }

        //This Exits the App
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    Application.Exit();

            /*
            DialogResult messageBoxResult = MessageBox.Show
            ("Oculus has been turned On", "Oculus Switch", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (messageBoxResult == DialogResult.OK);

            //MessageBox.Show("Oculus has been turned On");
            */
                }


    }
}
