using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjectWebApi.Models;

namespace NinjectWebApi.Infrastructure
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int id);
    }

    public class UserRepository : IUserRepository
    {


        private static readonly List<User> _users = new List<User>();
         static UserRepository()
        {
            _users.Add(new User { Id = 1, Name = "Madison Nelson", Email = "madison.nelson89@example.com"} );
            _users.Add(new User { Id = 1, Name = "Corey Henderson", Email = "corey.henderson40@example.com" }); 
        }
        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}