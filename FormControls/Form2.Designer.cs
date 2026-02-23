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
            this.btnDetails = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpClass = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpContinuity = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.subItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSearch = new System.Windows.Forms.ToolStripTextBox();
            this.updateStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tool3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabScreens.SuspendLayout();
            this.tpPersonal.SuspendLayout();
            this.tpClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpContinuity.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabScreens
            // 
            this.tabScreens.Controls.Add(this.tpPersonal);
            this.tabScreens.Controls.Add(this.tpClass);
            this.tabScreens.Controls.Add(this.tpContinuity);
            this.tabScreens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabScreens.Location = new System.Drawing.Point(0, 27);
            this.tabScreens.Name = "tabScreens";
            this.tabScreens.SelectedIndex = 0;
            this.tabScreens.Size = new System.Drawing.Size(800, 423);
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
            this.tpPersonal.Size = new System.Drawing.Size(792, 397);
            this.tpPersonal.TabIndex = 0;
            this.tpPersonal.Text = "Personal Info";
            this.tpPersonal.UseVisualStyleBackColor = true;
            this.tpPersonal.Click += new System.EventHandler(this.tpPersonal_Click);
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(57, 125);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // tpContinuity
            // 
            this.tpContinuity.Controls.Add(this.webBrowser1);
            this.tpContinuity.Location = new System.Drawing.Point(4, 22);
            this.tpContinuity.Name = "tpContinuity";
            this.tpContinuity.Size = new System.Drawing.Size(792, 397);
            this.tpContinuity.TabIndex = 2;
            this.tpContinuity.Text = "Contiunity Info";
            this.tpContinuity.UseVisualStyleBackColor = true;
            this.tpContinuity.Click += new System.EventHandler(this.tpContinuity_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(792, 397);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile,
            this.itemEdit,
            this.itemHelp,
            this.toolsToolStripMenuItem,
            this.itemSearch});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 27);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            this.menuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItemOpen,
            this.subItemSave,
            this.subItemClose});
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(37, 23);
            this.itemFile.Text = "&File";
            this.itemFile.ToolTipText = "File Operations";
            this.itemFile.Click += new System.EventHandler(this.itemFile_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStudentInfoToolStripMenuItem,
            this.deleteStudentToolStripMenuItem});
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(39, 23);
            this.itemEdit.Text = "&Edit";
            this.itemEdit.Click += new System.EventHandler(this.itemEdit_Click);
            // 
            // itemHelp
            // 
            this.itemHelp.Name = "itemHelp";
            this.itemHelp.Size = new System.Drawing.Size(44, 23);
            this.itemHelp.Text = "&Help";
            // 
            // subItemOpen
            // 
            this.subItemOpen.Name = "subItemOpen";
            this.subItemOpen.Size = new System.Drawing.Size(103, 22);
            this.subItemOpen.Text = "&Open";
            // 
            // subItemSave
            // 
            this.subItemSave.Name = "subItemSave";
            this.subItemSave.Size = new System.Drawing.Size(103, 22);
            this.subItemSave.Text = "&Save";
            // 
            // subItemClose
            // 
            this.subItemClose.Name = "subItemClose";
            this.subItemClose.Size = new System.Drawing.Size(180, 22);
            this.subItemClose.Text = "&Close";
            this.subItemClose.Click += new System.EventHandler(this.subItemClose_Click);
            // 
            // itemSearch
            // 
            this.itemSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itemSearch.Name = "itemSearch";
            this.itemSearch.Size = new System.Drawing.Size(100, 23);
            this.itemSearch.Text = "Search...";
            // 
            // updateStudentInfoToolStripMenuItem
            // 
            this.updateStudentInfoToolStripMenuItem.Name = "updateStudentInfoToolStripMenuItem";
            this.updateStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateStudentInfoToolStripMenuItem.Text = "Update Student Info";
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool1ToolStripMenuItem,
            this.tool2ToolStripMenuItem,
            this.tool3ToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // tool1ToolStripMenuItem
            // 
            this.tool1ToolStripMenuItem.Name = "tool1ToolStripMenuItem";
            this.tool1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tool1ToolStripMenuItem.Text = "Tool1";
            this.tool1ToolStripMenuItem.Click += new System.EventHandler(this.tool1ToolStripMenuItem_Click);
            // 
            // tool2ToolStripMenuItem
            // 
            this.tool2ToolStripMenuItem.Name = "tool2ToolStripMenuItem";
            this.tool2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tool2ToolStripMenuItem.Text = "Tool2";
            // 
            // tool3ToolStripMenuItem
            // 
            this.tool3ToolStripMenuItem.Name = "tool3ToolStripMenuItem";
            this.tool3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tool3ToolStripMenuItem.Text = "Tool3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabScreens);
            this.Controls.Add(this.menuMain);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabScreens.ResumeLayout(false);
            this.tpPersonal.ResumeLayout(false);
            this.tpPersonal.PerformLayout();
            this.tpClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpContinuity.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem subItemOpen;
        private System.Windows.Forms.ToolStripMenuItem subItemSave;
        private System.Windows.Forms.ToolStripMenuItem subItemClose;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripMenuItem itemHelp;
        private System.Windows.Forms.ToolStripTextBox itemSearch;
        private System.Windows.Forms.ToolStripMenuItem updateStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tool3ToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}