namespace FormControls
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabScreens = new System.Windows.Forms.TabControl();
            this.tpPersonal = new System.Windows.Forms.TabPage();
            this.tpClass = new System.Windows.Forms.TabPage();
            this.tpContinuity = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnDetails = new System.Windows.Forms.Button();
            this.tabScreens.SuspendLayout();
            this.tpPersonal.SuspendLayout();
            this.tpClass.SuspendLayout();
            this.tpContinuity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabScreens
            // 
            this.tabScreens.Controls.Add(this.tpPersonal);
            this.tabScreens.Controls.Add(this.tpClass);
            this.tabScreens.Controls.Add(this.tpContinuity);
            this.tabScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabScreens.Location = new System.Drawing.Point(0, 0);
            this.tabScreens.Name = "tabScreens";
            this.tabScreens.SelectedIndex = 0;
            this.tabScreens.Size = new System.Drawing.Size(800, 450);
            this.tabScreens.TabIndex = 0;
            // 
            // tpPersonal
            // 
            this.tpPersonal.Controls.Add(this.btnDetails);
            this.tpPersonal.Controls.Add(this.monthCalendar1);
            this.tpPersonal.Controls.Add(this.textBox1);
            this.tpPersonal.Location = new System.Drawing.Point(4, 22);
            this.tpPersonal.Name = "tpPersonal";
            this.tpPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonal.Size = new System.Drawing.Size(792, 424);
            this.tpPersonal.TabIndex = 0;
            this.tpPersonal.Text = "Personal Info";
            this.tpPersonal.UseVisualStyleBackColor = true;
            // 
            // tpClass
            // 
            this.tpClass.Controls.Add(this.pictureBox1);
            this.tpClass.Location = new System.Drawing.Point(4, 22);
            this.tpClass.Name = "tpClass";
            this.tpClass.Padding = new System.Windows.Forms.Padding(3);
            this.tpClass.Size = new System.Drawing.Size(792, 424);
            this.tpClass.TabIndex = 1;
            this.tpClass.Text = "Class Info";
            this.tpClass.UseVisualStyleBackColor = true;
            // 
            // tpContinuity
            // 
            this.tpContinuity.Controls.Add(this.webBrowser1);
            this.tpContinuity.Location = new System.Drawing.Point(4, 22);
            this.tpContinuity.Name = "tpContinuity";
            this.tpContinuity.Size = new System.Drawing.Size(792, 424);
            this.tpContinuity.TabIndex = 2;
            this.tpContinuity.Text = "Contiunity Info";
            this.tpContinuity.UseVisualStyleBackColor = true;
            this.tpContinuity.Click += new System.EventHandler(this.tpContinuity_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(57, 125);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(792, 424);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.w3schools.com", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(128, 41);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 2;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabScreens);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabScreens.ResumeLayout(false);
            this.tpPersonal.ResumeLayout(false);
            this.tpPersonal.PerformLayout();
            this.tpClass.ResumeLayout(false);
            this.tpContinuity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabScreens;
        private System.Windows.Forms.TabPage tpPersonal;
        private System.Windows.Forms.TabPage tpClass;
        private System.Windows.Forms.TabPage tpContinuity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnDetails;
    }
}