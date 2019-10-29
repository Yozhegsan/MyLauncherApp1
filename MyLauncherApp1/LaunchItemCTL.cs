using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyLauncherApp1
{
    public partial class LaunchItemCTL : UserControl
    {
        //picTest.Image = Icon.ExtractAssociatedIcon("C:\\windows\\explorer.exe").ToBitmap();
        private Size MainZize = new Size(148, 190);
        public string AppFile { get; set; } = "";
        public Image AppIcon { get { return picIcon.Image; } set { picIcon.Image = value; } }
        public string AppName { get { return lblName.Text; } set { lblName.Text = value; } }
        public Color AppSelColor { get; set; } = Color.Black;

        //################################################################################################################

        public LaunchItemCTL()
        {
            InitializeComponent();
        }

        private void LaunchItemCTL_Load(object sender, EventArgs e)
        {

        }

        private void LaunchItemCTL_MouseEnter(object sender, EventArgs e){this.BackColor = AppSelColor; }
        private void LaunchItemCTL_MouseLeave(object sender, EventArgs e){this.BackColor = Color.FromName("Control");}
        private void picIcon_MouseEnter(object sender, EventArgs e){this.BackColor = AppSelColor; }
        private void picIcon_MouseLeave(object sender, EventArgs e){this.BackColor = Color.FromName("Control");}
        private void lblName_MouseEnter(object sender, EventArgs e){this.BackColor = AppSelColor; }
        private void lblName_MouseLeave(object sender, EventArgs e){this.BackColor = Color.FromName("Control");}

        private void LaunchItemCTL_Resize(object sender, EventArgs e)
        {
            this.Size = MainZize;
        }


        private void RunApp(object sender, EventArgs e)
        {
            MouseEventArgs a = (MouseEventArgs)e;
            if (a.Button == MouseButtons.Left)
                Process.Start(AppFile);
        }
    }
}

