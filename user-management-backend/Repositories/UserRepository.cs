using System;
using System.Collections.Generic;

namespace user_management_backend.Repositories;
public class UserRepository: Interfaces.Repositories.IUserRepository
{
    private List<Models.UserModel> users = new List<Models.UserModel>();
    private int _nextId = 1;

    public UserRepository()
    {
        Add(new Models.UserModel { firstName= "John", lastName="Doe", email="johndoe@gmail.com"});
        Add(new Models.UserModel { firstName= "Mia", lastName="Wong", email="miawong@gmail.com"});
        Add(new Models.UserModel { firstName= "Jiang", lastName="Fei", email="jiangfei@gmail.com"});
    }

    public IEnumerable<Models.UserModel> GetAll()
    {
        return users;
    }

    public Models.UserModel Add(Models.UserModel user)
    {
        if (user == null)
        {
            throw new ArgumentNullException("user");
        }
        user.Id = _nextId++;
        users.Add(user);
        return user;
    }
}