using ePerfumes.Models;

namespace ePerfumes.Data.Services
{
    public interface IMarcasService
    {
        Task<IEnumerable<Marca>> GetAllAsync();
        Task<Marca> GetByIDAsync(int id);
        Task AddAsync(Marca marca);
        Marca Update(int id, Marca Newmarca);
        void Delete(int id);
    }
}
