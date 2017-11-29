﻿using AspNetCoreDemos.Models;
using AspNetCoreDemos.Models.Scheduler;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AspNetCoreDemos.Controllers
{
    public partial class SchedulerController
    {
        public IActionResult WebApi()
        {
            return View();
        }
    }

    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private readonly SchedulerTaskService service;

        public TaskController()
        {
            service = new SchedulerTaskService(new SampleEntitiesDataContext());
        }

        protected override void Dispose(bool disposing)
        {
            service.Dispose();

            base.Dispose(disposing);
        }

        // GET api/task
        [HttpGet]
        public DataSourceResult Get([DataSourceRequest]DataSourceRequest request)
        {
            return service.GetAll().ToDataSourceResult(request);
        }

        // POST api/task
        [HttpPost]
        public IActionResult Post(TaskViewModel task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors).Select(error => error.ErrorMessage));
            }

            service.Insert(task, null);

            return new ObjectResult(new DataSourceResult { Data = new[] { task }, Total = 1 });
        }

        // PUT api/task/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, TaskViewModel task)
        {
            if (ModelState.IsValid && id == task.TaskID)
            {
                try
                {
                    service.Update(task, null);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return new NotFoundResult();
                }

                return new StatusCodeResult(200);
            }
            else
            {
                return BadRequest(ModelState.Values.SelectMany(v => v.Errors).Select(error => error.ErrorMessage));
            }
        }

        // DELETE api/task/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(new TaskViewModel { TaskID = id }, null);
            }
            catch (DbUpdateConcurrencyException)
            {
                return new NotFoundResult();
            }

            return new StatusCodeResult(200);
        }
    }
}
