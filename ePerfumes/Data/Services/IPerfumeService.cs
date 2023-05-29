using ePerfumes.Models;

namespace ePerfumes.Data.Services
{
    public interface IPerfumeService
    {
        Task<IEnumerable<Perfume>> GetAllAsync();
        Task<Perfume> GetByIDAsync(int id);
        Task AddAsync(Perfume perfume);
        Task<Perfume> UpdateAsync(int id, Perfume Newperfume);
        void Delete(int id);
    }
}
