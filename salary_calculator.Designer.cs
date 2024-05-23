namespace salary_calculate
{
    partial class salary_calculator
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
            this.textBoxBaseSalary = new System.Windows.Forms.TextBox();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.buttonCalculateSalary = new System.Windows.Forms.Button();
            this.labelCalculatedSalary = new System.Windows.Forms.Label();
            this.checkBoxHasChildren = new System.Windows.Forms.CheckBox();
            this.textBoxNumChildren = new System.Windows.Forms.TextBox();
            this.numericUpDownExperience = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCityGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxAcademicDegree = new System.Windows.Forms.ComboBox();
            this.comboBoxManagementRole = new System.Windows.Forms.ComboBox();
            this.checkBoxEnglishCertified = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglishEducated = new System.Windows.Forms.CheckBox();
            this.textBoxOtherLanguages = new System.Windows.Forms.TextBox();
            this.checkBoxSpouseNotWorking = new System.Windows.Forms.CheckBox();
            this.checkBoxChildOver18 = new System.Windows.Forms.CheckBox();
            this.checkBoxChildUnder6 = new System.Windows.Forms.CheckBox();
            this.checkBoxChild7to18 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBaseSalary
            // 
            this.textBoxBaseSalary.Location = new System.Drawing.Point(12, 12);
            this.textBoxBaseSalary.Multiline = true;
            this.textBoxBaseSalary.Name = "textBoxBaseSalary";
            this.textBoxBaseSalary.ReadOnly = true;
            this.textBoxBaseSalary.Size = new System.Drawing.Size(200, 20);
            this.textBoxBaseSalary.TabIndex = 0;
            this.textBoxBaseSalary.Text = "Asgari Ücret: 13414.50";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Location = new System.Drawing.Point(11, 78);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxUserType.TabIndex = 1;
            // 
            // buttonCalculateSalary
            // 
            this.buttonCalculateSalary.Location = new System.Drawing.Point(321, 351);
            this.buttonCalculateSalary.Name = "buttonCalculateSalary";
            this.buttonCalculateSalary.Size = new System.Drawing.Size(200, 23);
            this.buttonCalculateSalary.TabIndex = 2;
            this.buttonCalculateSalary.Text = "Maaş Hesapla";
            this.buttonCalculateSalary.UseVisualStyleBackColor = true;
            this.buttonCalculateSalary.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCalculatedSalary
            // 
            this.labelCalculatedSalary.AutoSize = true;
            this.labelCalculatedSalary.Location = new System.Drawing.Point(318, 392);
            this.labelCalculatedSalary.Name = "labelCalculatedSalary";
            this.labelCalculatedSalary.Size = new System.Drawing.Size(93, 13);
            this.labelCalculatedSalary.TabIndex = 3;
            this.labelCalculatedSalary.Text = "Hesaplanan Maaş";
            // 
            // checkBoxHasChildren
            // 
            this.checkBoxHasChildren.AutoSize = true;
            this.checkBoxHasChildren.Location = new System.Drawing.Point(321, 143);
            this.checkBoxHasChildren.Name = "checkBoxHasChildren";
            this.checkBoxHasChildren.Size = new System.Drawing.Size(76, 17);
            this.checkBoxHasChildren.TabIndex = 4;
            this.checkBoxHasChildren.Text = "Çocuk Var";
            this.checkBoxHasChildren.UseVisualStyleBackColor = true;
            this.checkBoxHasChildren.CheckedChanged += new System.EventHandler(this.checkBoxHasChildren_CheckedChanged);
            // 
            // textBoxNumChildren
            // 
            this.textBoxNumChildren.Enabled = false;
            this.textBoxNumChildren.Location = new System.Drawing.Point(321, 175);
            this.textBoxNumChildren.Name = "textBoxNumChildren";
            this.textBoxNumChildren.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumChildren.TabIndex = 5;
            // 
            // numericUpDownExperience
            // 
            this.numericUpDownExperience.Location = new System.Drawing.Point(11, 140);
            this.numericUpDownExperience.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownExperience.Name = "numericUpDownExperience";
            this.numericUpDownExperience.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownExperience.TabIndex = 6;
            // 
            // comboBoxCityGroup
            // 
            this.comboBoxCityGroup.FormattingEnabled = true;
            this.comboBoxCityGroup.Location = new System.Drawing.Point(11, 198);
            this.comboBoxCityGroup.Name = "comboBoxCityGroup";
            this.comboBoxCityGroup.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCityGroup.TabIndex = 7;
            // 
            // comboBoxAcademicDegree
            // 
            this.comboBoxAcademicDegree.FormattingEnabled = true;
            this.comboBoxAcademicDegree.Location = new System.Drawing.Point(12, 260);
            this.comboBoxAcademicDegree.Name = "comboBoxAcademicDegree";
            this.comboBoxAcademicDegree.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAcademicDegree.TabIndex = 8;
            // 
            // comboBoxManagementRole
            // 
            this.comboBoxManagementRole.FormattingEnabled = true;
            this.comboBoxManagementRole.Location = new System.Drawing.Point(321, 78);
            this.comboBoxManagementRole.Name = "comboBoxManagementRole";
            this.comboBoxManagementRole.Size = new System.Drawing.Size(200, 21);
            this.comboBoxManagementRole.TabIndex = 9;
            // 
            // checkBoxEnglishCertified
            // 
            this.checkBoxEnglishCertified.AutoSize = true;
            this.checkBoxEnglishCertified.Location = new System.Drawing.Point(10, 310);
            this.checkBoxEnglishCertified.Name = "checkBoxEnglishCertified";
            this.checkBoxEnglishCertified.Size = new System.Drawing.Size(166, 17);
            this.checkBoxEnglishCertified.TabIndex = 10;
            this.checkBoxEnglishCertified.Text = "Belgelendirilmiş İngilizce bilgisi";
            this.checkBoxEnglishCertified.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnglishEducated
            // 
            this.checkBoxEnglishEducated.AutoSize = true;
            this.checkBoxEnglishEducated.Location = new System.Drawing.Point(10, 333);
            this.checkBoxEnglishEducated.Name = "checkBoxEnglishEducated";
            this.checkBoxEnglishEducated.Size = new System.Drawing.Size(199, 17);
            this.checkBoxEnglishEducated.TabIndex = 11;
            this.checkBoxEnglishEducated.Text = "İngilizce eğitim veren okul mezuniyeti";
            this.checkBoxEnglishEducated.UseVisualStyleBackColor = true;
            // 
            // textBoxOtherLanguages
            // 
            this.textBoxOtherLanguages.Location = new System.Drawing.Point(10, 389);
            this.textBoxOtherLanguages.Name = "textBoxOtherLanguages";
            this.textBoxOtherLanguages.Size = new System.Drawing.Size(200, 20);
            this.textBoxOtherLanguages.TabIndex = 12;
            this.textBoxOtherLanguages.TextChanged += new System.EventHandler(this.textBoxOtherLanguages_TextChanged);
            // 
            // checkBoxSpouseNotWorking
            // 
            this.checkBoxSpouseNotWorking.AutoSize = true;
            this.checkBoxSpouseNotWorking.Location = new System.Drawing.Point(321, 310);
            this.checkBoxSpouseNotWorking.Name = "checkBoxSpouseNotWorking";
            this.checkBoxSpouseNotWorking.Size = new System.Drawing.Size(122, 17);
            this.checkBoxSpouseNotWorking.TabIndex = 13;
            this.checkBoxSpouseNotWorking.Text = "Evli ve eşi çalışmıyor";
            this.checkBoxSpouseNotWorking.UseVisualStyleBackColor = true;
            // 
            // checkBoxChildOver18
            // 
            this.checkBoxChildOver18.AutoSize = true;
            this.checkBoxChildOver18.Enabled = false;
            this.checkBoxChildOver18.Location = new System.Drawing.Point(321, 264);
            this.checkBoxChildOver18.Name = "checkBoxChildOver18";
            this.checkBoxChildOver18.Size = new System.Drawing.Size(113, 17);
            this.checkBoxChildOver18.TabIndex = 14;
            this.checkBoxChildOver18.Text = "18 yaş üstü çocuk";
            this.checkBoxChildOver18.UseVisualStyleBackColor = true;
            this.checkBoxChildOver18.CheckedChanged += new System.EventHandler(this.checkBoxChildOver18_CheckedChanged);
            // 
            // checkBoxChildUnder6
            // 
            this.checkBoxChildUnder6.AutoSize = true;
            this.checkBoxChildUnder6.Enabled = false;
            this.checkBoxChildUnder6.Location = new System.Drawing.Point(321, 218);
            this.checkBoxChildUnder6.Name = "checkBoxChildUnder6";
            this.checkBoxChildUnder6.Size = new System.Drawing.Size(118, 17);
            this.checkBoxChildUnder6.TabIndex = 14;
            this.checkBoxChildUnder6.Text = "0-6 yaş arası çocuk";
            this.checkBoxChildUnder6.UseVisualStyleBackColor = true;
            this.checkBoxChildUnder6.CheckedChanged += new System.EventHandler(this.checkBoxChildUnder6_CheckedChanged);
            // 
            // checkBoxChild7to18
            // 
            this.checkBoxChild7to18.AutoSize = true;
            this.checkBoxChild7to18.Enabled = false;
            this.checkBoxChild7to18.Location = new System.Drawing.Point(321, 241);
            this.checkBoxChild7to18.Name = "checkBoxChild7to18";
            this.checkBoxChild7to18.Size = new System.Drawing.Size(124, 17);
            this.checkBoxChild7to18.TabIndex = 15;
            this.checkBoxChild7to18.Text = "7-18 yaş arası çocuk";
            this.checkBoxChild7to18.UseVisualStyleBackColor = true;
            this.checkBoxChild7to18.CheckedChanged += new System.EventHandler(this.checkBoxChild7to18_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Çalışma Şekli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Çalışma Süresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Yaşadığı Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Akademik Derece";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Yabancı Dil Yetkinliği";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Başka Dillerin Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yöneticilik Pozisyonu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxChild7to18);
            this.Controls.Add(this.checkBoxChildUnder6);
            this.Controls.Add(this.checkBoxChildOver18);
            this.Controls.Add(this.checkBoxSpouseNotWorking);
            this.Controls.Add(this.textBoxOtherLanguages);
            this.Controls.Add(this.checkBoxEnglishEducated);
            this.Controls.Add(this.checkBoxEnglishCertified);
            this.Controls.Add(this.comboBoxManagementRole);
            this.Controls.Add(this.comboBoxAcademicDegree);
            this.Controls.Add(this.comboBoxCityGroup);
            this.Controls.Add(this.numericUpDownExperience);
            this.Controls.Add(this.textBoxNumChildren);
            this.Controls.Add(this.checkBoxHasChildren);
            this.Controls.Add(this.labelCalculatedSalary);
            this.Controls.Add(this.buttonCalculateSalary);
            this.Controls.Add(this.comboBoxUserType);
            this.Controls.Add(this.textBoxBaseSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBaseSalary;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Button buttonCalculateSalary;
        private System.Windows.Forms.Label labelCalculatedSalary;
        private System.Windows.Forms.CheckBox checkBoxHasChildren;
        private System.Windows.Forms.TextBox textBoxNumChildren;
        private System.Windows.Forms.NumericUpDown numericUpDownExperience;
        private System.Windows.Forms.ComboBox comboBoxCityGroup;
        private System.Windows.Forms.ComboBox comboBoxAcademicDegree;
        private System.Windows.Forms.ComboBox comboBoxManagementRole;
        private System.Windows.Forms.CheckBox checkBoxEnglishCertified;
        private System.Windows.Forms.CheckBox checkBoxEnglishEducated;
        private System.Windows.Forms.TextBox textBoxOtherLanguages;
        private System.Windows.Forms.CheckBox checkBoxSpouseNotWorking;
        private System.Windows.Forms.CheckBox checkBoxChildOver18;
        private System.Windows.Forms.CheckBox checkBoxChildUnder6;
        private System.Windows.Forms.CheckBox checkBoxChild7to18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

