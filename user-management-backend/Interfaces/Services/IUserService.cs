using System;
using System.Collections.Generic;
using user_management_backend.Models;

namespace user_management_backend.Interfaces.Services;

public interface IUserService
{
    IEnumerable<User> GetUsers();
    User AddUser(User User);
}
