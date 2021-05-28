using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorSignalR.Shared;
using BlazorSignalR.Server.Services;

namespace BlazorSignalR.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        public async Task<IEnumerable<UserInfo>> GetUsersAsync()
        {
            return await _userService.GetUsersAsync();
        }
    }
}
