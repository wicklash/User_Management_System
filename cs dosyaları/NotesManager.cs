using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Globalization;

namespace WindowsFormsApp2
{
    public class NotesManager
    {
        private List<Note> notes;
        private int nextId;

        public NotesManager()
        {
            notes = new List<Note>();
            nextId = 1; // Initialize nextId to 1
        }

        public void AddNote(string content)
        {
            var note = new Note(nextId, content);
            notes.Add(note);
            nextId++;
        }

        public void UpdateNote(int id, string newContent)
        {
            var note = notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                note.UpdateContent(newContent);
            }
            else
            {
                throw new Exception("Note not found.");
            }
        }

        public void DeleteNote(int id)
        {
            var note = notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                notes.Remove(note);
            }
            else
            {
                throw new Exception("Note not found.");
            }
        }

        public List<Note> GetAllNotes()
        {
            return notes;
        }

        public Note GetNoteById(int id)
        {
            var note = notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                return note;
            }
            else
            {
                throw new Exception("Note not found.");
            }
        }

        public void ExportNotesToExcel(string userName)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Notes");

                worksheet.Cell("A1").Value = "ID";
                worksheet.Cell("B1").Value = "Content";
                worksheet.Cell("C1").Value = "Timestamp";

                for(int i = 0; i < notes.Count; i++)
                {
                    var note = notes[i];
                    worksheet.Cell(i + 2, 1).Value = note.Id;
                    worksheet.Cell(i + 2, 2).Value = note.Content;
                    worksheet.Cell(i + 2, 3).Value = note.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                }
                string fileName = $"{userName}_Notes.xlsx";
                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(fileName);
            }
        }

        public void ImportNotesFromExcel(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed().Skip(1); // Skip header row

                    foreach (var row in rows)
                    {
                        try
                        {
                            var id = row.Cell(1).GetValue<int>();
                            var content = row.Cell(2).GetValue<string>();
                            var timestampString = row.Cell(3).GetValue<string>(); // Get the timestamp as a string

                            DateTime timestamp;
                            if (DateTime.TryParseExact(timestampString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timestamp))
                            {
                                var note = new Note(id, content, timestamp);
                                notes.Add(note);

                                if (id >= nextId)
                                {
                                    nextId = id + 1; // Ensure nextId is always greater than any existing ID
                                }
                            }
                            else
                            {
                                throw new Exception($"Invalid date format: {timestampString}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error processing row {row.RowNumber()}: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

    }
}
