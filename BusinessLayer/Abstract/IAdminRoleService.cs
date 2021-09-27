using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IAdminRoleService
    {
        void Add(AdminRole adminRole);
        void Delete(AdminRole adminRole);
        void Update(AdminRole adminRole);
        List<AdminRole> GetList();
        AdminRole GetById(int id);
    }
}
