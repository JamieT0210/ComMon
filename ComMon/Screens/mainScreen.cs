using OpenHardwareMonitor.Hardware;
using System;
using System.Windows.Forms;

namespace ComMon.Screens
{
    public partial class mainScreen : Form
    {
        private string Selected = null;

        public mainScreen()
        {
            InitializeComponent();
            var timerGPU = new Timer();
            timerGPU.Tick += new EventHandler(timer_GPU_Tick);
            timerGPU.Interval = 1000;
            timerGPU.Start();

            var timerCPU = new Timer();
            timerCPU.Tick += new EventHandler(timer_CPU_Tick);
            timerCPU.Interval = 1000;
            timerCPU.Start();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefreshGPU_Click(object sender, EventArgs e)
        {
            Computer c = new Computer()
            {
                GPUEnabled = true,
                CPUEnabled = true,
            };
            c.Open();

            foreach (var Hardware in c.Hardware)
            {
                Hardware.Update();
                if ((Hardware.HardwareType == HardwareType.GpuNvidia) || (Hardware.HardwareType == HardwareType.GpuAti))
                {
                    cmbGPUName.Items.Add(String.Format(Hardware.Name) + ": " + Convert.ToString(Hardware.Identifier));
                    cmbGPUName.SelectedIndex = 0;
                }
                if (Hardware.HardwareType == HardwareType.CPU) 
                {
                    cmbCPUName.Items.Add(String.Format(Hardware.Name) + ": " + Convert.ToString(Hardware.Identifier));
                    cmbCPUName.SelectedIndex = 0;
                }
            }
        }

        void timer_CPU_Tick(object sender, EventArgs e)
        {

        }

            void timer_GPU_Tick(object sender, EventArgs e)
        {
            Computer c = new Computer()
            {
                GPUEnabled = true
            };
            c.Open();
            foreach (var Hardware in c.Hardware)
            {
                Hardware.Update();
                string str = this.cmbGPUName.GetItemText(this.cmbGPUName.SelectedItem);
                Selected = str.Substring(str.LastIndexOf(' ') + 1);
                if (Convert.ToString(Hardware.Identifier) == Selected)
                {
                    //Temperature
                    foreach (var sensor in Hardware.Sensors)
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            txtGpuTemp.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    //Fan speed RPM
                    foreach (var sensor in Hardware.Sensors)
                        if (sensor.SensorType == SensorType.Fan)
                        {
                            txtGPUFanSpeed.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    //Fan Speed % 
                    foreach (var sensor in Hardware.Sensors)
                        if (sensor.SensorType == SensorType.Control)
                        {
                            txtGpuFanPercent.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    //Core Clock
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/clock/0")
                        {
                            txtGPUCore.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                    //Memory clock
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/clock/1")
                        {
                            txtGPUMem.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                    //Shader clock
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/clock/2")
                        {
                            txtGPUShader.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                    //Core Load
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/load/0")
                        {
                            txtGPUCoreLoad.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                    //Memory Load
                    foreach (var sensor in Hardware.Sensors)
                    {
                        if (Convert.ToString(sensor.Identifier) == Selected + "/load/3")
                        {
                            txtGPUMemLoadPerc.Text = Convert.ToString(Math.Round((double)sensor.Value, 0));
                        }
                    }
                }
            }
        }
    }
}
