using DapperData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperData.Repositary
{
    public interface IUserRepositary
    {
        Task<bool> AddUser(Users users);
        Task<bool> UpdateUser(Users users);
        Task<bool> DeleteUser(int id);
        Task<Users> GetUserById(int id);
        Task<IEnumerable<Users>> GetAllUsers();


    }
}
