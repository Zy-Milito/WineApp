using Common.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserForCreation body)
        {
            UserForCreation userForCreation = new()
            {
                Username = body.Username,
                Password = body.Password
            };
            _userService.AddUser(userForCreation);
            return Created();
        }
    }
}
