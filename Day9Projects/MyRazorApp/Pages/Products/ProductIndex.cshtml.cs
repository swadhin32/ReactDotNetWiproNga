using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyRazorApp.Pages.service;
using MyRazorApp.Models;

namespace MyRazorApp.Pages.Products
{
    public class ProductIndex : PageModel
    {
        private readonly ILogger<ProductIndex> _logger;
        private readonly ProductService _productService;

        public ProductIndex(ILogger<ProductIndex> logger, ProductService productservice)
        {
            _logger = logger;
            this._productService = productservice;
        }

      

       

        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _productService.GetAll();
        }
    }
}