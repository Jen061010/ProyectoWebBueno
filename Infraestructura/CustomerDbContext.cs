<<<<<<< da1fc080aaaa26e6e03fec7a4e24676f26165563
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominios;

namespace Infraestructura
{
    public class CustomerDbContext : DbContext, ICustomerDbContext
    {
       
        public DbSet<ICustomer> Customers { get; set; }

 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
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
    public class CustomerDbContext: DbContext,ICustomerDbContext
    {
        public DbSet<Customer> Customers { get; set; }


>>>>>>> Commit: Implementación vídeo Pedro(inyección de dependencias)
    }
}
