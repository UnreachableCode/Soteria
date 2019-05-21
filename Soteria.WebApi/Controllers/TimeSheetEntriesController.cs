using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Soteria.Core.Enums;
using Soteria.Models;
using Soteria.Models.Repositories;

namespace Soteria.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TimeSheetEntriesController : Controller
    {
        private readonly ITimeSheetRepository _timeSheetRepository;

        public TimeSheetEntriesController(ITimeSheetRepository timeSheetRepository)
        {
            _timeSheetRepository = timeSheetRepository;
        }

        [HttpGet]
        public IActionResult List()
        {
            return Ok(_timeSheetRepository.All);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Create([FromBody] TimeSheetEntry item)
        {
            try
            {
                if (item == null || !ModelState.IsValid)
                {
                    return BadRequest(ErrorCode.TimeSheetEntryPropsRequired.ToString());
                }
                bool itemExists = _timeSheetRepository.DoesItemExist(item.ID);
                if (itemExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, ErrorCode.TimeSheetEntryIDInUse.ToString());
                }
                _timeSheetRepository.Insert(item);
            }
            catch (Exception)
            {
                return BadRequest(ErrorCode.CouldNotCreateItem.ToString());
            }
            return Ok(item);
        }

        // PUT api/values/
        [HttpPut]
        public IActionResult Edit([FromBody] TimeSheetEntry item)
        {
            try
            {
                if (item == null || !ModelState.IsValid)
                {
                    return BadRequest(ErrorCode.TimeSheetEntryPropsRequired.ToString());
                }
                var existingItem = _timeSheetRepository.Find(item.ID);
                if (existingItem == null)
                {
                    return NotFound(ErrorCode.RecordNotFound.ToString());
                }
                _timeSheetRepository.Update(item);
            }
            catch (Exception)
            {
                return BadRequest(ErrorCode.CouldNotUpdateItem.ToString());
            }
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var item = _timeSheetRepository.Find(id);
                if (item == null)
                {
                    return NotFound(ErrorCode.RecordNotFound.ToString());
                }
                _timeSheetRepository.Delete(id);
            }
            catch (Exception)
            {
                return BadRequest(ErrorCode.CouldNotDeleteItem.ToString());
            }
            return NoContent();
        }
    }
}
