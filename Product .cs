using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    /// <summary>
    /// Реализован интерфейс IEntity в классе CustomerRepository 
    /// </summary>
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        string IEntity.Address { get ; set ; }
    }
}
