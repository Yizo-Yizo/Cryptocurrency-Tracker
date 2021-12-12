using CryptoTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTracker.Interfaces
{
    public interface IUserDataService
    {
        //Task AddUser(Users newUser);
        Task<bool> Register(string name, string surname, string email, string contactNumber, string password, string confirmPassword);
        Task UpdateUser(AppUser user, int id);
        Task DeleteUser(int userId);
        Task<IEnumerable<AppUser>> GetAllUsers();
    }
}
