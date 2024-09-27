using System;
using static Anydesk.Imports;
using static Anydesk.Configs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics;

namespace Anydesk
{
    public partial class BMain : Form
    {
        public BMain()
        {
            InitializeComponent();
            mangemonchibre();
        }

        void mangemonchibre()
        {
            krokmouTrackBar1.Value = Configs.LeftTrackbar_cps;
            LCheck_B.Checked = Configs.Left_Enabled;
        }

        private void BMain_Load(object sender, EventArgs e)
        {

        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/DsVRSzqT");
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/DsVRSzqT");
        }

        private void krokmouTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            LeftCPS_Label.Text = $"{krokmouTrackBar1.Value} CPS";
            Configs.LeftTrackbar_cps = krokmouTrackBar1.Value;
        }
        #region //Left Click
        private void LeftClick_Tick(object sender, EventArgs e)
        {
            LeftClick.Interval = 1000 / krokmouTrackBar1.Value;
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (Configs.Left_Enabled)

                    if (MouseButtons == MouseButtons.Left)
                    {
                        SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                        Task.Delay(1).Wait();
                        SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                    }
                }
        }
        #endregion //
        private void LCheck_B_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            Configs.Left_Enabled = LCheck_B.Checked;
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
