using WebApp.BeautySoft.Data;
using WebApp.BeautySoft.Models;

namespace WebApp.BeautySoft.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }
        public List<UserModel> SearchAll()
        {
            return _context.Users.ToList();
        }

        public UserModel SearchByID(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public UserModel Add(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public UserModel? Update(UserModel user)
        {
            UserModel userDB = SearchByID(user.Id);

            if (userDB == null) throw new Exception("Houve um erro na atualização do usuário");

            userDB.Name = user.Name;
            userDB.Email = user.Email;
            userDB.Login = user.Login;
            userDB.DateRegistration = user.DateRegistration;

            _context.Users.Update(userDB);
            _context.SaveChanges();

            return userDB;

        }

        public bool Erase(int id)
        {
            UserModel userDB = SearchByID(id);

            if (userDB == null) throw new Exception("Hover um erro na deleção do usuário!");

            _context.Users.Remove(userDB);
            _context.SaveChanges();

            return true;

        }
    }
}
