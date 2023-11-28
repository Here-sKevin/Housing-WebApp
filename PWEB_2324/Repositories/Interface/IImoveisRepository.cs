using PWEB_2324.Models;
namespace PWEB_2324.Repositories.Interface
{
    public interface IImoveisRepository
    {
        IEnumerable<ImovelModel> imoveis { get; }
    }
}
