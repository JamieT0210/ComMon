using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace ComMon.Screens
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            lblComputerName.Text = System.Environment.MachineName;
            Console.WriteLine(Dns.GetHostName());
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    lblIP.Text = "";
                    lblIP.Text += (addr);
                }
            }

            var ticks = Stopwatch.GetTimestamp();
            var uptime = ((double)ticks) / Stopwatch.Frequency;
            var uptimeSpan = TimeSpan.FromSeconds(uptime);
            lblUp.Text = "";
            lblUp.Text += Math.Round(uptime / 3600, 2) + " Hrs";
        }
    }
}
