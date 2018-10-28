using project_gn.Models;
using System.Collections.Generic;

namespace project_gn.Interfaces
{
    public interface ICompanySize
    {
        List<CompanySize> GetAll();
        CompanySize GetById(int id);
        void Insert(CompanySize entity);
        void Update(CompanySize entity);
        void Delete(int id);
        void SaveChanges();
    }
}
