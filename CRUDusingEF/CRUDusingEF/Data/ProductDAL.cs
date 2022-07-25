using CRUDusingEF.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUDusingEF.Data
{
    public class ProductDAL
    {
        ApplicationDbContext db;
        public ProductDAL(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            //return db.Products.ToList();

            var result = from p in db.Products
                         select p;
            return (IEnumerable<Product>)result;
        }
        public Product GetProductById(int id)
        {
            Product p = db.Products.Where(x => x.Id == id).FirstOrDefault();
            return p;
        }
        public int AddProduct(Product prod)
        {
            //Add prod object in the products collection
            db.Products.Add(prod);
            //reflect the changes in DB
            int result=db.SaveChanges();
            return result;
        }
        public int UpdateProduct(Product prod)
        {
            int result = 0;
            // p object hold old data
            Product p = db.Products.Where(x => x.Id == prod.Id).FirstOrDefault();
            if (p != null)
            {
                p.Name = prod.Name;
                p.Price = prod.Price;
                result = db.SaveChanges();
            }
            return result;
        }
        public int DeleteProduct(int id)
        {
            int result = 0;
            Product p = db.Products.Where(x => x.Id == Id).FirstOrDefault();
            if (p != null)
            {
                db.Products.Remove(p);
                result = db.SaveChanges();
            }
            return result;
        }

    }
}
