using APIRest.Interfaces;
using APIRest.Models;
using APIRest.Requests;
using AutoMapper;

namespace APIRest.Services
{
    public class AutoService : IAutoService
    {
        private readonly IAutoRepository autoRepository;
        private readonly IMapper mapper;

        public AutoService(IAutoRepository autoRepository, IMapper mapper)
        {
            this.autoRepository = autoRepository;
            this.mapper = mapper;
        }

        public async Task<Auto?> GetAutoAsync(int id)
        {
            return await autoRepository.GetAutoAsync(id);
        }

        public async Task<List<Auto>?> GetAutosAsync()
        {
            return await autoRepository.GetAutosAsync();
        }

        public async Task<Auto?> AddAutoAsync(AutoRequest request)
        {
            var auto = mapper.Map<Auto>(request);
            return await autoRepository.AddAutoAsync(auto);
        }

        public async Task<Auto?> UpdateAutoAsync(AutoRequest request, int id)
        {
            return await autoRepository.UpdateAutoAsync(request, id);
        }

        public async Task<Auto?> DeleteAutoAsync(int id)
        {
            return await autoRepository.DeleteAutoAsync(id);
        }
    }
}
