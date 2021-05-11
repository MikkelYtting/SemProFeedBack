using CommentSection;
using Microsoft.AspNetCore.Mvc;
using SemProFeedBack.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SemProFeedBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        // GET: CommentController
        private CommentManager _CommentManager = new CommentManager();
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return _CommentManager.getAll();
        }

        // GET: CommentController/Details/5
        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            return _CommentManager.GetById(id);
        }

        [HttpPost]
        public Comment Post([FromBody] Comment value)
        {
            return _CommentManager.Add(value);
        }
        // PUT api/<CommentController>/5
        [HttpPut("{id}")]
        public Comment Put(int id, [FromBody] Comment value)
        {
            return _CommentManager.Update(id, value);
        }
        // DELETE api/<CommentController>/5
        [HttpDelete("{id}")]
        public Comment Delete(int id)
        {
            return _CommentManager.Delete(id);
        }

    }
}
