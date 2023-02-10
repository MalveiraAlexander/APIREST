using APIRest.Models;
using APIRest.Requests;

namespace APIRest.Interfaces
{
    public interface IAutoService
    {
        Task<Auto?> GetAutoAsync(int id);
        Task<List<Auto>?> GetAutosAsync();
        Task<Auto?> AddAutoAsync(AutoRequest request);
        Task<Auto?> UpdateAutoAsync(AutoRequest request, int id);
        Task<Auto?> DeleteAutoAsync(int id);
    }
}
