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
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal ExperienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            ExperienceDal = experienceDal;
        }

        public void TAdd(Experience t)
        {
            ExperienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            ExperienceDal.Delete(t);
        }

        public Experience TGetByID(int id)
        {
            return ExperienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return ExperienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            ExperienceDal.Update(t);
        }
    }
}
