using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    public class PhoneBook
    {
        private List<PhoneBookEntry> entries;

        public PhoneBook()
        {
            entries = new List<PhoneBookEntry>();
        }

        public void AddEntry(string name, string surname, string phoneNumber, string address, string description, string email, out string errorMessage)
        {
            var entry = new PhoneBookEntry(name, surname, phoneNumber, address, description, email, out errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
            {
                entries.Add(entry);
            }
        }
        public void RemoveEntryAt(int index)
        {
            if (index >= 0 && index < entries.Count)
            {
                entries.RemoveAt(index);
            }
        }

        public List<PhoneBookEntry> GetEntries()
        {
            return entries;
        }
        public void ExportToExcel(string userName)
        {
            // Create a new workbook and worksheet
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("PhoneBook");

                // Add headers
                worksheet.Cell(1, 1).Value = "Name";
                worksheet.Cell(1, 2).Value = "Surname";
                worksheet.Cell(1, 3).Value = "Phone Number";
                worksheet.Cell(1, 4).Value = "Address";
                worksheet.Cell(1, 5).Value = "Description";
                worksheet.Cell(1, 6).Value = "Email";

                // Add entries
                for (int i = 0; i < entries.Count; i++)
                {
                    var entry = entries[i];
                    worksheet.Cell(i + 2, 1).Value = entry.Name;
                    worksheet.Cell(i + 2, 2).Value = entry.Surname;
                    worksheet.Cell(i + 2, 3).Value = entry.PhoneNumber;
                    worksheet.Cell(i + 2, 4).Value = entry.Address;
                    worksheet.Cell(i + 2, 5).Value = entry.Description;
                    worksheet.Cell(i + 2, 6).Value = entry.Email;
                }

                // Save the workbook
                string fileName = $"{userName}_PhoneBook.xlsx";
                workbook.SaveAs(fileName);
            }
        }
        public void ImportFromExcel(string filePath, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!File.Exists(filePath))
            {
                errorMessage = "The file does not exist.";
                return;
            }

            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed();

                    foreach (var row in rows)
                    {
                        if (row.RowNumber() == 1) continue; 

                        var name = row.Cell(1).GetValue<string>();
                        var surname = row.Cell(2).GetValue<string>();
                        var phoneNumber = row.Cell(3).GetValue<string>();
                        var address = row.Cell(4).GetValue<string>();
                        var description = row.Cell(5).GetValue<string>();
                        var email = row.Cell(6).GetValue<string>();

                        AddEntry(name, surname, phoneNumber, address, description, email, out errorMessage);
                        if (!string.IsNullOrEmpty(errorMessage))
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = $"An error occurred while importing the file: {ex.Message}";
            }
        }
    }
}
