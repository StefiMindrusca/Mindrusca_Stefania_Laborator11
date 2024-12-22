using System.Threading.Tasks;
using Mindrusca_Stefania_Laborator11.Models;

namespace Mindrusca_Stefania_Laborator11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
