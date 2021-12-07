using CryptoTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Interfaces
{
    public interface IUserDataService
    {
        Task AddUser(Users newUser);
        Task UpdateUser(Users user, int id);
        Task DeleteUser(int userId);
        Task<Users> GetAllUsers();
    }
}
