using DanmarksRadio.Managers;
using DanmarksRadio.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DanmarksRadio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MusicRecordsController : ControllerBase
    {
        MusicRecordsManager manager = new MusicRecordsManager();

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        // GET: api/<MusicRecordsController>
        [HttpGet]
        public ActionResult<IEnumerable<MusicRecord>> Get()
        {
            IEnumerable<MusicRecord> records = manager.GetAll();

            if (!records.Any())
                return NoContent();

            return Ok(records);
        }

        // GET api/<MusicRecordsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MusicRecordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicRecordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicRecordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
