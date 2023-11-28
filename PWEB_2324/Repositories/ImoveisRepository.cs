using PWEB_2324.Data;
using PWEB_2324.Models;
using PWEB_2324.Repositories.Interface;

namespace PWEB_2324.Repositories
{
    public class ImoveisRepository : IImoveisRepository
    {
        private readonly ApplicationDbContext _context;

        public ImoveisRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ImovelModel> imoveis => _context.ImoveilModel;
    }
}
