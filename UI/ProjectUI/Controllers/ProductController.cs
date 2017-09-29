using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBLL.ProductServices;
using ProjectDAL.ContextFiles;
using Microsoft.EntityFrameworkCore;
using ProjectUI.Models;
using ProjectEntity.Models;

namespace ProjectUI.Controllers
{
    public class ProductController : Controller
    {
        private AppProjectDbContext _context;
        private IProductService _productService;

        public ProductController(AppProjectDbContext context,
                                 IProductService productService)
        {
            this._context = context;
            this._productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            IEnumerable<ProductViewModel> model = _productService.GetProducts().Select(p => new ProductViewModel
            {
                Id = p.Id,
                ProductName = p.ProductName,
                Price = p.Price
            });
            return View(model);
        }
    }
}