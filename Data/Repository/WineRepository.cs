using Data.Entities;

namespace Data.Repository
{
    public class WineRepository : IWineRepository
    {
        private readonly ApplicationContext _context;
        public WineRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Wine> GetAll()
        {
            return _context.Wines.ToList();
        }

        public void AddWine(Wine newWine)
        {
            newWine.Id = _context.Wines.Count() + 1;
            _context.Wines.Add(newWine);
        }

        public void AddStock(int amount, string wineName)
        {
            _context.Wines.Single(w => w.Name == wineName).AddStock(amount);
        }

        public void RemoveStock(int amount, string wineName)
        {
            _context.Wines.Single(w => w.Name == wineName).RemoveStock(amount);
        }
    }
}
