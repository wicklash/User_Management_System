using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class PhoneBookEntry
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }

        public PhoneBookEntry(string name, string surname, string phoneNumber, string address, string description, string email, out string errorMessage)
        {
            errorMessage = "";

            if (!IsValidNameOrSurname(name))
            {
                errorMessage += "Invalid name. Name can contain Turkish and English letters and spaces, and must be between 1 and 50 characters.\n";
            }
            if (!IsValidNameOrSurname(surname))
            {
                errorMessage += "Invalid surname. Surname can contain Turkish and English letters and spaces, and must be between 1 and 50 characters.\n";
            }
            if (!IsValidPhoneNumber(phoneNumber))
            {
                errorMessage += "Invalid phone number. Phone number must be in the format (555) 555 55 55.\n";
            }
            if (!IsValidEmail(email))
            {
                errorMessage += "Invalid email address.\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                Name = name;
                Surname = surname;
                PhoneNumber = phoneNumber.TrimEnd();
                Address = address;
                Description = description;
                Email = email.TrimEnd();
            }
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
                    var idn = new IdnMapping();
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