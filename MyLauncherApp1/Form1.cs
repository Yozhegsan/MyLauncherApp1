using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyLauncherApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] s = Environment.GetEnvironmentVariable("path").Split(';');

            foreach (string ss in s)
                listBox1.Items.Add(ss);


            picTest.Image = Icon.ExtractAssociatedIcon(@"C:\Program Files (x86)\Adobe\Adobe Photoshop CS3\Photoshop.exe").ToBitmap();
        }
    }
}
