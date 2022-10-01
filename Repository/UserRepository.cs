using BlogDoDautin.Context;
using BlogDoDautin.Models;
using BlogDoDautin.Repository.Interfaces;

namespace BlogDoDautin.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _databaseContext;
        public UserRepository(DatabaseContext context)
        {
            _databaseContext = context;
        }
        public UserModel createUser(UserModel model)
        {
            try
            {
                _databaseContext.User.Add(model);
                return model;
            }
            catch (Exception err)
            {
                throw new Exception(err.ToString());
            }
        }
    }
}
