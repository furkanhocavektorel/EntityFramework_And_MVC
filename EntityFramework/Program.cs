using EntityFramework.context;
using EntityFramework.entity;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            NorthwindContext furkan = new NorthwindContext();


            //DbSet<Category> ct = furkan.Categories;
            //List<Category> list = furkan.Categories.ToList();

        

            //List<Product> products = furkan.Products
            //   .Where(axa=> axa.UnitsInStock>110).ToList();

            //Product p=furkan.Products.FirstOrDefault(x => x.UnitsInStock > 100);

            //try{
            //    Product p2 = furkan.Products.SingleOrDefault(x => x.UnitsInStock > 100);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);    
            //}

            //List<Product> list2= furkan.Products.OrderBy(x=>x.ProductName).ToList();
            //List<Product> list3 = furkan.Products.OrderByDescending(x => x.ProductName).ToList();

            //bool varMi = furkan.Products.Any(x => x.UnitsInStock > 100);

            //bool varMi2= furkan.Products.All(x=> x.UnitsInStock > 100);
            //int kayitSayisi= furkan.Products.Count(x=> x.UnitPrice>20);

        //    List<Product> products= 
        // furkan.Products.Include("CategoryId").ToList();

        //    Product p = furkan.Products
        //        .FirstOrDefault(x => x.UnitPrice > 50);
        //    Console.WriteLine(p.ProductName);
        //    Console.WriteLine(p.CategoryId.CategoryName);

        //    Category c = furkan.Categories
        //.SingleOrDefault(x => x.CategoryID == p.ProductID);
        //    Console.WriteLine(c.CategoryName);


            List<Product> products = 
                furkan.Products.Where(x=>x.UnitPrice>15).ToList();

            furkan.Products.ToList().Where(x => x.UnitPrice > 15);


        }
    }
}