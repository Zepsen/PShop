using Microsoft.AspNetCore.Mvc;
using PShop.Models.DBEFContext;
using PShop.Models.ViewModels;
using PShop.Repositories;
using System.Linq;

namespace PShop.Controllers
{
    public class EFController : Controller
    {
        private EFRepo _repo;

        public EFController(PShopContext db)
        {
            _repo = new EFRepo(db);
        }
                
        public ViewResult Index()
        {
            var models = _repo.All()
                .Select(PlayerViewModel.Map)
                .ToList();

            return View(models);
        }
    }
}
