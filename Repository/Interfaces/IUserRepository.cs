using BlogDoDautin.Models;

namespace BlogDoDautin.Repository.Interfaces
{
    public interface IUserRepository
    {
        UserModel createUser(UserModel model);
    }
}
