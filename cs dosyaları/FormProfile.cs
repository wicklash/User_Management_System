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
    public partial class FormProfile : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        private User currentUser;
        private UserManager userManager;
        public FormProfile(User currentUser,UserManager userManager)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.userManager = userManager;
            txtUserName.Text = Convert.ToString(currentUser.Username);
            txtName.Text = Convert.ToString(currentUser.Name);
            txtSurname .Text = Convert.ToString(currentUser.Surname);
            txtEmail.Text = Convert.ToString(currentUser.Email);
            txtPassword.Text = Convert.ToString(currentUser.Password);
            txtPhoneNumber.Text = Convert.ToString(currentUser.PhoneNumber);
            txtAdress.Text = Convert.ToString(currentUser.AddressDescription);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeUserİnfo_Click(object sender, EventArgs e)
        {
            string errorMessage = currentUser.UpdateUserInfo(txtUserName.Text,txtName.Text,txtSurname.Text,txtEmail.Text,txtPassword.Text,txtPhoneNumber.Text,txtAdress.Text);

            if (string.IsNullOrEmpty(errorMessage))
            {
                userManager.ExportUsersToExcel("User.xlsx");
                MessageBox.Show("User information updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormProfile_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void FormProfile_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
