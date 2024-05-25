using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml.Office;

namespace WindowsFormsApp2
{
    public partial class FormUserManegement : Form
    {
        private UserManager userManager;
        private int selectedRowIndex = -1;

        List<User> users = new List<User>();
        User selectedUser;
        string userType;
        public FormUserManegement(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            users = userManager.GetUsers();
        }

        private void FormUserManegement_Load(object sender, EventArgs e)
        {
            // excel dosyasındaki kullanıcıları gridView'da gösterme
            dataGridView1.DataSource = users;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["NotesManager"].Visible = false;
            dataGridView1.Columns["PhoneBook"].Visible = false;           
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            DialogResult silme = MessageBox.Show("Kullanıcıyı ve Kullanıcıya Ait Tüm Bilgileri Silmek İstediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if(silme == DialogResult.Cancel)
            {
                return;
            }
            // Admin üzerinde işlem yapılamaz!
            if(selectedUser.Type.ToString() == "Admin")
            {
                MessageBox.Show("Admin üzerinde işlem yapılamaz!");
                return;
            }
            string usernameToDelete = txt_userName.Text;
            userManager.deleteUser(usernameToDelete);
            users.RemoveAll(u => u.Username == usernameToDelete); // Remove user from local list

            // Update the DataGridView
            dataGridView1.DataSource = null; // Clear the DataSource
            dataGridView1.DataSource = users; // Rebind the DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["NotesManager"].Visible = false;
            dataGridView1.Columns["PhoneBook"].Visible = false;

            userManager.ExportUsersToExcel("User.xlsx");
            MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (File.Exists($"{usernameToDelete}_PhoneBook.xlsx"))
            {
                File.Delete($"{usernameToDelete}_PhoneBook.xlsx");
            }

            if (File.Exists($"{usernameToDelete}_Notes.xlsx"))
            {
                File.Delete($"{usernameToDelete}_Notes.xlsx");
            }

            if (File.Exists($"{usernameToDelete}_Reminder.xlsx"))
            {
                File.Delete($"{usernameToDelete}_Reminder.xlsx");
            }

            txt_userName.Text = "";
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            txt_phone.Text = "";
            txt_address.Text = "";
            radiobtn_partTime.Checked = false;
            radiobtn_user.Checked = false;
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            // Admin üzerinde işlem yapılamaz!
            if (selectedUser.Type.ToString() == "Admin")
            {
                MessageBox.Show("Admin üzerinde işlem yapılamaz!");
                return;
            }

            if (radiobtn_partTime.Checked)
            {
                userType = radiobtn_partTime.Text;
            }
            else if (radiobtn_user.Checked)
            {
                userType = radiobtn_user.Text;
            }

            if (selectedRowIndex >= 0)
            {
                // Update the selected row's cells with the values from the text boxes
                dataGridView1.Rows[selectedRowIndex].Cells["Username"].Value = txt_userName.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Name"].Value = txt_name.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Surname"].Value = txt_surname.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Email"].Value = txt_email.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Password"].Value = txt_password.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["PhoneNumber"].Value = txt_phone.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["AddressDescription"].Value = txt_address.Text;

                if (!isValidEmail(txt_email.Text))
                {
                    MessageBox.Show("Invalid email address.");
                    return;
                }

                if (!isValidPhoneNumber(txt_phone.Text))
                {
                    MessageBox.Show("Invalid phone number. Phone number must be in the format (555) 555 55 55.");
                    return;
                }

                // Update the corresponding entry in the user's PhoneBook
                selectedUser.Username = txt_userName.Text;
                selectedUser.Name = txt_name.Text;
                selectedUser.Surname = txt_surname.Text;
                selectedUser.Email = txt_email.Text.TrimEnd();
                selectedUser.Password = txt_password.Text;
                selectedUser.PhoneNumber = txt_phone.Text.TrimEnd();
                selectedUser.AddressDescription = txt_address.Text;
                selectedUser.Type = (UserType)Enum.Parse(typeof(UserType), userType);

                userManager.ExportUsersToExcel("User.xlsx");

                txt_userName.Text = "";
                txt_name.Text = "";
                txt_surname.Text = "";
                txt_email.Text = "";
                txt_password.Text = "";
                txt_phone.Text = "";
                txt_address.Text = "";
                radiobtn_partTime.Checked = false;
                radiobtn_user.Checked = false;
                tabControl1.SelectedTab = tabPage1;

                // Reset the selected row index
                selectedRowIndex = -1;

                MessageBox.Show("Entry updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Please select a row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Set the selected row index
                selectedRowIndex = e.RowIndex;
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txt_userName.Text = selectedRow.Cells["Username"].Value.ToString();
                txt_name.Text = selectedRow.Cells["Name"].Value.ToString();
                txt_surname.Text = selectedRow.Cells["Surname"].Value.ToString();
                txt_email.Text = selectedRow.Cells["Email"].Value.ToString();
                txt_password.Text = selectedRow.Cells["Password"].Value.ToString();
                txt_phone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txt_address.Text = selectedRow.Cells["AddressDescription"].Value.ToString();
                userType = selectedRow.Cells["Type"].Value.ToString();

                if (userType == radiobtn_user.Text)
                {
                    radiobtn_user.Checked = true;
                }
                else if (userType == radiobtn_partTime.Text)
                {
                    radiobtn_partTime.Checked = true;
                }
                else if (userType == "Admin")
                {
                    radiobtn_user.Checked = false;
                    radiobtn_partTime.Checked = false;
                }

                foreach (var user in users)
                {
                    if (user.Name == txt_name.Text)
                    {
                        selectedUser = user;
                    }
                }

                tabControl1.SelectedTab = tabPage1;
            }
        }

        bool isValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new System.Globalization.IdnMapping();
                    var domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (Exception)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+\s*$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        bool isValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3} \d{2} \d{2}\s*$");
        }
    }
}