using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class program
    {
        
        static void Main(string[] args)
        {
            List<TodoItem> lst = new List<TodoItem>();
            {
                lst.Add(new TodoItem(1, "test1", false, "secret1"));
                lst.Add(new TodoItem(2, "test2", false, "secret2"));
                lst.Add(new TodoItem(3, "test3", false, "secret3"));
                lst.Add(new TodoItem(4, "test4", false, "secret4"));
            }
            List<TodoItemDTO> lst1 = new List<TodoItemDTO>();{
                lst1.Add(new TodoItemDTO(1, "test1", false));
                lst1.Add(new TodoItemDTO(2, "test2", false));
                lst1.Add(new TodoItemDTO(3, "test3", false));
                lst1.Add(new TodoItemDTO(4, "test4", false));
            }
            var any = from p in lst
                      from c in lst1
                      where c.id == p.id1
                      where c.name == p.name1
                        select new
                        {
                            id = c.id,
                            name = c.name
                        };
            foreach (var c in any)
            {
                Console.WriteLine($" {c.id,35}\t {c.name,10}");
            }
        }

    }
}