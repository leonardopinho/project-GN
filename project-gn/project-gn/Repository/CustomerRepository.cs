namespace project_gn.Repository
{
    using project_gn.Interfaces;
    using project_gn.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;

    public class CustomerRepository : ICustomer
    {
        private ProjectGn context;

        public CustomerRepository()
        {
            this.context = new ProjectGn();
        }

        public List<Customer> GetAll()
        {
            return context.Customer.ToList();
        }

        public Customer GetById(int id)
        {
            return context.Customer.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Insert(Customer entity)
        {
            context.Customer.Add(entity);
            context.SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Customer item = context.Customer.Where(c => c.Id == id).FirstOrDefault();
            context.Customer.Remove(item);
            context.SaveChanges();
        }

    }
}