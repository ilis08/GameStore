using GameStore.Data.Interfaces;
using GameStore.Data.Models;
using GameStore.Data.Repository;
using GameStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllGames _gameRepository;
        private  ShopCart _shopCart;

        public ShopCartController(IAllGames gameRepository, ShopCart shopCart)
        {
            _shopCart = shopCart;
            _gameRepository = gameRepository;
        }
        public IActionResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart (int id)
        {
            var item = _gameRepository.Games.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
