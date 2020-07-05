using all_the_beans.Interfaces;
using all_the_beans.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace all_the_beans.Services
{
    public class BeanService : IBeanService
    {
        public List<Bean> GetAllBeans()
        {
            throw new NotImplementedException();
        }

        public Bean GetBeanOfDay()
        {
            var bean = new Bean();
            bean.Colour = "red";

            return bean;
        }

        public List<Bean> UpdateAllBeans()
        {
            throw new NotImplementedException();
        }
    }
}
