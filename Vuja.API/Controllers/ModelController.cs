using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vuja.Aplikacija.Commands;
using Vuja.Aplikacija.DataTransfer;

namespace Vuja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly ICreateModelCommand _creatModel;

        public ModelController(ICreateModelCommand creatModel)
        {
            _creatModel = creatModel;
        }

        // GET: api/Model
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Model/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Model
        [HttpPost]
        public IActionResult Post([FromBody] CreateModelDto dto)
        {
            _creatModel.Execute(dto);
            return Ok();
        }

        // PUT: api/Model/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
