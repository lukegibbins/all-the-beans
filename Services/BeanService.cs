using all_the_beans.Data;
using all_the_beans.Interfaces;
using all_the_beans.Models;
using System.Collections.Generic;
using System.Linq;

namespace all_the_beans.Services
{
    public class BeanService : IBeanService
    {
        private readonly BeanContext _context;

        public BeanService(BeanContext context)
        {
            _context = context;
        }

        public bool AddBean(Bean bean)
        {
            int prevCount = GetAllBeans().Count();

            _context.Beans.Add(bean);

            _context.SaveChanges();

            return GetAllBeans().Count() > prevCount ? true : false;
        }

        public List<Bean> GetAllBeans()
        {
            return _context.Beans.ToList();
        }

        public Bean GetBeanOfDay()
        {
            var bean = GetAllBeans().FirstOrDefault();
            return bean;
        }

        public List<Bean> UpdateAllBeans(List<Bean> beans)
        {
            var beansFromDb = _context.Beans.Select(x => x.Id).ToList();
            var differenceInIds = beansFromDb.Except(beans.Select(x => x.Id).ToList()).ToList();

            if (differenceInIds.Any())
            {
                foreach(var beanId in beansFromDb)
                {
                    var bean = _context.Beans.ToList().Where(x => x.Id == beanId).SingleOrDefault();
                    _context.Beans.Remove(bean);
                }
                _context.SaveChanges();
            }

            var beansToUpdate = _context.Beans.ToList();
            foreach(var bean in beansToUpdate)
            {
                var beanInVM = beans.Where(x => x.Id == bean.Id).SingleOrDefault();
                bean.Date = beanInVM.Date;
            }
            _context.SaveChanges();

            return _context.Beans.ToList();
        }
    }
}
