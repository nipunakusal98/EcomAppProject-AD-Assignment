using EcomApp.Data;
using EcomAppProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomAppProject.Data.Services
{
    public class ModelService : IModelService
    {
        private readonly AppDbContext _context;

        public ModelService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Model model)
        {
            _context.Models.Add(model);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Model>> GetAll()
        {
            var result = await _context.Models.ToListAsync();
            return result;
        }

        public Model GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Model Update(int ID, Model newmodel)
        {
            throw new NotImplementedException();
        }
    }
}
