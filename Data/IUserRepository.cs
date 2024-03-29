﻿using TigerTix.Web.Data.Entities;

namespace TigerTix.Web.Data
{
    public interface IUserRepository
    {
        void DeleteUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUserById(int userID);
        void SaveUser(User user);
        void UpdateUser(User user);

        bool SaveAll();

        
    }
}