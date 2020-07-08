using all_the_beans.Models;
using all_the_beans.ViewModels;
using System.Collections.Generic;

namespace all_the_beans.Interfaces
{
    public interface IBeanService
    {
        Bean GetBeanOfDay();
        List<Bean> GetAllBeans();
        List<Bean> UpdateAllBeans(List<BeanVM> beans);
        bool AddBean(BeanVM bean);
    }
}
