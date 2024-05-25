namespace WindowsFormsApp2
{
    partial class FormReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReminder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateReminder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.btnDeleteReminder = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(761, 28);
            this.panel4.TabIndex = 28;
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
            this.btnAlt.Location = new System.Drawing.Point(692, 0);
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
            this.btnClose.Location = new System.Drawing.Point(726, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 416);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anımsatıcı";
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 374);
            this.dataGridView1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateReminder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtSummary);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.btnAddReminder);
            this.tabPage1.Controls.Add(this.btnDeleteReminder);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(753, 380);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Kayıt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateReminder
            // 
            this.btnUpdateReminder.FlatAppearance.BorderSize = 0;
            this.btnUpdateReminder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdateReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReminder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateReminder.Image")));
            this.btnUpdateReminder.Location = new System.Drawing.Point(504, 189);
            this.btnUpdateReminder.Name = "btnUpdateReminder";
            this.btnUpdateReminder.Size = new System.Drawing.Size(100, 115);
            this.btnUpdateReminder.TabIndex = 40;
            this.btnUpdateReminder.Text = "Güncelle";
            this.btnUpdateReminder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateReminder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(40, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Anımsatıcı Türü";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel6.Location = new System.Drawing.Point(401, 51);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 15);
            this.panel6.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel7.Location = new System.Drawing.Point(401, 168);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(307, 15);
            this.panel7.TabIndex = 37;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel8.Location = new System.Drawing.Point(693, 66);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(15, 102);
            this.panel8.TabIndex = 36;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel9.Location = new System.Drawing.Point(401, 66);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(15, 102);
            this.panel9.TabIndex = 35;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightGray;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.Location = new System.Drawing.Point(416, 66);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 102);
            this.txtDescription.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Location = new System.Drawing.Point(44, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(307, 15);
            this.panel5.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(44, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 15);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(336, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 102);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(44, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 102);
            this.panel1.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Task",
            "Meeting"});
            this.comboBox1.Location = new System.Drawing.Point(44, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 31);
            this.comboBox1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(397, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Açıklama";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(40, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Özet";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.Color.LightGray;
            this.txtSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSummary.ForeColor = System.Drawing.Color.DimGray;
            this.txtSummary.Location = new System.Drawing.Point(59, 66);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(277, 102);
            this.txtSummary.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy   hh:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 30);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.FlatAppearance.BorderSize = 0;
            this.btnAddReminder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReminder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReminder.Image")));
            this.btnAddReminder.Location = new System.Drawing.Point(396, 189);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(100, 115);
            this.btnAddReminder.TabIndex = 23;
            this.btnAddReminder.Text = "Ekle";
            this.btnAddReminder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddReminder.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteReminder.FlatAppearance.BorderSize = 0;
            this.btnDeleteReminder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReminder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteReminder.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteReminder.Image")));
            this.btnDeleteReminder.Location = new System.Drawing.Point(612, 190);
            this.btnDeleteReminder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(100, 115);
            this.btnDeleteReminder.TabIndex = 7;
            this.btnDeleteReminder.Text = "Sil";
            this.btnDeleteReminder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteReminder.UseVisualStyleBackColor = false;
            // 
            // FormReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 444);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReminder";
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDeleteReminder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnUpdateReminder;
    }
}