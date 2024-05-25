using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class formKayıt : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        private UserManager userManager;

        public formKayıt(UserManager sharedUserManager)
        {
            InitializeComponent();
            userManager = sharedUserManager;
        }
        private void formKayıt_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            userManager.AddUser(txtUserName.Text, txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, txtPhoneNumber.Text, txtAdress.Text);
            userManager.ExportUsersToExcel("User.xlsx");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formKayıt_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void formKayıt_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void formKayıt_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}
