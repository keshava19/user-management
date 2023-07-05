using System;
using System.Collections.Generic;

namespace user_management_backend.Models;

public interface IUserRepository
{
    IEnumerable<UserModel> GetAll();
    
    UserModel Add(UserModel user);
}
