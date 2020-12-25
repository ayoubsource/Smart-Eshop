using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyEshop.Models.DAO;
using MyEshop.Models.Entities;

namespace MyEshop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _clientManager;
        public IEnumerable<Product> Products { get; set; }
        public ProductsController(IProductRepository clientManager)
        {
            _clientManager = clientManager;
        }
        
        public IActionResult ListProducts()
        {
            Products = _clientManager.GetAll();
            return View(Products);
        }
    }
}
