using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJJ.Models
{
    public class ProductModel : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }


        public class Product
        {
            [Required]
            [MaxLength(20)]
            public string Name { get; set; }

            [Required]
            public double Price { get; set; }

            [Required]
            [MaxLength(50)]
            public string Description { get; set; }
        }
    }
}