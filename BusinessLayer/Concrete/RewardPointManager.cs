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
    public class RewardPointManager : IRewardPointService
    {
        IRewardPointDal _rewardPointDal;

        public RewardPointManager(IRewardPointDal rewardPointDal)
        {
            _rewardPointDal = rewardPointDal;
        }

        public void Add(RewardPoint rewardPoint)
        {
            _rewardPointDal.Insert(rewardPoint);
        }

        public void Delete(RewardPoint rewardPoint)
        {
            _rewardPointDal.Delete(rewardPoint);
        }

        public RewardPoint GetById(int id)
        {
            return _rewardPointDal.GetById(id);
        }

        public List<RewardPoint> GetList()
        {
          return  _rewardPointDal.GetListAll();
        }

        public void Update(RewardPoint rewardPoint)
        {
            _rewardPointDal.Update(rewardPoint);
        }
    }
}
