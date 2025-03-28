using System.ComponentModel.DataAnnotations;

namespace TicketHub
{
    public class Ticket
    {
        [Required]
        public int ConcertId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(30, ErrorMessage = "Name needs to be a maximum length of 30 chracters.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [Range(1, 6, ErrorMessage = "Quantity must be in range 1 and 6.")]
        public int Quantity { get; set; }

        [Required]
        [CreditCard(ErrorMessage = "Must be a valid credit card number.")]
        public string CreditCard { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^(0[1-9]|1[0-2])\/?([0-9]{2})$", ErrorMessage = "Expiration must be in MM/YY format.")]
        public string Expiration { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[0-9]{3,4}$", ErrorMessage = "Security code must be 3 or 4 digits.")]
        public string SecurityCode { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\d+\s[A-Za-z]+\s[A-Za-z]+$", ErrorMessage = "Street address must be in the format '11 Example Rd'.")]
        [MaxLength(60, ErrorMessage = "Address cannot exceed 60 characters.")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "City name can only contain letters and spaces.")]
        [MaxLength(50, ErrorMessage = "City name cannot exceed 50 characters.")]
        public string City { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Province name can only contain letters and spaces.")]
        [MaxLength(30, ErrorMessage = "Province name cannot exceed 50 characters.")]
        public string Province { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$", ErrorMessage = "Postal code must be in the format A1A1A1.")]
        [Range(6, 6, ErrorMessage = "Postal code must be 6 characters.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Country name can only contain letters and spaces.")]
        [MaxLength(50, ErrorMessage = "Country name cannot exceed 50 characters.")]
        public string Country { get; set; } = string.Empty;
    }
}
