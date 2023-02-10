using APIRest.Models;
using APIRest.Requests;

namespace APIRest.Interfaces
{
    public interface IAutoRepository
    {
        Task<Auto?> GetAutoAsync(int id);
        Task<List<Auto>?> GetAutosAsync();
        Task<Auto?> AddAutoAsync(Auto auto);
        Task<Auto?> UpdateAutoAsync(AutoRequest request, int id);
        Task<Auto?> DeleteAutoAsync(int id);
    }
}
