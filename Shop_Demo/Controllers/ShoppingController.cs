using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_Demo.ListViewModels;
using Shop_Demo.Models;

namespace Shop_Demo.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingController(IPieRepository pieRepository, ShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var ShoppingCartViewModel = new shoppingCartViewModel
            {
                shoppingCart = _shoppingCart,
                shopingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(ShoppingCartViewModel);
        }
        [HttpGet]
        public RedirectToActionResult AddToShopingCart(int PieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == PieId);
            if(selectedPie != null)
            {
                _shoppingCart.AddToCart(selectedPie,1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int PieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == PieId);

            if (selectedPie != null)
            {
                _shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }


    }
}