using Dominio;
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
    }
}
