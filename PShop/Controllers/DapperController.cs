using Microsoft.AspNetCore.Mvc;
using PShop.Infrastructure.Interfaces.Repository;
using PShop.Models.DBEntities;
using PShop.Models.ViewModels;
using System.Linq;

namespace PShop.Controllers
{
    public class DapperController : Controller
    {
        IRepository<Players> _repo;

        public DapperController(IRepository<Players> repo)
        {
            _repo = repo;
        }

        public ViewResult Index()
        {
            var model = _repo.All()
                .Select(PlayerViewModel.Map)
                .ToList(); 

            return View(model);
        }
    }
}
