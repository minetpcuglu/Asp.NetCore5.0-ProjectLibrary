using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminRoleManager : IAdminRoleService
    {
        IAdminRoleDal _adminRoleDal;

        public AdminRoleManager(IAdminRoleDal adminRoleDal)
        {
            _adminRoleDal = adminRoleDal;
        }

        public void Add(AdminRole adminRole)
        {
            _adminRoleDal.Insert(adminRole);
        }

        public void Delete(AdminRole adminRole)
        {
            _adminRoleDal.Delete(adminRole);
        }

        public AdminRole GetById(int id)
        {
           return _adminRoleDal.GetById(id);
        }

        public List<AdminRole> GetList()
        {
            return _adminRoleDal.GetAll();
        }

        public void Update(AdminRole adminRole)
        {

            _adminRoleDal.Update(adminRole);
        }
    }
}
