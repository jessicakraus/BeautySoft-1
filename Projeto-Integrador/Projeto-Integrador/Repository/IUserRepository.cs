using WebApp.BeautySoft.Models;

namespace WebApp.BeautySoft.Repository
{
    public interface IUserRepository
    {
        List<UserModel> SearchAll();
        UserModel SearchByID(int id);
        UserModel Add(UserModel user);
        UserModel? Update(UserModel user);
        bool Erase(int  id);
    }
}
