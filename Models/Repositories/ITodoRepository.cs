using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Model.Entities;

namespace _9_code_from_me.Models.Repositories
{
    public interface ITodoRepository
    {
        // CRUD Functionality

        void Create(TodoItem item);
        TodoItem Get(int id);
        IEnumerable<TodoItem> GetAll();
        void Update(TodoItem item);
        void Delete(int id);
    }
}
