using System;
using System.Collections.Generic;
using user_management_backend.Models;

namespace user_management_backend.Interfaces.Repositories;

public interface IUserRepository
{
    IEnumerable<User> ToList();
    User Add(User User);
}
