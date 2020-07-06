using all_the_beans.Interfaces;
using all_the_beans.Models;
using all_the_beans.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        public IActionResult Admin()
        {
            return View();
        }

        public JsonResult GetBeanOfDay()
        {
            var bean = _beanService.GetBeanOfDay();
            return Json(bean);
        }

        public JsonResult GetAllBeans()
        {
            var beans = _beanService.GetAllBeans();
            return Json(beans);
        }

        [HttpPost]
        public IActionResult UpdateAllBeans([FromBody] List<BeanVM> beans)
        {
            if (beans == null) { return BadRequest(); }

            var domainModelBeans = ExtractBeansToModel(beans);

            _beanService.UpdateAllBeans(domainModelBeans);              

            return Ok();
        }

        // Would've used automapper here providing 
        // I had the time to go through the docs
        private List<Bean> ExtractBeansToModel(List<BeanVM> beans)
        {
            var beanModelList = new List<Bean>();
            foreach (var bean in beans)
            {
                beanModelList.Add(new Bean()
                {
                    Id = bean.id,
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
