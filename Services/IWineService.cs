using Common.DTO;
using Data.Entities;

namespace Services
{
    public interface IWineService
    {
        List<Wine> GetAllWines();
        void AddWine(WineForCreation wineForCreation);

        void AddStock(int amount, string wineName);

        void RemoveStock(int amount, string wineName);
    }
}
