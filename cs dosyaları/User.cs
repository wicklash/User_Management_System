using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Text;

namespace WindowsFormsApp2
{
    public class User
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressDescription { get; set; }
        public PhoneBook PhoneBook { get; set; } // Added PhoneBook member
        public NotesManager NotesManager { get; set; } // Added NotesManager member

        private string ValidateUserInfo(string username, string name, string surname, string email, string password, string phoneNumber)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (!IsValidUsername(username))
            {
                errorMessage.AppendLine("Invalid username. Username must be between 3 and 20 characters and can include Turkish and English letters, numbers, and underscores.");
            }
            if (!IsValidNameOrSurname(name))
            {
                errorMessage.AppendLine("Invalid name. Name can contain Turkish and English letters and spaces, and must be between 1 and 50 characters.");
            }
            if (!IsValidNameOrSurname(surname))
            {
                errorMessage.AppendLine("Invalid surname. Surname can contain Turkish and English letters and spaces, and must be between 1 and 50 characters.");
            }
            if (!IsValidEmail(email))
            {
                errorMessage.AppendLine("Invalid email address.");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage.AppendLine("Password cannot be empty.");
            }
            if (!IsValidPhoneNumber(phoneNumber))
            {
                errorMessage.AppendLine("Invalid phone number. Phone number must be in the format (555) 555 55 55.");
            }

            return errorMessage.ToString();
        }

        public User(string username, string name, string surname, string email, string password, UserType type, string phoneNumber, string addressDescription, out string errorMessage)
        {
            errorMessage = ValidateUserInfo(username, name, surname, email, password, phoneNumber);

            if (string.IsNullOrEmpty(errorMessage))
            {
                Username = username;
                Name = name;
                Surname = surname;
                Email = email.TrimEnd();
                Password = password;
                Type = type;
                PhoneNumber = phoneNumber.TrimEnd();
                AddressDescription = addressDescription;
                PhoneBook = new PhoneBook(); // Initialize the PhoneBook
                NotesManager = new NotesManager(); // Initialize the NotesManager
            }
        }

        public string UpdateUserInfo(string newUsername, string newName, string newSurname, string newEmail, string newPassword, string newPhoneNumber, string newAddressDescription)
        {
            string errorMessage = ValidateUserInfo(newUsername, newName, newSurname, newEmail, newPassword, newPhoneNumber);

            if (string.IsNullOrEmpty(errorMessage))
            {
                Username = newUsername;
                Name = newName;
                Surname = newSurname;
                Email = newEmail;
                Password = newPassword;
                PhoneNumber = newPhoneNumber;
                AddressDescription = newAddressDescription;
            }

            return errorMessage;
        }

        private bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_ğüşöçİĞÜŞÖÇı]{3,20}$");
        }

        private bool IsValidNameOrSurname(string nameOrSurname)
        {
            return Regex.IsMatch(nameOrSurname, @"^[a-zA-ZğüşöçİĞÜŞÖÇı ]{1,50}$");
        }

        private bool IsValidEmail(string email)
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

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3} \d{2} \d{2}\s*$");
        }
    }
}