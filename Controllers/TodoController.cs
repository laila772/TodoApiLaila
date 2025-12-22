using Microsoft.AspNetCore.Mvc;
using TodoApiLaila.Services;

namespace TodoApiLaila.Controllers
{
    [ApiController]
    [Route("api/todo")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService service;

        public TodoController(TodoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok(service.GetAll());
        }

        [HttpPost]
        public IActionResult AddTodo([FromBody] string title)
        {
            return Ok(service.Add(title));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTodo(int id)
        {
            service.Delete(id);
            return NoContent();
        }

        // ✅ NEW: Update todo
        [HttpPut("{id}")]
        public IActionResult UpdateTodo(int id, [FromBody] string title)
        {
            var updatedTodo = service.Update(id, title);

            if (updatedTodo == null)
            {
                return NotFound();
            }

            return Ok(updatedTodo);
        }
    }
}
