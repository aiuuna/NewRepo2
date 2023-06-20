using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TodoItemDTO
    {
        public int id;
        public string? name;
        public bool isComplete;

        public TodoItemDTO(int Id, string? Name,bool IsComplete )
        {
            id = Id;
            name=Name;
        }
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
    class TodoItem
    {

        public int id1;
        public string? name1;
        public bool isComplete1;
        public TodoItem(int Id, string? Name, bool IsComplete,  string? Secret)
        {
            id1=Id;
            name1 = Name;
        }
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }

}
