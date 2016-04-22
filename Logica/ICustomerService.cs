<<<<<<< da1fc080aaaa26e6e03fec7a4e24676f26165563
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


using Infraestructura;
using Dominios;
namespace Logica
{
    public interface ICustomerService
    {
        //public ICustomerDbContext Context { get; set; }


        ICustomer Add(ICustomer c);
        int Delete(ICustomer c);
        ICustomer Get(int id);
        int Update();

=======
﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface ICustomerService:IDisposable
    {
        Customer Add(Customer c);
        void Delete(Customer c);
        Customer Get(int id);
        void Update(int id,Customer customer);
        IEnumerable<Customer> GetAll(string name);
>>>>>>> Commit: Implementación vídeo Pedro(inyección de dependencias)
    }
}
