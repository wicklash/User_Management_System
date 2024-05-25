using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void AddUser(string username, string name, string surname, string email, string password, string phoneNumber, string addressDescription)
        {
            if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("A user with the same username already exists.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserType type = UserType.User;
            if (!users.Any())
            {
                type = UserType.Admin;
            }

            string errorMessage;
            User newUser = new User(username, name, surname, email, password, type, phoneNumber, addressDescription, out errorMessage);

            if (string.IsNullOrEmpty(errorMessage))
            {
                users.Add(newUser);
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show(errorMessage, "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportUsersToExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Users");

                // Add headers
                worksheet.Cell(1, 1).Value = "Username";
                worksheet.Cell(1, 2).Value = "Name";
                worksheet.Cell(1, 3).Value = "Surname";
                worksheet.Cell(1, 4).Value = "Email";
                worksheet.Cell(1, 5).Value = "Password";
                worksheet.Cell(1, 6).Value = "Type";
                worksheet.Cell(1, 7).Value = "PhoneNumber";
                worksheet.Cell(1, 8).Value = "AddressDescription";

                // Add users
                int row = 2;
                foreach (User user in users)
                {
                    worksheet.Cell(row, 1).SetValue(user.Username);
                    worksheet.Cell(row, 2).SetValue(user.Name);
                    worksheet.Cell(row, 3).SetValue(user.Surname);
                    worksheet.Cell(row, 4).SetValue(user.Email);
                    worksheet.Cell(row, 5).SetValue(user.Password);
                    worksheet.Cell(row, 6).SetValue(user.Type.ToString());
                    worksheet.Cell(row, 7).SetValue(user.PhoneNumber);
                    worksheet.Cell(row, 8).SetValue(user.AddressDescription);
                    row++;
                }

                // Adjust columns to fit content
                worksheet.Columns().AdjustToContents();

                // Save the workbook
                workbook.SaveAs(filePath);
            }
        }


        public void ImportUsersFromExcel(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RangeUsed().RowsUsed().Skip(1);

                    foreach (var row in rows)
                    {
                        string username = row.Cell(1).GetValue<string>();
                        string name = row.Cell(2).GetValue<string>();
                        string surname = row.Cell(3).GetValue<string>();
                        string email = row.Cell(4).GetValue<string>();
                        string password = row.Cell(5).GetValue<string>();
                        UserType type = (UserType)Enum.Parse(typeof(UserType), row.Cell(6).GetValue<string>());
                        string phoneNumber = row.Cell(7).GetValue<string>();
                        string addressDescription = row.Cell(8).GetValue<string>();

                        string errorMessage;
                        User newUser = new User(username, name, surname, email, password, type, phoneNumber, addressDescription, out errorMessage);

                        if (string.IsNullOrEmpty(errorMessage))
                        {
                            users.Add(newUser);
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, "Error Importing User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public string GetAllUserDetails()
        {
            StringBuilder userDetails = new StringBuilder();
            foreach (User user in users)
            {
                userDetails.AppendLine($"Username: {user.Username}, Name: {user.Name}, Surname: {user.Surname}, Email: {user.Email}, Type: {user.Type}, Password: {user.Password}, PhoneNumber: {user.PhoneNumber}, Address: {user.AddressDescription}");
            }
            return userDetails.ToString();
        }

        public bool LoginUser(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public User getCurrentUser(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
        public void deleteUser(string username)
        {
            users.RemoveAll(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}