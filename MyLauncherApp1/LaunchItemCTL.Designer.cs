namespace MyLauncherApp1
{
    partial class LaunchItemCTL
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(10, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "APP NAME";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblName.DoubleClick += new System.EventHandler(this.RunApp);
            this.lblName.MouseEnter += new System.EventHandler(this.lblName_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.lblName_MouseLeave);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.White;
            this.picIcon.BackgroundImage = global::MyLauncherApp1.Properties.Resources.icon_128x128__1_;
            this.picIcon.Location = new System.Drawing.Point(10, 10);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(128, 128);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            this.picIcon.DoubleClick += new System.EventHandler(this.RunApp);
            this.picIcon.MouseEnter += new System.EventHandler(this.picIcon_MouseEnter);
            this.picIcon.MouseLeave += new System.EventHandler(this.picIcon_MouseLeave);
            // 
            // LaunchItemCTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblName);
            this.Name = "LaunchItemCTL";
            this.Size = new System.Drawing.Size(148, 190);
            this.Load += new System.EventHandler(this.LaunchItemCTL_Load);
            this.DoubleClick += new System.EventHandler(this.RunApp);
            this.MouseEnter += new System.EventHandler(this.LaunchItemCTL_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LaunchItemCTL_MouseLeave);
            this.Resize += new System.EventHandler(this.LaunchItemCTL_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picIcon;
    }
}
