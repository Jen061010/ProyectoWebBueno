<<<<<<< da1fc080aaaa26e6e03fec7a4e24676f26165563
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;
using System.Data.Entity;

namespace Infraestructura
{
    public interface ICustomerDbContext : IDisposable
    {
        int SaveChanges();
        public IDbSet<ICustomer> Customers{ get; set; }
=======
﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public interface ICustomerDbContext:IUnitOfWork
    {
        DbSet<Customer> Customers { get; set; }
>>>>>>> Commit: Implementación vídeo Pedro(inyección de dependencias)
    }
}
