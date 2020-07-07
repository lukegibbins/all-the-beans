﻿using all_the_beans.Interfaces;
using all_the_beans.Models;
using all_the_beans.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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


        [HttpPost]
        public IActionResult AddBean([FromBody] BeanVM bean)
        {
            if (bean == null) { return BadRequest(); }

            var x = bean;

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddImage(IFormFile file)
        {
            if (file == null) { return BadRequest(); }

            var upload = Path.Combine(_appEnvironment.WebRootPath, "bean_images");

            var filePath = Path.Combine(upload, file.FileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

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
