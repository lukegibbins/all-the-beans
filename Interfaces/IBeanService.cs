using all_the_beans.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace all_the_beans.Interfaces
{
    public interface IBeanService
    {
        Bean GetBeanOfDay();
        List<Bean> GetAllBeans();
        List<Bean> UpdateAllBeans(List<Bean> beans);
    }
}
