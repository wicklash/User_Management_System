using salary_calculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMenu : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        private User currentUser;
        private UserManager userManager;
        public FormMenu(User currentUser,UserManager userManager)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.userManager = userManager;

            InitializeUserManagementButton();
        }
        private void InitializeUserManagementButton()
        {
            if (currentUser.Type.ToString() != "Admin")
            {
                btnUserManagement.Visible = false;
                btnUserManagement.Enabled = false;
            }
            else
            {
                btnUserManagement.Visible = true;
                btnUserManagement.Enabled = true;
            }
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNotes form = new FormNotes(currentUser);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Hesaptan çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (cikis == DialogResult.OK)
            {
                this.Close();
            }
            else { return; }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void FormMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnPhoneBook_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            FormPhoneBook form = new FormPhoneBook(currentUser);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnOpenProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfile form = new FormProfile(currentUser, userManager);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReminder form = new FormReminder(currentUser, userManager);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (currentUser.Type.ToString() != "Admin")
            {
                MessageBox.Show("Sadece Admin Bu Sekmeye Erişebilir!");
            }
            else
            {
                this.Hide();
                FormUserManegement form = new FormUserManegement(userManager);
                form.FormClosed += Form_FormClosed;
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalaryCalculator form = new FormSalaryCalculator(currentUser);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }
    }
}
