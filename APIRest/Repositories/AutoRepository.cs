using APIRest.Data;
using APIRest.Exceptions;
using APIRest.Interfaces;
using APIRest.Models;
using APIRest.Requests;

namespace APIRest.Repositories
{
    public class AutoRepository : IAutoRepository
    {
        private readonly ContextDB contextDB;

        public AutoRepository(ContextDB contextDB)
        {
            this.contextDB = contextDB;
        }
        public async Task<Auto?> GetAutoAsync(int id)
        {
            var entity = contextDB.Autos.FirstOrDefault(p => p.Id == id);
            if (entity == null)
                throw new NotFoundException();
            return entity;
        }

        public async Task<List<Auto>?> GetAutosAsync()
        {
            return contextDB.Autos.ToList();
        }

        public async Task<Auto?> AddAutoAsync(Auto auto)
        {
            var entity = contextDB.Autos.Add(auto).Entity;
            contextDB.SaveChanges();
            return entity;
        }

        public async Task<Auto?> UpdateAutoAsync(AutoRequest request, int id)
        {
            var auto = contextDB.Autos.FirstOrDefault(p => p.Id == id);
            if (auto == null)
                throw new NotFoundException();
            auto.Marca = request.Marca;
            auto.Modelo = request.Modelo;
            auto.Año = request.Año;
            var entity = contextDB.Autos.Update(auto).Entity;
            contextDB.SaveChanges();
            return auto;
        }

        public async Task<Auto?> DeleteAutoAsync(int id)
        {
            var a = contextDB.Autos.FirstOrDefault(p => p.Id == id);
            if (a == null)
                throw new NotFoundException();

            contextDB.Autos.Remove(a);
            contextDB.SaveChanges();
            return a;
        }
    }
}
