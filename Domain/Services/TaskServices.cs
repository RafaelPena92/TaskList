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

        public async Task Save(int id,string title, string description, string author, DateTime date)
        {



            if (string.IsNullOrEmpty(description))
            {
                throw new InvalidOperationException("The task does not have a description, please insert to continue");
            }

            _userSession.IncreaseCounter();
            _tasks.Add(new Note( id, title,  description, author, date) );
        }


        public async Task<List<Note>> GetAll()
        {
            return _tasks;
        }
       
    }
}
