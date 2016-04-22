<<<<<<< da1fc080aaaa26e6e03fec7a4e24676f26165563
﻿using Dominios;
=======
﻿using Dominio;
>>>>>>> Commit: Implementación vídeo Pedro(inyección de dependencias)
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
<<<<<<< da1fc080aaaa26e6e03fec7a4e24676f26165563
    public class CustomerService : ICustomerService
=======
    public class CustomerService:ServiceBase,ICustomerService
>>>>>>> Commit: Implementación vídeo Pedro(inyección de dependencias)
    {
        readonly ICustomerDbContext _context;

        public CustomerService(ICustomerDbContext ctx)
<<<<<<< da1fc080aaaa26e6e03fec7a4e24676f26165563
=======
            :base(ctx)
>>>>>>> Commit: Implementación vídeo Pedro(inyección de dependencias)
        {
            if (null == ctx)
            {
                throw new ArgumentNullException("CustomerContext");
            }
            _context = ctx;
        }

        public Customer Add(Customer c)
        {
<<<<<<< da1fc080aaaa26e6e03fec7a4e24676f26165563
            _context.Customers.Add(c);
            SaveChanges();
            return c;
        }

        public int Delete(ICustomer c)
        {
            _context.Customers.Remove(c);
            return SaveChanges();
        }

        public ICustomer Get(int id)
        {
            return _context.Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public int Update()
        {
            return SaveChanges();
        }

=======
            var customerNew=_context.Customers.Add(c);
            SaveChanges();
            return customerNew;
        }

        public void Delete(Customer c)
        {
            _context.Customers.Remove(c);
             SaveChanges();
        }

        public Customer Get(int id)
        {
            return GetCustomer(id);
        }


        public void Update(int id, Customer customer)
        {
            var customerOld = GetCustomer(id);
            CheckNullCustomer(customerOld);
            UpdateCustomer(customer,customerOld);
            SaveChanges();
        }

        public IEnumerable<Customer> GetAll(string name) 
        {
            return _context.Customers.Where(c=>c.Nombre.Contains(name));

        }
        private static void UpdateCustomer(Customer customer, Customer customerOld) 
        {
            customerOld.Nombre = customer.Nombre;
            customerOld.Phone = customer.Phone;
        }
        private static void CheckNullCustomer(Customer customer) 
        {
            if (null == customer)
            {
                throw new NullReferenceException("El cliente no existe");
            }
        }
        private Customer GetCustomer(int Id)
        {
            return _context.Customers.Where(c => c.Id == Id).FirstOrDefault();
        }
>>>>>>> Commit: Implementación vídeo Pedro(inyección de dependencias)
        private int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
