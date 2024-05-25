using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class FormPhoneBook : Form
    {
        private User currentUser;
        private int selectedRowIndex = -1;

        public FormPhoneBook(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Surname", "Surname");
            dataGridView1.Columns.Add("PhoneNumber", "Phone Number");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Email", "Email");

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void FormPhoneBook_Load(object sender, EventArgs e)
        {
            currentUser.PhoneBook.ImportFromExcel($"{currentUser.Username}_PhoneBook.xlsx", out string errorMessage);
            var entries = currentUser.PhoneBook.GetEntries();
            foreach (var entry in entries)
            {
                dataGridView1.Rows.Add(entry.Name, entry.Surname, entry.PhoneNumber, entry.Address, entry.Description, entry.Email);
            }
        }

        private void btnKayıtOluştur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtAdress.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorMessage;
            currentUser.PhoneBook.AddEntry(txtName.Text, txtSurname.Text, txtPhoneNumber.Text, txtAdress.Text, txtDescription.Text, txtEmail.Text, out errorMessage);
            currentUser.PhoneBook.ExportToExcel(Convert.ToString(currentUser.Username));
            // Check if there's no error message before updating the DataGridView
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Clear existing rows in the DataGridView
                dataGridView1.Rows.Clear();

                // Get the updated entries from the PhoneBook
                var entries = currentUser.PhoneBook.GetEntries();

                // Add each entry to the DataGridView
                foreach (var entry in entries)
                {
                    dataGridView1.Rows.Add(entry.Name, entry.Surname, entry.PhoneNumber, entry.Address, entry.Description, entry.Email);
                }

                // Clear TextBoxes after adding entry
                txtName.Clear();
                txtSurname.Clear();
                txtPhoneNumber.Clear();
                txtAdress.Clear();
                txtDescription.Clear();
                txtEmail.Clear();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Set the selected row index
                selectedRowIndex = e.RowIndex;
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtSurname.Text = selectedRow.Cells["Surname"].Value.ToString();
                txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtAdress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                tabControl1.SelectedTab=tabPage1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                // Update the selected row's cells with the values from the text boxes
                dataGridView1.Rows[selectedRowIndex].Cells["Name"].Value = txtName.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Surname"].Value = txtSurname.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["PhoneNumber"].Value = txtPhoneNumber.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Address"].Value = txtAdress.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Description"].Value = txtDescription.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Email"].Value = txtEmail.Text;

                // Update the corresponding entry in the user's PhoneBook
                var updatedEntry = currentUser.PhoneBook.GetEntries()[selectedRowIndex];
                updatedEntry.Name = txtName.Text;
                updatedEntry.Surname = txtSurname.Text;
                updatedEntry.PhoneNumber = txtPhoneNumber.Text;
                updatedEntry.Address = txtAdress.Text;
                updatedEntry.Description = txtDescription.Text;
                updatedEntry.Email = txtEmail.Text;

                currentUser.PhoneBook.ExportToExcel(Convert.ToString(currentUser.Username));
                // Clear the text boxes after updating
                txtName.Clear();
                txtSurname.Clear();
                txtPhoneNumber.Clear();
                txtAdress.Clear();
                txtDescription.Clear();
                txtEmail.Clear();

                // Reset the selected row index
                selectedRowIndex = -1;

                MessageBox.Show("Entry updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                // Remove the selected row from the DataGridView
                dataGridView1.Rows.RemoveAt(selectedRowIndex);

                // Remove the corresponding entry from the PhoneBook
                currentUser.PhoneBook.RemoveEntryAt(selectedRowIndex);

                // Clear the text boxes after deletion
                txtName.Clear();
                txtSurname.Clear();
                txtPhoneNumber.Clear();
                txtAdress.Clear();
                txtDescription.Clear();
                txtEmail.Clear();

                currentUser.PhoneBook.ExportToExcel(Convert.ToString(currentUser.Username));

                // Reset the selected row index
                selectedRowIndex = -1;

                MessageBox.Show("Entry deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
