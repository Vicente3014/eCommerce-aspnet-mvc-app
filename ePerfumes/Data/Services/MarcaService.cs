using ePerfumes.Models;

namespace ePerfumes.Data.Services
{
    public class MarcaService : IMarcasService
    {
        private readonly AppDBContext _dbContext;
        public MarcaService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Marca marca)
        {
           _dbContext.Marcas.Add(marca);
           _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Marca> GetAll()
        {
            var result = _dbContext.Marcas.ToList();
            return result;
        }

        public Marca GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Marca Update(int id, Marca Newmarca)
        {
            throw new NotImplementedException();
        }
    }
}
