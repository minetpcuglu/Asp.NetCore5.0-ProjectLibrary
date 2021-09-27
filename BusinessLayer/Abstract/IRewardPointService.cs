using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRewardPointService
    {
        void Add(RewardPoint rewardPoint);
        void Delete(RewardPoint rewardPoint);
        void Update(RewardPoint rewardPoint);
        List<RewardPoint> GetList();
        RewardPoint GetById(int id);
    }
}
