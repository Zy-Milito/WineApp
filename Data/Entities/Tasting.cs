using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Tasting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public List<Wine> Wines { get; set; } = new List<Wine>();

        public List<string> Guests { get; set; } = new List<string>();
    }
}
