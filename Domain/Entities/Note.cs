using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get;  set; }
        public string Description { get; set; }
        public string Author { get;  set; }

        public Note(int id,string title, string description, string author)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
        }

        public Note()
        {
        }
    }
}
