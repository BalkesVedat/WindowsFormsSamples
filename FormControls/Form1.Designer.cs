namespace FormControls
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.tbNameSurname = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.chkBooks = new System.Windows.Forms.CheckBox();
            this.chkGaming = new System.Windows.Forms.CheckBox();
            this.chkSeries = new System.Windows.Forms.CheckBox();
            this.chkSports = new System.Windows.Forms.CheckBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.gbEducation = new System.Windows.Forms.GroupBox();
            this.rbMaster = new System.Windows.Forms.RadioButton();
            this.rbUniversity = new System.Windows.Forms.RadioButton();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.gbDivision = new System.Windows.Forms.GroupBox();
            this.rbArts = new System.Windows.Forms.RadioButton();
            this.rbEngineering = new System.Windows.Forms.RadioButton();
            this.rbPhisics = new System.Windows.Forms.RadioButton();
            this.rbMaths = new System.Windows.Forms.RadioButton();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lstLang = new System.Windows.Forms.ListBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblAvgPoint = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbEducation.SuspendLayout();
            this.gbDivision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(66, 48);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(80, 13);
            this.lblNameSurname.TabIndex = 0;
            this.lblNameSurname.Text = "Name Surname";
            // 
            // tbNameSurname
            // 
            this.tbNameSurname.Location = new System.Drawing.Point(152, 45);
            this.tbNameSurname.Name = "tbNameSurname";
            this.tbNameSurname.Size = new System.Drawing.Size(188, 20);
            this.tbNameSurname.TabIndex = 1;
            this.tbNameSurname.TextChanged += new System.EventHandler(this.tbNameSurname_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(152, 71);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(188, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(66, 74);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email Address";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(152, 97);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(188, 20);
            this.tbPhone.TabIndex = 5;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(66, 100);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // chkBooks
            // 
            this.chkBooks.AutoSize = true;
            this.chkBooks.Location = new System.Drawing.Point(155, 130);
            this.chkBooks.Name = "chkBooks";
            this.chkBooks.Size = new System.Drawing.Size(56, 17);
            this.chkBooks.TabIndex = 6;
            this.chkBooks.Text = "Books";
            this.chkBooks.UseVisualStyleBackColor = true;
            this.chkBooks.CheckedChanged += new System.EventHandler(this.chkBooks_CheckedChanged);
            // 
            // chkGaming
            // 
            this.chkGaming.AutoSize = true;
            this.chkGaming.Location = new System.Drawing.Point(155, 153);
            this.chkGaming.Name = "chkGaming";
            this.chkGaming.Size = new System.Drawing.Size(62, 17);
            this.chkGaming.TabIndex = 7;
            this.chkGaming.Text = "Gaming";
            this.chkGaming.UseVisualStyleBackColor = true;
            // 
            // chkSeries
            // 
            this.chkSeries.AutoSize = true;
            this.chkSeries.Location = new System.Drawing.Point(248, 130);
            this.chkSeries.Name = "chkSeries";
            this.chkSeries.Size = new System.Drawing.Size(55, 17);
            this.chkSeries.TabIndex = 8;
            this.chkSeries.Text = "Series";
            this.chkSeries.UseVisualStyleBackColor = true;
            // 
            // chkSports
            // 
            this.chkSports.AutoSize = true;
            this.chkSports.Location = new System.Drawing.Point(155, 176);
            this.chkSports.Name = "chkSports";
            this.chkSports.Size = new System.Drawing.Size(56, 17);
            this.chkSports.TabIndex = 9;
            this.chkSports.Text = "Sports";
            this.chkSports.UseVisualStyleBackColor = true;
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(66, 130);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(46, 13);
            this.lblHobbies.TabIndex = 10;
            this.lblHobbies.Text = "Hobbies";
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(248, 153);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(54, 17);
            this.chkMusic.TabIndex = 11;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(53, 410);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(51, 20);
            this.lblMesaj.TabIndex = 12;
            this.lblMesaj.Text = "label1";
            this.lblMesaj.Visible = false;
            // 
            // gbEducation
            // 
            this.gbEducation.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gbEducation.Controls.Add(this.rbMaster);
            this.gbEducation.Controls.Add(this.rbUniversity);
            this.gbEducation.Controls.Add(this.rbHigh);
            this.gbEducation.Location = new System.Drawing.Point(154, 208);
            this.gbEducation.Name = "gbEducation";
            this.gbEducation.Size = new System.Drawing.Size(235, 44);
            this.gbEducation.TabIndex = 13;
            this.gbEducation.TabStop = false;
            this.gbEducation.Text = "Education";
            this.gbEducation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbMaster
            // 
            this.rbMaster.AutoSize = true;
            this.rbMaster.Location = new System.Drawing.Point(170, 19);
            this.rbMaster.Name = "rbMaster";
            this.rbMaster.Size = new System.Drawing.Size(57, 17);
            this.rbMaster.TabIndex = 2;
            this.rbMaster.TabStop = true;
            this.rbMaster.Text = "Master";
            this.rbMaster.UseVisualStyleBackColor = true;
            // 
            // rbUniversity
            // 
            this.rbUniversity.AutoSize = true;
            this.rbUniversity.Location = new System.Drawing.Point(93, 20);
            this.rbUniversity.Name = "rbUniversity";
            this.rbUniversity.Size = new System.Drawing.Size(71, 17);
            this.rbUniversity.TabIndex = 1;
            this.rbUniversity.TabStop = true;
            this.rbUniversity.Text = "University";
            this.rbUniversity.UseVisualStyleBackColor = true;
            // 
            // rbHigh
            // 
            this.rbHigh.AutoSize = true;
            this.rbHigh.Location = new System.Drawing.Point(7, 20);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(80, 17);
            this.rbHigh.TabIndex = 0;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "HighSchool";
            this.rbHigh.UseVisualStyleBackColor = true;
            // 
            // gbDivision
            // 
            this.gbDivision.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gbDivision.Controls.Add(this.rbArts);
            this.gbDivision.Controls.Add(this.rbEngineering);
            this.gbDivision.Controls.Add(this.rbPhisics);
            this.gbDivision.Controls.Add(this.rbMaths);
            this.gbDivision.Location = new System.Drawing.Point(155, 259);
            this.gbDivision.Name = "gbDivision";
            this.gbDivision.Size = new System.Drawing.Size(234, 70);
            this.gbDivision.TabIndex = 14;
            this.gbDivision.TabStop = false;
            this.gbDivision.Text = "Division";
            // 
            // rbArts
            // 
            this.rbArts.AutoSize = true;
            this.rbArts.Location = new System.Drawing.Point(122, 43);
            this.rbArts.Name = "rbArts";
            this.rbArts.Size = new System.Drawing.Size(43, 17);
            this.rbArts.TabIndex = 3;
            this.rbArts.TabStop = true;
            this.rbArts.Text = "Arts";
            this.rbArts.UseVisualStyleBackColor = true;
            // 
            // rbEngineering
            // 
            this.rbEngineering.AutoSize = true;
            this.rbEngineering.Location = new System.Drawing.Point(122, 20);
            this.rbEngineering.Name = "rbEngineering";
            this.rbEngineering.Size = new System.Drawing.Size(81, 17);
            this.rbEngineering.TabIndex = 2;
            this.rbEngineering.TabStop = true;
            this.rbEngineering.Text = "Engineering";
            this.rbEngineering.UseVisualStyleBackColor = true;
            // 
            // rbPhisics
            // 
            this.rbPhisics.AutoSize = true;
            this.rbPhisics.Location = new System.Drawing.Point(7, 43);
            this.rbPhisics.Name = "rbPhisics";
            this.rbPhisics.Size = new System.Drawing.Size(58, 17);
            this.rbPhisics.TabIndex = 1;
            this.rbPhisics.TabStop = true;
            this.rbPhisics.Text = "Phisics";
            this.rbPhisics.UseVisualStyleBackColor = true;
            // 
            // rbMaths
            // 
            this.rbMaths.AutoSize = true;
            this.rbMaths.Location = new System.Drawing.Point(7, 20);
            this.rbMaths.Name = "rbMaths";
            this.rbMaths.Size = new System.Drawing.Size(54, 17);
            this.rbMaths.TabIndex = 0;
            this.rbMaths.TabStop = true;
            this.rbMaths.Text = "Maths";
            this.rbMaths.UseVisualStyleBackColor = true;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(66, 335);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(152, 335);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(188, 20);
            this.tbCity.TabIndex = 1;
            this.tbCity.TextChanged += new System.EventHandler(this.tbCity_TextChanged);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(461, 48);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(51, 13);
            this.lblBirthDate.TabIndex = 15;
            this.lblBirthDate.Text = "BirthDate";
            // 
            // dTPBirthDate
            // 
            this.dTPBirthDate.Location = new System.Drawing.Point(536, 45);
            this.dTPBirthDate.Name = "dTPBirthDate";
            this.dTPBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dTPBirthDate.TabIndex = 16;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(461, 74);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGender.Location = new System.Drawing.Point(536, 70);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 19;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // lstLang
            // 
            this.lstLang.FormattingEnabled = true;
            this.lstLang.Items.AddRange(new object[] {
            "Turkish",
            "English",
            "French",
            "Spanish",
            "Russian",
            "Kurdish",
            "Arabic",
            "Deutsch"});
            this.lstLang.Location = new System.Drawing.Point(536, 100);
            this.lstLang.Name = "lstLang";
            this.lstLang.Size = new System.Drawing.Size(121, 108);
            this.lstLang.TabIndex = 20;
            this.lstLang.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(461, 100);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(60, 13);
            this.lblLang.TabIndex = 21;
            this.lblLang.Text = "Languages";
            this.lblLang.Click += new System.EventHandler(this.lblLang_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(536, 215);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblAvgPoint
            // 
            this.lblAvgPoint.AutoSize = true;
            this.lblAvgPoint.Location = new System.Drawing.Point(464, 219);
            this.lblAvgPoint.Name = "lblAvgPoint";
            this.lblAvgPoint.Size = new System.Drawing.Size(53, 13);
            this.lblAvgPoint.TabIndex = 23;
            this.lblAvgPoint.Text = "Avg Point";
            this.lblAvgPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imgPhoto
            // 
            this.imgPhoto.Image = ((System.Drawing.Image)(resources.GetObject("imgPhoto.Image")));
            this.imgPhoto.Location = new System.Drawing.Point(536, 241);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(210, 140);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPhoto.TabIndex = 24;
            this.imgPhoto.TabStop = false;
            this.imgPhoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgPhoto);
            this.Controls.Add(this.lblAvgPoint);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lstLang);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dTPBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.gbDivision);
            this.Controls.Add(this.gbEducation);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.lblHobbies);
            this.Controls.Add(this.chkSports);
            this.Controls.Add(this.chkSeries);
            this.Controls.Add(this.chkGaming);
            this.Controls.Add(this.chkBooks);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbNameSurname);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.tbCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEducation.ResumeLayout(false);
            this.gbEducation.PerformLayout();
            this.gbDivision.ResumeLayout(false);
            this.gbDivision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox tbNameSurname;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.CheckBox chkBooks;
        private System.Windows.Forms.CheckBox chkGaming;
        private System.Windows.Forms.CheckBox chkSeries;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.Label lblHobbies;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.GroupBox gbEducation;
        private System.Windows.Forms.RadioButton rbUniversity;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbMaster;
        private System.Windows.Forms.GroupBox gbDivision;
        private System.Windows.Forms.RadioButton rbArts;
        private System.Windows.Forms.RadioButton rbEngineering;
        private System.Windows.Forms.RadioButton rbPhisics;
        private System.Windows.Forms.RadioButton rbMaths;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dTPBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ListBox lstLang;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblAvgPoint;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

