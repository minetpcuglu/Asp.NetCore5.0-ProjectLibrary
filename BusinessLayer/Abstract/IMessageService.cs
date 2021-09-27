using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IMessageService 
    {
        void Add(Message message);
        void Delete(Message message);
        void Update(Message message);
        List<Message> GetList();
        Message GetById(int id);
    }
}
