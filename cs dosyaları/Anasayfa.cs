using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Anasayfa;


namespace WindowsFormsApp2
{

    public partial class Anasayfa : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private UserManager userManager;
        private User currentUser;

        public Anasayfa()
        {

            InitializeComponent();
            userManager = new UserManager();
            userManager.ImportUsersFromExcel("User.xlsx");
  
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool check = userManager.LoginUser(txtUserName.Text, txtPassword.Text);
            if (check)
            {
                currentUser = userManager.getCurrentUser(txtUserName.Text, txtPassword.Text);
                this.Hide();  // Hide Form1 when moving to FormMenu
                FormMenu form = new FormMenu(currentUser, userManager);

                // Handle the FormClosed event to show Form1 again when FormMenu is closed
                form.FormClosed += (s, args) => this.Show();

                form.ShowDialog();

                txtUserName.Text = "";
                txtPassword.Text = "";

            }
            else
            {
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            this.Hide();
            formKayıt form = new formKayıt(userManager);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Anasayfa_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Anasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Anasayfa_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
