using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.API.Models;
using MongoDB.API.Services;

namespace MongoDB.API.Controllers
{
    public class BaseController<T> : ControllerBase where T : class, IEntity, new()
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseController(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        [HttpGet]
        public virtual ActionResult<List<T>> Get()
        {
            var result = _baseRepository.GetList();

            return Ok(result);
        }


        [HttpGet("{id}")]
        public virtual ActionResult<T> Get(string id)
        {
            var result = _baseRepository.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public virtual IActionResult Post(T document)
        {
            _baseRepository.Create(document);

            return CreatedAtRoute(Get(document.Id), document);
        }

        [HttpPut("{id:length(24)}")]
        public virtual IActionResult Put(string id, T document)
        {
            var result = _baseRepository.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            _baseRepository.Update(id, document);

            return NoContent();
        }


        [HttpDelete("{id:length(24)}")]
        public virtual IActionResult Delete(string id, T document)
        {
            var result = _baseRepository.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            _baseRepository.Delete(id, document);

            return NoContent();
        }
    }
}