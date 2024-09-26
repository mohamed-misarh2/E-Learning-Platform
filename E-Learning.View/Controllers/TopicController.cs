using E_Learning.Application.IService;
using E_Learning.Application.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Learning.View.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _topicService;

        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
        }
        // GET: api/<TopicController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
          var topics=  ( await _topicService.GetAllTopicsAsync());
            return  Ok(topics.Entities.Count);
        }

        // GET api/<TopicController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TopicController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TopicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TopicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
