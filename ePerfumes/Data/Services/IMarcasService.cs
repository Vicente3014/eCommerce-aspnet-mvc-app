using ePerfumes.Models;

namespace ePerfumes.Data.Services
{
    public interface IMarcasService
    {
        IEnumerable<Marca> GetAll();
        Marca GetByID(int id);
        void Add(Marca marca);
        Marca Update(int id, Marca Newmarca);
        void Delete(int id);
    }
}
