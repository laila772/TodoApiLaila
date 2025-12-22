using TodoApiLaila.Models;

namespace TodoApiLaila.Services
{
    public class TodoService
    {
        private List<TodoItem> todos = new List<TodoItem>();
        private int nextId = 1;

        public List<TodoItem> GetAll()
        {
            return todos;
        }

        public TodoItem Add(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception("Title cannot be empty");
            }

            var todo = new TodoItem
            {
                Id = nextId,
                Title = title,
                IsCompleted = false
            };

            todos.Add(todo);
            nextId++;

            return todo;
        }

        public void Delete(int id)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                todos.Remove(todo);
            }
        }

        // ✅ NEW: Update todo
        public TodoItem Update(int id, string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new Exception("Title cannot be empty");
            }

            var todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
            {
                return null;
            }

            todo.Title = title;
            return todo;
        }
    }
}
