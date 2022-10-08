using berkayAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace berkayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return userRepository.GetAll();
        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return userRepository.GetById(id);
        }
        [HttpPost]
        public bool Post([FromBody]User user)
        {
           
            return userRepository.Add(user);
            
        }
        [HttpPut]
        public bool Put([FromBody] User user)
        {
            return userRepository.Update(user);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
           return userRepository.Delete(id);
        }
    }
}
