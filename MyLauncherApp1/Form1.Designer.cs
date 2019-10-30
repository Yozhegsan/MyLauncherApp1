namespace MyLauncherApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picTest = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.launchItemCTL3 = new MyLauncherApp1.LaunchItemCTL();
            this.launchItemCTL2 = new MyLauncherApp1.LaunchItemCTL();
            this.launchItemCTL1 = new MyLauncherApp1.LaunchItemCTL();
            this.launchItemBarCTL1 = new MyLauncherApp1.LaunchItemBarCTL();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTest
            // 
            this.picTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTest.Location = new System.Drawing.Point(31, 231);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(128, 128);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTest.TabIndex = 1;
            this.picTest.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetup});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // mnuSetup
            // 
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(156, 22);
            this.mnuSetup.Text = "Налаштування";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(493, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 329);
            this.listBox1.TabIndex = 4;
            // 
            // launchItemCTL3
            // 
            this.launchItemCTL3.AppFile = "";
            this.launchItemCTL3.AppIcon = null;
            this.launchItemCTL3.AppInfo = "No data";
            this.launchItemCTL3.AppName = "APP NAME";
            this.launchItemCTL3.AppParameters = "";
            this.launchItemCTL3.AppSelColor = System.Drawing.Color.Lime;
            this.launchItemCTL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemCTL3.Location = new System.Drawing.Point(339, 27);
            this.launchItemCTL3.Name = "launchItemCTL3";
            this.launchItemCTL3.Size = new System.Drawing.Size(148, 190);
            this.launchItemCTL3.TabIndex = 5;
            this.launchItemCTL3.ShowAppInfo += new System.Action<string>(this.ShowAppInfo);
            // 
            // launchItemCTL2
            // 
            this.launchItemCTL2.AppFile = "C:\\Program Files (x86)\\Adobe\\Adobe Photoshop CS3\\Photoshop.exe";
            this.launchItemCTL2.AppIcon = null;
            this.launchItemCTL2.AppInfo = "Adobe photoshop CS3";
            this.launchItemCTL2.AppName = "Photoshop";
            this.launchItemCTL2.AppParameters = "";
            this.launchItemCTL2.AppSelColor = System.Drawing.Color.RoyalBlue;
            this.launchItemCTL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemCTL2.Location = new System.Drawing.Point(185, 27);
            this.launchItemCTL2.Name = "launchItemCTL2";
            this.launchItemCTL2.Size = new System.Drawing.Size(148, 190);
            this.launchItemCTL2.TabIndex = 5;
            this.launchItemCTL2.ShowAppInfo += new System.Action<string>(this.ShowAppInfo);
            // 
            // launchItemCTL1
            // 
            this.launchItemCTL1.AppFile = "explorer";
            this.launchItemCTL1.AppIcon = null;
            this.launchItemCTL1.AppInfo = "Provodnik";
            this.launchItemCTL1.AppName = "explorer";
            this.launchItemCTL1.AppParameters = "D:\\yozheg";
            this.launchItemCTL1.AppSelColor = System.Drawing.Color.Red;
            this.launchItemCTL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemCTL1.Location = new System.Drawing.Point(31, 27);
            this.launchItemCTL1.Name = "launchItemCTL1";
            this.launchItemCTL1.Size = new System.Drawing.Size(148, 190);
            this.launchItemCTL1.TabIndex = 5;
            this.launchItemCTL1.ShowAppInfo += new System.Action<string>(this.ShowAppInfo);
            // 
            // launchItemBarCTL1
            // 
            this.launchItemBarCTL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemBarCTL1.Location = new System.Drawing.Point(165, 231);
            this.launchItemBarCTL1.Name = "launchItemBarCTL1";
            this.launchItemBarCTL1.Size = new System.Drawing.Size(322, 102);
            this.launchItemBarCTL1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.launchItemCTL3);
            this.Controls.Add(this.launchItemCTL2);
            this.Controls.Add(this.launchItemCTL1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.launchItemBarCTL1);
            this.Controls.Add(this.picTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picTest;
        private LaunchItemBarCTL launchItemBarCTL1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ListBox listBox1;
        private LaunchItemCTL launchItemCTL1;
        private LaunchItemCTL launchItemCTL2;
        private LaunchItemCTL launchItemCTL3;
        private System.Windows.Forms.Label label1;
    }
}

