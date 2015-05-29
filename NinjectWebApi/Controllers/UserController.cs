using System.Collections.Generic;
using System.Web.Http;
using NinjectWebApi.Infrastructure;
using NinjectWebApi.Models;

namespace NinjectWebApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> Get()
        {
            return _userRepository.GetUsers();
        }

        public User Get(int id)
        {
            return _userRepository.GetUserById(id);
        }

      
    }
}
