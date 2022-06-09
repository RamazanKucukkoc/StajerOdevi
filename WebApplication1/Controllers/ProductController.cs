using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ViewResult Index()
        {
            return View();
        }
        //[HttpGet("getall")]
        //   [Authorize(Roles ="Product.List")]
        public ViewResult GetAll()
        {
            // Thread.Sleep(1000);
            //IActionResult metodu Ok(200) BadRequest ise 400 hatası verdiyor.
            var result = _productService.GetAll();
            return View(result);
            //if (result.Success)
            //{
            //    return Ok(result);
            //}
            //return BadRequest(result);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Add(Product product)
        {
            _productService.Add(product);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Delete(Product product)
        {
            _productService.Delete(product);
            return RedirectToAction("GetAll");
        }
    }
}
