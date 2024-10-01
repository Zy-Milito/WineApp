using Common.DTO;
using Data.Entities;
using Data.Repository;

namespace Services
{
    public class WineService : IWineService
    {
        private readonly IWineRepository _wineRepository;
        public WineService(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        public List<Wine> GetAllWines()
        {
            return _wineRepository.GetAll();
        }

        public void AddWine(WineForCreation wineForCreation)
        {
            Wine newWine = new Wine()
            {
                Name = wineForCreation.Name,
                Variety = wineForCreation.Variety,
                Year = wineForCreation.Year,
                Region = wineForCreation.Region,
                Stock = wineForCreation.Stock,
            };
            _wineRepository.AddWine(newWine);
        }

        public void AddStock(int amount, string wineName)
        {
            _wineRepository.AddStock(amount, wineName);
        }

        public void RemoveStock(int amount, string wineName)
        {
            _wineRepository.RemoveStock(amount, wineName);
        }
    }
}
