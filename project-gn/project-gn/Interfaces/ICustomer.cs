using project_gn.Models;
using System.Collections.Generic;

namespace project_gn.Interfaces
{
    interface ICustomer
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        void Insert(Customer entity);
        void Update(Customer entity);
        void Delete(int id);
        void SaveChanges();
    }
}
