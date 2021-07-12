using Computer.Application.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComputerController : ControllerBase
    {
        private readonly IComputer _repo;
        public ComputerController(IComputer repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public string Get()
        {
            var A =_repo.Get();
            return "Hello";
        }
    }
}
