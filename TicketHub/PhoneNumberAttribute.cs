using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TicketHub
{
    public class PhoneNumberAttribute : ValidationAttribute
    {
        // Updated regex to match various phone number formats
        private static readonly Regex PhoneRegex = new Regex(@"^\(?\d{3}\)?[-\s]?\d{3}[-\s]?\d{4}$", RegexOptions.Compiled);

        // Length limit check for exactly 10 digits
        private const int ValidPhoneLength = 10;

        public override bool IsValid(object? value)
        {
            if (value == null) return false;  // You can return false if the field is required.

            string? phoneNumber = value?.ToString();

            // Check if the phone number matches the regex pattern
            if (phoneNumber != null && PhoneRegex.IsMatch(phoneNumber))
            {
                // Remove non-digit characters for length check (like spaces, dashes, and parentheses)
                var digitOnlyPhoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());

                // Ensure the phone number has exactly 10 digits
                return digitOnlyPhoneNumber.Length == ValidPhoneLength;
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} is not a valid phone number. It must be exactly 10 digits long and in a valid format.";
        }
    }
}
