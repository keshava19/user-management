using System;
using System.Collections.Generic;
using user_management_backend.Models;

namespace user_management_backend.Repositories;
public class UserRepository: Interfaces.Repositories.IUserRepository
{
    private List<User> users = new List<User>();
    private int _nextId = 1;

    public UserRepository()
    {
        Add(new User { firstName= "John", lastName="Doe", email="johndoe@gmail.com"});
        Add(new User { firstName= "Mia", lastName="Wong", email="miawong@gmail.com"});
        Add(new User { firstName= "Jiang", lastName="Fei", email="jiangfei@gmail.com"});
    }

    public IEnumerable<User> ToList()
    {
        return users;
    }

    public User Add(User user)
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