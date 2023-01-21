using Microsoft.AspNetCore.Mvc;
using TodoListApp.BLL.Interfaces;
using TodoListApp.DAL.Models;
using TodoListApp.Models.Requests;

namespace TodoListApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly ITodoListService _todoListService;

        public TodoListController(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoList>>> GetAllTodoLists()
        {
            var result = await _todoListService.GetAllTodoLists();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTodoListRequest request)
        {
            var result = await _todoListService.Create(request.Title);
            return Ok(result);
        }
    }
}
