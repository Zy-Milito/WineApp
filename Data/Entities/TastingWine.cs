namespace Data.Entities
{
    public class TastingWine
    {
        public int WineId { get; set; }

        public Wine Wine { get; set; }

        public int TastingId { get; set; }

        public Tasting Tasting { get; set; }
    }
}
