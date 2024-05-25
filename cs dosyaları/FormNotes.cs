using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class FormNotes : Form
    {
        private User currentUser;

        public FormNotes(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Timestamp", "Timestamp");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            currentUser.NotesManager.ImportNotesFromExcel($"{currentUser.Username}_Notes.xlsx");
            LoadNotes();

        }

        private void FormNotes_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadNotes()
        {
            var notes = currentUser.NotesManager.GetAllNotes();

            foreach (var note in notes)
            {
                bool exists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == note.Id.ToString())
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    dataGridView1.Rows.Add(note.Id, note.Timestamp);
                }
            }
        }


        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string noteContent = textBox1.Text;
            if (!string.IsNullOrEmpty(noteContent))
            {
                currentUser.NotesManager.AddNote(noteContent);
                textBox1.Clear();
                LoadNotes();
                currentUser.NotesManager.ExportNotesToExcel(Convert.ToString( currentUser.Username));
            }
            else
            {
                MessageBox.Show("Note content cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int selectedNoteId = Convert.ToInt32(selectedRow.Cells[0].Value);

                string updatedContent = textBox1.Text;

                try
                {
                    currentUser.NotesManager.UpdateNote(selectedNoteId, updatedContent);
                    LoadNotes(); 
                    currentUser.NotesManager.ExportNotesToExcel(currentUser.Username); 
                    MessageBox.Show("Note updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a note to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int selectedNoteId = Convert.ToInt32(selectedRow.Cells[0].Value);

                try
                {
                    currentUser.NotesManager.DeleteNote(selectedNoteId);
                    LoadNotes(); // Refresh the DataGridView
                    currentUser.NotesManager.ExportNotesToExcel(currentUser.Username); // Export to Excel
                    MessageBox.Show("Note deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete note: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a note to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells[0].Value != null) // Ensure the cell value is not null
                {
                    int selectedNoteId = Convert.ToInt32(row.Cells[0].Value); // Get the ID from the first column
                    var selectedNote = currentUser.NotesManager.GetNoteById(selectedNoteId); // Get the selected note by ID
                    textBox1.Text = selectedNote.Content; // Set the content of the selected note to the textBox1
                }
            }
        }
    }

}
