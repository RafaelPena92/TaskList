using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Note
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public DateTime Date { get; private set; }

        public Note(int id,string title, string description, string author,DateTime date)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Date = date;
        }

        public Note()
        {
        }
    }
}
