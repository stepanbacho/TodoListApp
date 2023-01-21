using TodoListApp.DAL.Models;

namespace TodoListApp.Models.Responses
{
    public class CreateTodoListResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public IEnumerable<TodoListItem> Items { get; set; }
    }
}
