using Domain.Models;

namespace Service.Interfaces
{
    public interface IUserRepository
    {
        public User GetUserById(int id);
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
