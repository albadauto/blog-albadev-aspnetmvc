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
                _databaseContext.SaveChanges();
                return model;
            }
            catch (Exception err)
            {
                throw new Exception(err.ToString());
            }
        }

        public UserModel verifyLogin(UserModel model)
        {
            try
            {
                var result = _databaseContext.User.FirstOrDefault(o => o.Email == model.Email && o.Password == model.Password);
                return result;
            }catch(Exception error)
            {
                throw new Exception(error.ToString());
            }
        }
    }
}
