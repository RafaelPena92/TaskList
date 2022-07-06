using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    /// <summary>
    /// Aqui apenas são feitos os contratos, só isso
    /// ** tive que usar Tasks pois Task ja é uma palavra utilizada
    /// </summary>
    public interface ITaskService
    {
        Task Save( int id, string title, string description, string author);
        Task <List<Note>> GetAll();
    } 
}
