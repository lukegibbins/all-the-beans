﻿using all_the_beans.Models;
using System.Collections.Generic;

namespace all_the_beans.Interfaces
{
    public interface IBeanService
    {
        Bean GetBeanOfDay();
        List<Bean> GetAllBeans();
        List<Bean> UpdateAllBeans(List<Bean> beans);
        bool AddBean(Bean bean);
    }
}
