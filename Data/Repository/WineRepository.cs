using Data.Entities;

namespace Data.Repository
{
    public class WineRepository : IWineRepository
    {
        public List<Wine> Wines { get; set; }
        public WineRepository()
        {
            Wines = new List<Wine>()
            {
                new Wine()
                {
                    Id = 1,
                    Name = "Mythic",
                    Variety = "Malbec",
                    Year = 2023,
                    Region = "Valle de Uco",
                    Stock = 21,
                    CreatedAt = DateTime.Now
                }
            };
        }
        public List<Wine> GetAll()
        {
            return Wines;
        }

        public void AddWine(Wine newWine)
        {
            newWine.Id = Wines.Count() + 1;
            Wines.Add(newWine);
        }

        public void AddStock(int amount, string wineName)
        {
            Wines.Single(w => w.Name == wineName).AddStock(amount);
        }

        public void RemoveStock(int amount, string wineName)
        {
            Wines.Single(w => w.Name == wineName).RemoveStock(amount);
        }
    }
}
