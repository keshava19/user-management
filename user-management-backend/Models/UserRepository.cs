using System;
using System.Collections.Generic;

namespace user_management_backend.Models;
public class UserRepository: IUserRepository
{
    private List<UserModel> users = new List<UserModel>();
    private int _nextId = 1;

    public UserRepository()
    {
        Add(new UserModel { firstName= "John", lastName="Doe", email="johndoe@gmail.com"});
        Add(new UserModel { firstName= "Mia", lastName="Wong", email="miawong@gmail.com"});
        Add(new UserModel { firstName= "Jiang", lastName="Fei", email="jiangfei@gmail.com"});
    }

    public IEnumerable<UserModel> GetAll()
    {
        return users;
    }

    public UserModel Add(UserModel item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("item");
        }
        item.Id = _nextId++;
        users.Add(item);
        return item;
    }
}