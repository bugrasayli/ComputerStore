using Computer.Application.Repository;
using Computer.Core.DTO.RamDTO.Request;
using Computer.Core.DTO.RamDTO.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Computer.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RamController : ControllerBase
    {
        private readonly IRam _repo;
        public RamController(IRam repo)
        {
            _repo = repo;
        }
        // GET: api/<RamController>
        [HttpGet]
        public IEnumerable<GetRamResponse> Get()
        {
            return _repo.Get();
        }

        // GET api/<RamController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RamController>
        [HttpPost]
        public void Post([FromBody] PostRamRequest ram)
        {
            _repo.Create(ram);
        }

        // PUT api/<RamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
