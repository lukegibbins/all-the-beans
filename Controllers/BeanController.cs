using all_the_beans.Interfaces;
using all_the_beans.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace all_the_beans.Controllers
{
    public class BeanController : Controller
    {
        private readonly IBeanService _beanService;
        private readonly IHostingEnvironment _appEnvironment;

        public BeanController(IBeanService beanService, IHostingEnvironment appEnvironment)
        {
            _beanService = beanService;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

       //[Authorize(Roles = "Admin")]
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

            if (beans.Any(x => x == null)) { return BadRequest(); }

            _beanService.UpdateAllBeans(beans);

            return Ok();
        }


        [HttpPost]
        public IActionResult AddBean([FromBody] BeanVM bean)
        {
            if (bean == null) { return BadRequest(); }

            _beanService.AddBean(bean);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddImage(IFormFile file)
        {
            if (file == null) { return BadRequest(); }

            var upload = Path.Combine(_appEnvironment.WebRootPath, "bean_images");

            var filePath = Path.Combine(upload, file.FileName);

            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            catch
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
