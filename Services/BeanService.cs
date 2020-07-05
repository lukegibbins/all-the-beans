using all_the_beans.Data;
using all_the_beans.Interfaces;
using all_the_beans.Models;
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

        public List<Bean> GetAllBeans()
        {
            return _context.Beans.ToList();
        }

        public Bean GetBeanOfDay()
        {
            var bean = GetAllBeans().FirstOrDefault();
            return bean;
        }

        public List<Bean> UpdateAllBeans()
        {
            throw new NotImplementedException();
        }
    }
}
