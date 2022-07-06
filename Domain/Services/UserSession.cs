using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UserSession : IUserSession
    {

        public int _count;

        public UserSession()
        {
            _count = 0;
        }

        public async Task<int> GetCouter()
        {
            return _count;
        }

        public async Task IncreaseCounter()
        {
            _count++;
        }
    } 
}
