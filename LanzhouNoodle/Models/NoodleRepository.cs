using System.Collections.Generic;
using System.Linq;

namespace LanzhouNoodle.Models
{
    public class NoodleRepository : INoodleRepository
    {
        private readonly AppDBContext _dbContext;

        public NoodleRepository(AppDBContext context)
        {
            _dbContext = context;
        }
        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _dbContext.Noodles;
        }

        public Noodle GetNoodleById(int id)
        {
            return _dbContext.Noodles.FirstOrDefault(x => x.Id == id);
        }
    }
}
