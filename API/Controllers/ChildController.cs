﻿using _2_services.Interfaces;
using _2_services.Models;
using _3_repositories.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        readonly IChildService childService;
        public ChildController(IChildService _childService)
        {
            childService = _childService;
        }
        // GET: api/<ChildController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ChildController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ChildController>
        [HttpPost]
        public void Post([FromBody] ChildModel value)
        {
            childService.Add(value);

        }

        // PUT api/<ChildController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
