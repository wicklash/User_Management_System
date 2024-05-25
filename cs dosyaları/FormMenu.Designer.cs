namespace WindowsFormsApp2
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnNotes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPhoneBook = new System.Windows.Forms.Button();
            this.btnOpenProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReminder = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.SystemColors.Control;
            this.btnNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNotes.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.Image")));
            this.btnNotes.Location = new System.Drawing.Point(41, 112);
            this.btnNotes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(150, 150);
            this.btnNotes.TabIndex = 26;
            this.btnNotes.Text = "Notlar";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotes.UseVisualStyleBackColor = false;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
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
            this.panel4.Size = new System.Drawing.Size(570, 28);
            this.panel4.TabIndex = 27;
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
            this.btnAlt.Location = new System.Drawing.Point(501, 0);
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
            this.btnClose.Location = new System.Drawing.Point(535, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPhoneBook
            // 
            this.btnPhoneBook.BackColor = System.Drawing.SystemColors.Control;
            this.btnPhoneBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhoneBook.FlatAppearance.BorderSize = 0;
            this.btnPhoneBook.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPhoneBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoneBook.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhoneBook.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPhoneBook.Image = ((System.Drawing.Image)(resources.GetObject("btnPhoneBook.Image")));
            this.btnPhoneBook.Location = new System.Drawing.Point(379, 112);
            this.btnPhoneBook.Name = "btnPhoneBook";
            this.btnPhoneBook.Size = new System.Drawing.Size(150, 150);
            this.btnPhoneBook.TabIndex = 28;
            this.btnPhoneBook.Text = "Telefon Kaydı";
            this.btnPhoneBook.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPhoneBook.UseVisualStyleBackColor = false;
            this.btnPhoneBook.Click += new System.EventHandler(this.btnPhoneBook_Click_2);
            // 
            // btnOpenProfile
            // 
            this.btnOpenProfile.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenProfile.FlatAppearance.BorderSize = 0;
            this.btnOpenProfile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenProfile.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpenProfile.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenProfile.Image")));
            this.btnOpenProfile.Location = new System.Drawing.Point(210, 112);
            this.btnOpenProfile.Name = "btnOpenProfile";
            this.btnOpenProfile.Size = new System.Drawing.Size(150, 150);
            this.btnOpenProfile.TabIndex = 29;
            this.btnOpenProfile.Text = "Profil";
            this.btnOpenProfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenProfile.UseVisualStyleBackColor = false;
            this.btnOpenProfile.Click += new System.EventHandler(this.btnOpenProfile_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(126, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 30;
            this.button1.Text = "Maaş";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReminder
            // 
            this.btnReminder.BackColor = System.Drawing.SystemColors.Control;
            this.btnReminder.FlatAppearance.BorderSize = 0;
            this.btnReminder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReminder.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReminder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnReminder.Image")));
            this.btnReminder.Location = new System.Drawing.Point(295, 282);
            this.btnReminder.Name = "btnReminder";
            this.btnReminder.Size = new System.Drawing.Size(150, 150);
            this.btnReminder.TabIndex = 31;
            this.btnReminder.Text = "Anımsatıcı";
            this.btnReminder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReminder.UseVisualStyleBackColor = false;
            this.btnReminder.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnUserManagement.Image")));
            this.btnUserManagement.Location = new System.Drawing.Point(243, 38);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(85, 48);
            this.btnUserManagement.TabIndex = 32;
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnPhoneBook);
            this.Controls.Add(this.btnReminder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenProfile);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnNotes);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseUp);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPhoneBook;
        private System.Windows.Forms.Button btnOpenProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReminder;
        private System.Windows.Forms.Button btnUserManagement;
    }
}