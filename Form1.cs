using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinSaleTroubleShooter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("killprinter.bat");
            SW.WriteLine(@"sc stop spooler
del c:\windows\system32\spool\printers
sc start spooler");
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("killprinter.bat");
            File.Delete("killprinter.bat");

        }

        private void btnTeamV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.teamviewer.com/en/download/windows/");
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
        }

        private void btnScannerP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskschd.msc");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCOMPort_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("devmgmt.msc");
        }

     

        private void btnInventory_Click_2(object sender, EventArgs e)
        
            {
            System.Diagnostics.Process.Start("rstrui.exe");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new
            System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ipconfig /flushdns";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();

            System.Diagnostics.Process process2 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo2 = new
            System.Diagnostics.ProcessStartInfo();
            startInfo2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo2.FileName = "cmd.exe";
            startInfo2.Arguments = "/C ipconfig /renew";
            startInfo2.Verb = "runas";
            process2.StartInfo = startInfo2;
            process2.Start();

            System.Diagnostics.Process process3 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo3 = new
            System.Diagnostics.ProcessStartInfo();
            startInfo2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo2.FileName = "cmd.exe";
            startInfo2.Arguments = "/C netsh winsock reset";
            startInfo2.Verb = "runas";
            process3.StartInfo = startInfo3;
            process3.Start();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cleanmgr.exe");

        }

        private void btnIP_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("CMD.exe", "/K ipconfig");


        }

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("UsoClient.exe", "ScanInstallWait");
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:idcommga@gmail.com");
        }

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSeqGcN5tE3cLnKmVRseQl-JqE5BsICqn6dyAfeuw6AJN4Jl_g/viewform?usp=sf_link");
        }
    }
}
