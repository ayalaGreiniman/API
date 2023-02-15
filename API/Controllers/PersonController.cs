using _2_services.Interfaces;
using _2_services.Models;
using _2_services.Services;
using AutoMapper;
//using DocumentFormat.OpenXml.Office2013.Word;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<PersonModel> Get()
        {
           return _personService.GetAll();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public void Get(int id)
        {
            _personService.GetById(id);

        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonModel value)
        {
            _personService.Add(value);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PersonModel value)
        {
            _personService.Update(value);
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
