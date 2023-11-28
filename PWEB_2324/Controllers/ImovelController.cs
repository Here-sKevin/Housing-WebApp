using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using PWEB_2324.Repositories.Interface;
using ReflectionIT.Mvc.Paging;

namespace PWEB_2324.Controllers
{
    public class ImovelController : Controller
    {
        private readonly IImoveisRepository _imoveisRepository;

        public ImovelController(IImoveisRepository imoveisRepository)
        {
            _imoveisRepository = imoveisRepository;
        }

        /*public IActionResult List()
        {
            var imoveis = _imoveisRepository.imoveis;
            return View(imoveis);
        }*/
        public async Task<IActionResult> List(string filter, int page=1, string sort = "Location")
        {
            var result = _imoveisRepository.imoveis.AsQueryable();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                result = result.Where(p => p.Location.Contains(filter));
            }
            var model = await PagingList.CreateAsync(result, 5, page, sort, "Location");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };

            return View(model);
        }


    }
}
