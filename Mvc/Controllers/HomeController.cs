using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc.Models.context;
using Mvc.Models.entity;
using Mvc.Models.vmodel;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(int? id)
        {

            Console.WriteLine(id);
        

            NorthwindContext northwind = new NorthwindContext();


            IndexVıew indexVıew = new IndexVıew();

            indexVıew.categories = northwind.Categories.ToList();

            if (id == null)
            {
                indexVıew.products = northwind.Products.ToList();
            }
            else
            {
                indexVıew.products = northwind.Products
                    .Include("CategoryId")
                    .Where(pr => pr.CategoryId.CategoryID  == id)
                    .ToList();
            }
            indexVıew.activeCategory = id;

            if (id == 3)
            {
                Console.WriteLine("merhaba");
            }
            else { Console.WriteLine("gitti"); }

            string sonuc = id == 3 ? "merhaba" : "gitti";


            return View(indexVıew);
        }


       
    }
}