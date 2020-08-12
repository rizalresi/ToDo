
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Complete { get; set; }
    }
}
