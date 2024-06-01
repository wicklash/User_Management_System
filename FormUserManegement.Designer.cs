namespace WindowsFormsApp2
{
    partial class FormUserManegement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserManegement));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_UserType = new System.Windows.Forms.GroupBox();
            this.radiobtn_user = new System.Windows.Forms.RadioButton();
            this.radiobtn_partTime = new System.Windows.Forms.RadioButton();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox_UserType.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(691, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liste";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 476);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_UserType);
            this.tabPage1.Controls.Add(this.txt_address);
            this.tabPage1.Controls.Add(this.txt_phone);
            this.tabPage1.Controls.Add(this.txt_password);
            this.tabPage1.Controls.Add(this.txt_surname);
            this.tabPage1.Controls.Add(this.txt_email);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_güncelle);
            this.tabPage1.Controls.Add(this.btn_sil);
            this.tabPage1.Controls.Add(this.txt_userName);
            this.tabPage1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.ForeColor = System.Drawing.Color.SlateGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(691, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kayıt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_UserType
            // 
            this.groupBox_UserType.Controls.Add(this.radiobtn_user);
            this.groupBox_UserType.Controls.Add(this.radiobtn_partTime);
            this.groupBox_UserType.Location = new System.Drawing.Point(148, 292);
            this.groupBox_UserType.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_UserType.Name = "groupBox_UserType";
            this.groupBox_UserType.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_UserType.Size = new System.Drawing.Size(287, 60);
            this.groupBox_UserType.TabIndex = 23;
            this.groupBox_UserType.TabStop = false;
            // 
            // radiobtn_user
            // 
            this.radiobtn_user.AutoSize = true;
            this.radiobtn_user.Location = new System.Drawing.Point(8, 17);
            this.radiobtn_user.Margin = new System.Windows.Forms.Padding(4);
            this.radiobtn_user.Name = "radiobtn_user";
            this.radiobtn_user.Size = new System.Drawing.Size(85, 33);
            this.radiobtn_user.TabIndex = 21;
            this.radiobtn_user.TabStop = true;
            this.radiobtn_user.Text = "User";
            this.radiobtn_user.UseVisualStyleBackColor = true;
            // 
            // radiobtn_partTime
            // 
            this.radiobtn_partTime.AutoSize = true;
            this.radiobtn_partTime.Location = new System.Drawing.Point(135, 17);
            this.radiobtn_partTime.Margin = new System.Windows.Forms.Padding(4);
            this.radiobtn_partTime.Name = "radiobtn_partTime";
            this.radiobtn_partTime.Size = new System.Drawing.Size(182, 33);
            this.radiobtn_partTime.TabIndex = 22;
            this.radiobtn_partTime.TabStop = true;
            this.radiobtn_partTime.Text = "PartTimeUser";
            this.radiobtn_partTime.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.LightGray;
            this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address.Location = new System.Drawing.Point(333, 166);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(214, 84);
            this.txt_address.TabIndex = 20;
            // 
            // txt_phone
            // 
            this.txt_phone.BackColor = System.Drawing.Color.LightGray;
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phone.Location = new System.Drawing.Point(148, 224);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(155, 29);
            this.txt_phone.TabIndex = 17;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.LightGray;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Location = new System.Drawing.Point(334, 108);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(154, 29);
            this.txt_password.TabIndex = 16;
            // 
            // txt_surname
            // 
            this.txt_surname.BackColor = System.Drawing.Color.LightGray;
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Location = new System.Drawing.Point(333, 50);
            this.txt_surname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(154, 29);
            this.txt_surname.TabIndex = 15;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.LightGray;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Location = new System.Drawing.Point(148, 166);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(155, 29);
            this.txt_email.TabIndex = 14;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.LightGray;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(148, 108);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(155, 29);
            this.txt_name.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.SlateGray;
            this.label8.Location = new System.Drawing.Point(330, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(144, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(146, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(329, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(144, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(329, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(144, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(144, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.FlatAppearance.BorderSize = 0;
            this.btn_güncelle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_güncelle.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_güncelle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_güncelle.Image = ((System.Drawing.Image)(resources.GetObject("btn_güncelle.Image")));
            this.btn_güncelle.Location = new System.Drawing.Point(159, 360);
            this.btn_güncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(156, 104);
            this.btn_güncelle.TabIndex = 1;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sil.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.Image")));
            this.btn_sil.Location = new System.Drawing.Point(337, 360);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(154, 104);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.BackColor = System.Drawing.Color.LightGray;
            this.txt_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userName.Location = new System.Drawing.Point(148, 50);
            this.txt_userName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(155, 29);
            this.txt_userName.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 526);
            this.tabControl1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Controls.Add(this.btnBack);
            this.panel4.Controls.Add(this.btnAlt);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 28);
            this.panel4.TabIndex = 42;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SlateGray;
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
            this.btnAlt.FlatAppearance.BorderSize = 0;
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlt.Image")));
            this.btnAlt.Location = new System.Drawing.Point(630, 0);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(35, 28);
            this.btnAlt.TabIndex = 12;
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SlateGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(664, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormUserManegement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 552);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserManegement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserManegement";
            this.Load += new System.EventHandler(this.FormUserManegement_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_UserType.ResumeLayout(false);
            this.groupBox_UserType.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_UserType;
        private System.Windows.Forms.RadioButton radiobtn_user;
        private System.Windows.Forms.RadioButton radiobtn_partTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnClose;
    }
}