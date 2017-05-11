using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _9_code_from_me.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using TodoWebApi.Model.Entities;

namespace TodoWebApi.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        private ITodoRepository _todoRepository;
        public TodosController(ITodoRepository todoRepository){
            _todoRepository = todoRepository;
        }
     //   List<TodoItem> _todoList = new List<TodoItem>();
         // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var todos = _todoRepository.GetAll();
          //  _todoList.Add(new TodoItem{TodoItemID = 1, Task = "First Task", IsComplete = false});
            return new OkObjectResult(todos);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //return NotFound();
            return new OkObjectResult(_todoRepository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _todoRepository.Delete(id);
            return NoContent();
            
        }
    }
}
