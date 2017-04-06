
using System.ComponentModel.DataAnnotations;

namespace Camera.Models.View.User
{
    public class RegisterUserVM
    {
        [RegularExpression("[a-zA-Z]{4,20}",ErrorMessage = "Username have to be only letters between 4 and 20 symbols")]
        public string Username { get; set; }
        public string Email { get; set; }
        [RegularExpression("[a-z0-9]{3,}", ErrorMessage = "Password have to contain only lowercase letters and digits, and have to be minimum 3 symbols")]

        public string Password { get; set; }
        [RegularExpression("\\+\\d{10,12}", ErrorMessage = "Phone starts with + and contain between 10 and 12 digits")]

        public string Phone { get; set; }
    }
}
