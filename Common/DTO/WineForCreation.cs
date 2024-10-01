using System.ComponentModel.DataAnnotations;

namespace Common.DTO
{
    public class WineForCreation
    {
        [Required]
        public string Name { get; set; }

        public string Variety { get; set; }

        public int Year { get; set; }

        public string Region { get; set; }

        public int Stock { get; set; }
    }
}
