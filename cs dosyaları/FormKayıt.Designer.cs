namespace WindowsFormsApp2
{
    partial class formKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formKayıt));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btnAlt);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 28);
            this.panel4.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.SlateGray;
            this.btnAlt.FlatAppearance.BorderSize = 0;
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlt.Image")));
            this.btnAlt.Location = new System.Drawing.Point(393, 0);
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
            this.btnClose.Location = new System.Drawing.Point(428, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(60, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Adı:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightGray;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(60, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 23);
            this.txtName.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.LightGray;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserName.Location = new System.Drawing.Point(60, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(149, 23);
            this.txtUserName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(60, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SlateGray;
            this.label7.Location = new System.Drawing.Point(60, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon No:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(242, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SlateGray;
            this.label8.Location = new System.Drawing.Point(187, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adres:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(242, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.LightGray;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber.Location = new System.Drawing.Point(60, 183);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(149, 23);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.LightGray;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.ForeColor = System.Drawing.Color.DimGray;
            this.txtSurname.Location = new System.Drawing.Point(242, 120);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(149, 23);
            this.txtSurname.TabIndex = 4;
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.Color.LightGray;
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdress.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdress.Location = new System.Drawing.Point(60, 258);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(331, 78);
            this.txtAdress.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(242, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(157, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 42);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Kayıt Ol";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(242, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(242, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtAdress);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(6, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 410);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(188, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // formKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.formKayıt_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formKayıt_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formKayıt_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formKayıt_MouseUp);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}