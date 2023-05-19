using EcomAppProject.Models;
namespace EcomAppProject.Data.Services
{
    public interface IModelService
    {
        Task<IEnumerable<Model>> GetAll();
        Model GetByID(int id);
        void Add(Model model);
        Model Update(int ID, Model newmodel);
        void Delete(int id);
    }
}
