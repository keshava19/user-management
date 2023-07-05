using System;
using System.Collections.Generic;

namespace user_management_backend.Interfaces.Repositories;

public interface IUserRepository
{
    IEnumerable<Models.UserModel> GetAll();
    
    Models.UserModel Add(Models.UserModel user);
}
