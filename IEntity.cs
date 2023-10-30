using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    /// <summary>
    /// Реализован интерфейсIEntity
    /// </summary>
    internal interface IEntity
    {

        /// <summary>
        /// Id  
        /// </summary>
         int   Id { get; set; }
  
         public string Name {  get; set; }
         public int   Price { get; set; }
         public string Address { get; set; }    



    }
}
