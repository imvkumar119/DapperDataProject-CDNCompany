using DapperData.Data;
using DapperData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperData.Repositary
{
    public class UserRepositary : IUserRepositary
    {
        private readonly IDataAccess _db;
        public UserRepositary(IDataAccess db)
        {
            _db = db;
        }

        /// <summary>
        /// this is used to add user in database
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public async Task<bool> AddUser(Users users)
        {
            try
            {
                string query = "Insert into dbo.Users(userName,mail,phoneNumber,skillSet,hobby) Values(@UserName,@Mail,@PhoneNumber,@SkillSet,@Hobby)";
                await _db.SaveData(query, new { UserName = users.userName, Mail = users.mail, PhoneNumber = users.phoneNumber, SkillSet = users.skillSet, Hobby = users.hobby });
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// This method is used to detele user from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                string query = "Delete from dbo.Users where id=@Id";
                await _db.SaveData(query, new {Id=id});
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// this method is used to get user list from database
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Users>> GetAllUsers()
        {
            string query = "select * from dbo.Users";
            var users = _db.GetData<Users, dynamic>(query, new { });
            return users;
        }
        /// <summary>
        /// this method is used to get single user from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Users> GetUserById(int id)
        {
            string query = "select * from dbo.Users where id = @Id";
            IEnumerable<Users> user = await _db.GetData<Users, dynamic>(query, new { Id = id });
            return user.FirstOrDefault();
        }
        /// <summary>
        /// this method is used to update the user data from database
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public async Task<bool> UpdateUser(Users users)
        {
            try
            {
                string query = "update dbo.Users set userName=@UserName,mail=@Mail,phoneNumber=@PhoneNumber,skillSet=@SkillSet,hobby=@Hobby where id=@Id";
                await _db.SaveData(query, users);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
