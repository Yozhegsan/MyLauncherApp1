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
            this.launchItemCTL1 = new MyLauncherApp1.LaunchItemCTL();
            this.launchItemCTL2 = new MyLauncherApp1.LaunchItemCTL();
            this.launchItemCTL3 = new MyLauncherApp1.LaunchItemCTL();
            this.launchItemCTL4 = new MyLauncherApp1.LaunchItemCTL();
            this.picTest = new System.Windows.Forms.PictureBox();
            this.launchItemBarCTL1 = new MyLauncherApp1.LaunchItemBarCTL();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // launchItemCTL1
            // 
            this.launchItemCTL1.AppFile = "notepad";
            this.launchItemCTL1.AppIcon = null;
            this.launchItemCTL1.AppName = "notepad";
            this.launchItemCTL1.AppSelColor = System.Drawing.Color.Red;
            this.launchItemCTL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemCTL1.Location = new System.Drawing.Point(31, 35);
            this.launchItemCTL1.Name = "launchItemCTL1";
            this.launchItemCTL1.Size = new System.Drawing.Size(148, 190);
            this.launchItemCTL1.TabIndex = 0;
            // 
            // launchItemCTL2
            // 
            this.launchItemCTL2.AppFile = "regedit";
            this.launchItemCTL2.AppIcon = null;
            this.launchItemCTL2.AppName = "regedit";
            this.launchItemCTL2.AppSelColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.launchItemCTL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemCTL2.Location = new System.Drawing.Point(185, 35);
            this.launchItemCTL2.Name = "launchItemCTL2";
            this.launchItemCTL2.Size = new System.Drawing.Size(148, 190);
            this.launchItemCTL2.TabIndex = 0;
            // 
            // launchItemCTL3
            // 
            this.launchItemCTL3.AppFile = "explorer";
            this.launchItemCTL3.AppIcon = null;
            this.launchItemCTL3.AppName = "explorer";
            this.launchItemCTL3.AppSelColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.launchItemCTL3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemCTL3.Location = new System.Drawing.Point(339, 35);
            this.launchItemCTL3.Name = "launchItemCTL3";
            this.launchItemCTL3.Size = new System.Drawing.Size(148, 190);
            this.launchItemCTL3.TabIndex = 0;
            // 
            // launchItemCTL4
            // 
            this.launchItemCTL4.AppFile = "mmc";
            this.launchItemCTL4.AppIcon = null;
            this.launchItemCTL4.AppName = "mmc";
            this.launchItemCTL4.AppSelColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.launchItemCTL4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemCTL4.Location = new System.Drawing.Point(493, 35);
            this.launchItemCTL4.Name = "launchItemCTL4";
            this.launchItemCTL4.Size = new System.Drawing.Size(148, 190);
            this.launchItemCTL4.TabIndex = 0;
            // 
            // picTest
            // 
            this.picTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTest.Location = new System.Drawing.Point(31, 356);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(128, 128);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTest.TabIndex = 1;
            this.picTest.TabStop = false;
            // 
            // launchItemBarCTL1
            // 
            this.launchItemBarCTL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.launchItemBarCTL1.Location = new System.Drawing.Point(179, 294);
            this.launchItemBarCTL1.Name = "launchItemBarCTL1";
            this.launchItemBarCTL1.Size = new System.Drawing.Size(462, 190);
            this.launchItemBarCTL1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
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
            this.mnuSetup.Size = new System.Drawing.Size(180, 22);
            this.mnuSetup.Text = "Налаштування";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(647, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(518, 420);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 511);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.launchItemBarCTL1);
            this.Controls.Add(this.picTest);
            this.Controls.Add(this.launchItemCTL4);
            this.Controls.Add(this.launchItemCTL3);
            this.Controls.Add(this.launchItemCTL2);
            this.Controls.Add(this.launchItemCTL1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LaunchItemCTL launchItemCTL1;
        private LaunchItemCTL launchItemCTL2;
        private LaunchItemCTL launchItemCTL3;
        private LaunchItemCTL launchItemCTL4;
        private System.Windows.Forms.PictureBox picTest;
        private LaunchItemBarCTL launchItemBarCTL1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSetup;
        private System.Windows.Forms.ListBox listBox1;
    }
}

