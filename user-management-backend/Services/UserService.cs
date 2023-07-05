using System;
using System.Collections.Generic;
using user_management_backend.Models;

namespace user_management_backend.Services;

public class UserService : Interfaces.Services.IUserService
{
    private readonly Repositories.UserRepository _userContext;

    public UserService(Repositories.UserRepository userContext)
    {
        _userContext = userContext;
    }

    public User AddUser(User user)
    {
        return _userContext.Add(user);
    }

    public IEnumerable<User> GetUsers()
    {
        return _userContext.ToList();
    }
}