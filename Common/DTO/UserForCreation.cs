using System.ComponentModel.DataAnnotations;

namespace Common.DTO
{
    public class UserForCreation
    {
        [Required]
        public string Username { get; set; }

        [Length(8, 30)]
        public string Password { get; set; }
    }
}
