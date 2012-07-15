﻿using System.Collections.Generic;
using System.Web.Http;
using MvcApplication1.Models;
using MvcApplication1.Repositories;

namespace MvcApplication1.Controllers
{
    public class TasksController : ApiController
    {
        public void Post(Task task)
        {
            TasksRepository.Add(task);
        }

        public IEnumerable<Task> Get()
        {
            return TasksRepository.GetAll();
        }
    }
}
