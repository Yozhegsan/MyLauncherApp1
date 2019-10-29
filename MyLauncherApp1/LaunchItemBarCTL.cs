using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyLauncherApp1
{
    public partial class LaunchItemBarCTL : UserControl
    {
        private struct MyCtl
        {
            public string AppFile;
            public string AppName;
            public Color AppSelColor;
        }
        private List<MyCtl> Apps = new List<MyCtl>();

        public LaunchItemBarCTL()
        {
            InitializeComponent();
        }

        private void LaunchItemBarCTL_Load(object sender, EventArgs e)
        {

        }

        private void ShowAllApps()
        {

        }

        public void AddApp(string AppFile, string AppName, Color AppSelColor)
        {
            MyCtl mc;
            mc.AppFile = AppFile;
            mc.AppName = AppName;
            mc.AppSelColor = AppSelColor;
            Apps.Add(mc);
            ShowAllApps();
        }




    }
}
