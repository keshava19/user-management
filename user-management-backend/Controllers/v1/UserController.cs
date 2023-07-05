using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace user_management_backend.Controllers.v1;

[ApiController]
public class UsersController : ControllerBase
{

    private readonly ILogger<UsersController> _logger;

    static readonly Interfaces.Repositories.IUserRepository repository = new Repositories.UserRepository();

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("api/v1/users")]
    public IEnumerable<Models.UserModel> GetAllUsers()
    {
        return repository.GetAll();
    }

    [HttpPost]
    [Route("api/v1/user")]
    [Consumes("application/json")]
    public Models.UserModel PostUser(Models.UserModel item)
    {
        return repository.Add(item);
    }
    

}

