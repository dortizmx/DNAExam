using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNA.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace DNA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RSSNewsController : ControllerBase
    {
        RSSNewsService rSSNewServices;
        public RSSNewsController()
        {
            rSSNewServices = new RSSNewsService();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var retvalue = rSSNewServices.getAll();
            return Ok(retvalue);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var retvalue = rSSNewServices.getById(id);
            return Ok(retvalue);
        }

        [HttpGet("sorting/{item}")]
        public ActionResult GetSorting(string item)
        {
            var retvalue = rSSNewServices.getSorting(item);
            return Ok(retvalue);
        }
    }
}
