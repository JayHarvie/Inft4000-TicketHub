using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TicketHub
{
    public class PhoneNumberAttribute : ValidationAttribute
    {
        private static readonly Regex PhoneRegex = new Regex(@"^\+?\d{1,4}?[ -]?\(?\d{1,3}?\)?[ -]?\d{1,4}[ -]?\d{1,4}$", RegexOptions.Compiled);

        public override bool IsValid(object value)
        {
            if (value == null) return true;  // You can return false if the field is required.

            string phoneNumber = value.ToString();
            return PhoneRegex.IsMatch(phoneNumber);
        }

        public override string FormatErrorMessage(string name)
        {
            return $"not a valid phone number.";
        }
    }
}
