using ePerfumes.Models;
using Microsoft.EntityFrameworkCore;

namespace ePerfumes.Data.Services
{
    public class MarcaService : IMarcasService
    {
        private readonly AppDBContext _dbContext;
        public MarcaService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Marca marca)
        {
           await _dbContext.Marcas.AddAsync(marca);
           await _dbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Marca>> GetAllAsync()
        {
            var result = await _dbContext.Marcas.ToListAsync();
            return result;
        }

        public async Task<Marca> GetByIDAsync(int id)
        {
            var result = await _dbContext.Marcas.FirstOrDefaultAsync(n=>n.Marca_ID == id);
            return result;
        }

        public Marca Update(int id, Marca Newmarca)
        {
            throw new NotImplementedException();
        }
    }
}
