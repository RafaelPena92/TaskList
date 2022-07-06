using Domain.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    /// <summary>
    /// Aqui são implementados os contratos da interface
    /// </summary>
    public class TaskServices : ITaskService
    {
        private List<Note> _tasks;
        private IUserSession _userSession;

  
        public TaskServices(IUserSession userSession)
        {
            _tasks = new List<Note>();
            _userSession = userSession;
        }

        public async Task Save(int id,string title, string description, string author)
        {
            _userSession.IncreaseCounter();
            _tasks.Add(new Note() { Id=id,Title = title, Description = description, Author = author });
        }


        public async Task<List<Note>> GetAll()
        {
            return _tasks;
        }
       
    }
}
