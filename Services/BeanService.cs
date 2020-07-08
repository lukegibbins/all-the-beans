using all_the_beans.Data;
using all_the_beans.Interfaces;
using all_the_beans.Models;
using all_the_beans.ViewModels;
using System;
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

        public bool AddBean(BeanVM bean)
        {
            int prevCount = GetAllBeans().Count();

            var mappedBean = ExtractBeansToModel(new List<BeanVM>() { bean }).SingleOrDefault(); 

            _context.Beans.Add(mappedBean);

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

        public List<Bean> UpdateAllBeans(List<BeanVM> beans)
        {
            var mappedBeans = ExtractBeansToModel(beans);

            var beansFromDb_Ids = GetAllBeans().Select(b => b.Id);

            var differenceInIds = beansFromDb_Ids.Except(mappedBeans.Select(b => b.Id));

            if (differenceInIds.Any())
            {
                foreach (var beanId in differenceInIds)
                {
                    var beanToRemove = _context.Beans.SingleOrDefault(b => b.Id == beanId);
                    _context.Beans.Remove(beanToRemove);
                }
                _context.SaveChanges();
            }

            var beansToUpdate = _context.Beans.ToList();

            foreach(var bean in beansToUpdate)
            {
                var beanFromVM = mappedBeans.SingleOrDefault(b => b.Id == bean.Id);
                bean.Date = beanFromVM.Date;
            }
            _context.SaveChanges();

            return _context.Beans.ToList();
        }


        // Would've used automapper here providing 
        // I had the time to go through the docs; hack hack hack
        private List<Bean> ExtractBeansToModel(List<BeanVM> beans)
        {
            var beanModelList = new List<Bean>();
            foreach (var bean in beans)
            {
                var guid = bean.id == null ? Guid.Empty : bean.id;
                beanModelList.Add(new Bean()
                {
                    Id = guid.GetValueOrDefault(),
                    Aroma = bean.aroma,
                    Colour = bean.colour,
                    Cost = bean.cost,
                    Date = bean.date,
                    Image = bean.image,
                    Name = bean.name
                });
            }
            return beanModelList;
        }
    }
}
