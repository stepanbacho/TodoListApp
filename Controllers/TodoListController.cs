using Microsoft.AspNetCore.Mvc;
using TodoListApp.BLL.Interfaces;
using TodoListApp.Models.Requests;

namespace TodoListApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly ITodoListService _service;

        public TodoListController(ITodoListService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTodoListRequest request)
        {
            var result = await _service.Create(request.Title);

            return Ok(result);
        }
    }
}
