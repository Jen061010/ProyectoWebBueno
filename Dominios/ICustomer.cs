using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
   public interface ICustomer
    {
         string Nombre { get; set; }
         string Phone { get; set; }
         int Id { get; set; }
    }
}
