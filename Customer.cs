using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    /// <summary>
    /// Realized interfase IEntity in class Customer
    /// </summary>
    public class Customer : IEntity
    {
        /// <summary>
        ///Atribut Id in class Customer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Atribut Name in class Customer
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///Atribut  Price  in class Customer
        /// </summary> 
        public int Price { get; set; }

        /// <summary>
        /// Atribut Address  in class Customer
        /// </summary>
        public string Address { get; set; }
    }
}
