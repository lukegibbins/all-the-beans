using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using all_the_beans.Interfaces;
using all_the_beans.Models;
using Microsoft.AspNetCore.Mvc;

namespace all_the_beans.Controllers
{
    public class BeanController : Controller
    {
        private readonly IBeanService _beanService;

        public BeanController(IBeanService beanService)
        {
            _beanService = beanService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string GetBeanOfDay()
        {
            var bean = _beanService.GetBeanOfDay();
            return bean.Colour;
        }
    }
}
