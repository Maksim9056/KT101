using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    /// <summary>
    /// Реализован интерфейс IRepository<T> в классе ProductRepository
    /// </summary>
    public class ProductRepository : IRepository<Product>
    {
          List<Product> IRepository<Product>.Values { get ; set ; }

        private List<Product> products;



        public ProductRepository()
        {
            products = new List<Product>();
        }


        /// <summary>
        ///Make up   Method Add
        /// </summary>
        /// <param name="item"></param>
        public void Add(Product item)
        {
            products.Add(item);
        }


        /// <summary>
        /// Make up  Method  Delete
        /// </summary>
        /// <param name="item"></param>
        public void Delete(Product item)
        {
            products.Remove(item);
        }


        /// <summary>
        /// Make up  Method  Find Searh Elemant i
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product FindById(int id)
        {
            return products.Find(p => p.Id == id);
        }



        public IEnumerable<Product> GetAll()
        {
            return products;
        }
    }
}
