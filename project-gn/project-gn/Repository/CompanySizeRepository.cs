namespace project_gn.Repository
{
    using project_gn.Interfaces;
    using project_gn.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;

    public class CompanySizeRepository : ICompanySize
    {
        private ProjectGn context;

        public CompanySizeRepository()
        {
            this.context = new ProjectGn();
        }

        public List<CompanySize> GetAll()
        {
            return context.CompanySize.ToList();
        }

        public CompanySize GetById(int id)
        {
            return context.CompanySize.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Insert(CompanySize entity)
        {
            context.CompanySize.Add(entity);
            context.SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(CompanySize entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            CompanySize item = context.CompanySize.Where(c => c.Id == id).FirstOrDefault();
            context.CompanySize.Remove(item);
            context.SaveChanges();
        }

    }
}