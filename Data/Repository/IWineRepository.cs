using Data.Entities;

namespace Data.Repository
{
    public interface IWineRepository
    {
        List<Wine> GetAll();
        void AddWine(Wine newWine);

        void AddStock(int amount, string wineName);

        void RemoveStock(int amount, string wineName);
    }
}
