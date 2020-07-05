using all_the_beans.Interfaces;
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

        public JsonResult UpdateAllBeans()
        {
            var beans = _beanService.UpdateAllBeans();
            return Json(beans);
        }
    }
}
