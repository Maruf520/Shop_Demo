using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_Demo.Models;
using Shop_Demo.ListViewModels;

namespace Shop_Demo.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
/*        public ViewResult List()
        {
            PieListViewModels pieListViewModels = new PieListViewModels();
            pieListViewModels.pies = _pieRepository.AllPies;
            pieListViewModels.CurrentCategory = "This the Current Category";

            return View(pieListViewModels);
        }*/

       public ViewResult List(string category)
        {
            IEnumerable<Pie> pies;
            string currentCategory;
            if(string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(c => c.PieId);
                currentCategory = "All pies";

            }
            else
            {
                pies = _pieRepository.AllPies.Where(c => c.Category.CategoryName == category).OrderBy(c => c.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;

            }
            var pieListViewModels = new PieListViewModels
            {
                pies = pies,
                CurrentCategory = currentCategory,
            };
            return View(pieListViewModels);
        }


        public IActionResult Details(int id)
        {
            var pie = _pieRepository.AllPies.FirstOrDefault(c => c.PieId == id);
                if (pie == null)
                    return NotFound();
            return View(pie);
        }
    }
}