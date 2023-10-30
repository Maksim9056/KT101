using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    /// <summary>
    /// Реализован интерфейс IRepository<T>
    /// </summary>
    public interface IRepository<T>
    {

        /// <summary>
        /// Realized Method Add  element
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);


        /// <summary>
        /// Realized Method Delete in interfase IRepository<T>
        /// </summary>
        /// <param name="item"></param>
        void Delete(T item);



        /// <summary>
        /// Realized Method 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T FindById(int id);
        IEnumerable<T> GetAll();



        List<T> Values { get; set; } 
    }
}
