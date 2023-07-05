using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using user_management_backend.Models;

namespace user_management_backend.Controllers.v1;

[ApiController]
public class UsersController : ControllerBase
{

    private readonly ILogger<UsersController> _logger;

    static readonly Interfaces.Services.IUserService service = new Services.UserService(new Repositories.UserRepository());

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("api/v1/users")]
    public IEnumerable<User> GetAllUsers()
    {
        return service.GetUsers();
    }

    [HttpPost]
    [Route("api/v1/user")]
    [Consumes("application/json")]
    public User PostUser(User user)
    {
        return service.AddUser(user);
    }
    

}

