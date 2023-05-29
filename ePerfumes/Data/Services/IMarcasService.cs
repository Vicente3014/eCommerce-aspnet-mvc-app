using ePerfumes.Models;

namespace ePerfumes.Data.Services
{
    public interface IMarcasService
    {
        Task<IEnumerable<Marca>> GetAllAsync();
        Task<Marca> GetByIDAsync(int id);
        Task AddAsync(Marca marca);
        Task<Marca> UpdateAsync(int id, Marca newMarca);
        void Delete(int id);

    }
}
