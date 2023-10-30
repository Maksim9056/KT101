using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    /// <summary>
    /// Realized interfase IRepository<T> class in CustomerRepository
    /// </summary>
    public class CustomerRepository: IRepository<Customer>
    {


        /// <summary>
        /// Atribut List type class Customer this List<Customer>
        /// </summary>
        public List<Customer> Values { get; set; } = new List<Customer>();



        /// <summary>
        ///Counstuctor class  CustomerRepository make up  interfase IRepository<T>   this class CustomerRepository  interfase  IRepository<Customer>
        /// </summary>
        public CustomerRepository()
        {
            Values = new List<Customer>();
        }



        /// <summary>
        /// Method Add plus class customer 
        /// </summary>
        /// <param name="item"></param>
        public void Add(Customer item)
        {
            Values.Add(item);
        }


        /// <summary>
        ///  Method delete plus class customer
        /// </summary>
        /// <param name="item"></param>
        public void Delete(Customer item)
        {
            Values.Remove(item);
        }



        /// <summary>
        /// Method FindById return class Customer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer FindById(int id)
        {
            return Values.Find(c => c.Id == id);
        }


        /// <summary>
        /// Method GetAll return interface  IEnumerable<t>  this  IEnumerable class Customer " IEnumerable<IEnumerable> "
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetAll()
        {
            return Values;
        }
    }
}
