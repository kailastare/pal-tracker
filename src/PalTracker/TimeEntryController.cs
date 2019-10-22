using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/time-entries")]
    public class TimeEntryController : ControllerBase
    {
        private ITimeEntryRepository @object;

        public TimeEntryController(ITimeEntryRepository @object)
        {
            this.@object = @object;
        }

        [HttpGet("{id}", Name="GetTimeEntry")]
        public IActionResult Read(int id)
        {
            return @object.Contains(id)? (IActionResult)Ok(@object.Find(id)):NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody]TimeEntry toCreate)
        {
            var abc = @object.Create(toCreate);
            return CreatedAtRoute("GetTimeEntry",new {Id = abc.Id},abc);
        }

        [HttpGet]
        public  IActionResult  List()
        {
            return Ok(@object.List());
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] TimeEntry theUpdate)
        {
            if (@object.Contains(id))
            {
                return Ok(@object.Update(id, theUpdate));
            }
            return NotFound();           
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (@object.Contains(id))
            {
                @object.Delete(id);
                return NoContent();
            }
            return  NotFound();
        }
    }
}