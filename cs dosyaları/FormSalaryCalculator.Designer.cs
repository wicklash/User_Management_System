namespace salary_calculate
{
    partial class FormSalaryCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalaryCalculator));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBaseSalary
            // 
            this.textBoxBaseSalary.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxBaseSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBaseSalary.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxBaseSalary.Location = new System.Drawing.Point(23, 66);
            this.textBoxBaseSalary.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxBaseSalary.Multiline = true;
            this.textBoxBaseSalary.Name = "textBoxBaseSalary";
            this.textBoxBaseSalary.ReadOnly = true;
            this.textBoxBaseSalary.Size = new System.Drawing.Size(348, 32);
            this.textBoxBaseSalary.TabIndex = 0;
            this.textBoxBaseSalary.Text = "Asgari Ücret: 13414.50";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUserType.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Location = new System.Drawing.Point(23, 131);
            this.comboBoxUserType.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(366, 31);
            this.comboBoxUserType.TabIndex = 1;
            // 
            // buttonCalculateSalary
            // 
            this.buttonCalculateSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculateSalary.FlatAppearance.BorderSize = 0;
            this.buttonCalculateSalary.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCalculateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculateSalary.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCalculateSalary.Image = ((System.Drawing.Image)(resources.GetObject("buttonCalculateSalary.Image")));
            this.buttonCalculateSalary.Location = new System.Drawing.Point(337, 486);
            this.buttonCalculateSalary.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonCalculateSalary.Name = "buttonCalculateSalary";
            this.buttonCalculateSalary.Size = new System.Drawing.Size(139, 113);
            this.buttonCalculateSalary.TabIndex = 2;
            this.buttonCalculateSalary.Text = "Maaş Hesapla";
            this.buttonCalculateSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCalculateSalary.UseVisualStyleBackColor = true;
            this.buttonCalculateSalary.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCalculatedSalary
            // 
            this.labelCalculatedSalary.AutoSize = true;
            this.labelCalculatedSalary.Location = new System.Drawing.Point(326, 610);
            this.labelCalculatedSalary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCalculatedSalary.Name = "labelCalculatedSalary";
            this.labelCalculatedSalary.Size = new System.Drawing.Size(161, 23);
            this.labelCalculatedSalary.TabIndex = 3;
            this.labelCalculatedSalary.Text = "Hesaplanan Maaş";
            // 
            // checkBoxHasChildren
            // 
            this.checkBoxHasChildren.AutoSize = true;
            this.checkBoxHasChildren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxHasChildren.ForeColor = System.Drawing.Color.SlateGray;
            this.checkBoxHasChildren.Location = new System.Drawing.Point(443, 65);
            this.checkBoxHasChildren.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxHasChildren.Name = "checkBoxHasChildren";
            this.checkBoxHasChildren.Size = new System.Drawing.Size(115, 27);
            this.checkBoxHasChildren.TabIndex = 4;
            this.checkBoxHasChildren.Text = "Çocuk Var";
            this.checkBoxHasChildren.UseVisualStyleBackColor = true;
            this.checkBoxHasChildren.CheckedChanged += new System.EventHandler(this.checkBoxHasChildren_CheckedChanged);
            // 
            // textBoxNumChildren
            // 
            this.textBoxNumChildren.BackColor = System.Drawing.Color.LightGray;
            this.textBoxNumChildren.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumChildren.Enabled = false;
            this.textBoxNumChildren.Location = new System.Drawing.Point(464, 99);
            this.textBoxNumChildren.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxNumChildren.Name = "textBoxNumChildren";
            this.textBoxNumChildren.Size = new System.Drawing.Size(115, 23);
            this.textBoxNumChildren.TabIndex = 5;
            // 
            // numericUpDownExperience
            // 
            this.numericUpDownExperience.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.numericUpDownExperience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownExperience.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownExperience.Location = new System.Drawing.Point(26, 385);
            this.numericUpDownExperience.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numericUpDownExperience.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownExperience.Name = "numericUpDownExperience";
            this.numericUpDownExperience.Size = new System.Drawing.Size(136, 30);
            this.numericUpDownExperience.TabIndex = 6;
            // 
            // comboBoxCityGroup
            // 
            this.comboBoxCityGroup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxCityGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCityGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCityGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxCityGroup.FormattingEnabled = true;
            this.comboBoxCityGroup.Location = new System.Drawing.Point(23, 194);
            this.comboBoxCityGroup.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxCityGroup.Name = "comboBoxCityGroup";
            this.comboBoxCityGroup.Size = new System.Drawing.Size(366, 31);
            this.comboBoxCityGroup.TabIndex = 7;
            // 
            // comboBoxAcademicDegree
            // 
            this.comboBoxAcademicDegree.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxAcademicDegree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAcademicDegree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAcademicDegree.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxAcademicDegree.FormattingEnabled = true;
            this.comboBoxAcademicDegree.Location = new System.Drawing.Point(23, 258);
            this.comboBoxAcademicDegree.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxAcademicDegree.Name = "comboBoxAcademicDegree";
            this.comboBoxAcademicDegree.Size = new System.Drawing.Size(366, 31);
            this.comboBoxAcademicDegree.TabIndex = 8;
            // 
            // comboBoxManagementRole
            // 
            this.comboBoxManagementRole.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBoxManagementRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxManagementRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxManagementRole.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxManagementRole.FormattingEnabled = true;
            this.comboBoxManagementRole.Location = new System.Drawing.Point(23, 322);
            this.comboBoxManagementRole.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBoxManagementRole.Name = "comboBoxManagementRole";
            this.comboBoxManagementRole.Size = new System.Drawing.Size(366, 31);
            this.comboBoxManagementRole.TabIndex = 9;
            // 
            // checkBoxEnglishCertified
            // 
            this.checkBoxEnglishCertified.AutoSize = true;
            this.checkBoxEnglishCertified.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxEnglishCertified.ForeColor = System.Drawing.Color.SlateGray;
            this.checkBoxEnglishCertified.Location = new System.Drawing.Point(443, 324);
            this.checkBoxEnglishCertified.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxEnglishCertified.Name = "checkBoxEnglishCertified";
            this.checkBoxEnglishCertified.Size = new System.Drawing.Size(300, 27);
            this.checkBoxEnglishCertified.TabIndex = 10;
            this.checkBoxEnglishCertified.Text = "Belgelendirilmiş İngilizce bilgisi";
            this.checkBoxEnglishCertified.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnglishEducated
            // 
            this.checkBoxEnglishEducated.AutoSize = true;
            this.checkBoxEnglishEducated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxEnglishEducated.ForeColor = System.Drawing.Color.SlateGray;
            this.checkBoxEnglishEducated.Location = new System.Drawing.Point(443, 364);
            this.checkBoxEnglishEducated.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxEnglishEducated.Name = "checkBoxEnglishEducated";
            this.checkBoxEnglishEducated.Size = new System.Drawing.Size(349, 27);
            this.checkBoxEnglishEducated.TabIndex = 11;
            this.checkBoxEnglishEducated.Text = "İngilizce eğitim veren okul mezuniyeti";
            this.checkBoxEnglishEducated.UseVisualStyleBackColor = true;
            // 
            // textBoxOtherLanguages
            // 
            this.textBoxOtherLanguages.BackColor = System.Drawing.Color.LightGray;
            this.textBoxOtherLanguages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOtherLanguages.Location = new System.Drawing.Point(464, 436);
            this.textBoxOtherLanguages.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxOtherLanguages.Name = "textBoxOtherLanguages";
            this.textBoxOtherLanguages.Size = new System.Drawing.Size(118, 23);
            this.textBoxOtherLanguages.TabIndex = 12;
            // 
            // checkBoxSpouseNotWorking
            // 
            this.checkBoxSpouseNotWorking.AutoSize = true;
            this.checkBoxSpouseNotWorking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSpouseNotWorking.ForeColor = System.Drawing.Color.SlateGray;
            this.checkBoxSpouseNotWorking.Location = new System.Drawing.Point(443, 235);
            this.checkBoxSpouseNotWorking.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxSpouseNotWorking.Name = "checkBoxSpouseNotWorking";
            this.checkBoxSpouseNotWorking.Size = new System.Drawing.Size(209, 27);
            this.checkBoxSpouseNotWorking.TabIndex = 13;
            this.checkBoxSpouseNotWorking.Text = "Evli ve eşi çalışmıyor";
            this.checkBoxSpouseNotWorking.UseVisualStyleBackColor = true;
            // 
            // checkBoxChildOver18
            // 
            this.checkBoxChildOver18.AutoSize = true;
            this.checkBoxChildOver18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChildOver18.Enabled = false;
            this.checkBoxChildOver18.ForeColor = System.Drawing.Color.SlateGray;
            this.checkBoxChildOver18.Location = new System.Drawing.Point(443, 198);
            this.checkBoxChildOver18.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxChildOver18.Name = "checkBoxChildOver18";
            this.checkBoxChildOver18.Size = new System.Drawing.Size(177, 27);
            this.checkBoxChildOver18.TabIndex = 14;
            this.checkBoxChildOver18.Text = "18 yaş üstü çocuk";
            this.checkBoxChildOver18.UseVisualStyleBackColor = true;
            // 
            // checkBoxChildUnder6
            // 
            this.checkBoxChildUnder6.AutoSize = true;
            this.checkBoxChildUnder6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChildUnder6.Enabled = false;
            this.checkBoxChildUnder6.ForeColor = System.Drawing.Color.SlateGray;
            this.checkBoxChildUnder6.Location = new System.Drawing.Point(443, 124);
            this.checkBoxChildUnder6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxChildUnder6.Name = "checkBoxChildUnder6";
            this.checkBoxChildUnder6.Size = new System.Drawing.Size(194, 27);
            this.checkBoxChildUnder6.TabIndex = 14;
            this.checkBoxChildUnder6.Text = "0-6 yaş arası çocuk";
            this.checkBoxChildUnder6.UseVisualStyleBackColor = true;
            // 
            // checkBoxChild7to18
            // 
            this.checkBoxChild7to18.AutoSize = true;
            this.checkBoxChild7to18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxChild7to18.Enabled = false;
            this.checkBoxChild7to18.ForeColor = System.Drawing.Color.SlateGray;
            this.checkBoxChild7to18.Location = new System.Drawing.Point(443, 161);
            this.checkBoxChild7to18.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxChild7to18.Name = "checkBoxChild7to18";
            this.checkBoxChild7to18.Size = new System.Drawing.Size(201, 27);
            this.checkBoxChild7to18.TabIndex = 15;
            this.checkBoxChild7to18.Text = "7-18 yaş arası çocuk";
            this.checkBoxChild7to18.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Çalışma Şekli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(22, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Çalışma Süresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(19, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Yaşadığı Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(22, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Akademik Derece";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(461, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Yabancı Dil Yetkinliği";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(460, 408);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Başka Dillerin Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(22, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yöneticilik Pozisyonu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(465, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 5);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(465, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 5);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(465, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 5);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(464, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 5);
            this.panel4.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(464, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 5);
            this.panel5.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(464, 224);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 5);
            this.panel6.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel7.Location = new System.Drawing.Point(464, 260);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 5);
            this.panel7.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.Location = new System.Drawing.Point(464, 87);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 5);
            this.panel8.TabIndex = 26;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SlateGray;
            this.panel9.Controls.Add(this.btnBack);
            this.panel9.Controls.Add(this.btnAlt);
            this.panel9.Controls.Add(this.btnClose);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(813, 28);
            this.panel9.TabIndex = 42;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SlateGray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 28);
            this.btnBack.TabIndex = 28;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.SlateGray;
            this.btnAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlt.FlatAppearance.BorderSize = 0;
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlt.Image")));
            this.btnAlt.Location = new System.Drawing.Point(744, 0);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(35, 28);
            this.btnAlt.TabIndex = 12;
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SlateGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(778, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormSalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 676);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormSalaryCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperience)).EndInit();
            this.panel9.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnClose;
    }
}

