using RestaurantApp.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class resUserService : IResUser
    {
        private readonly resturentContext _context;
        public resUserService(resturentContext context)
        {
            _context = context;
        }

        public IEnumerable<ResUser> isUserExist(string email, string password)
        {
            var  isUserExist = _context.ResUser.Where(u => u.Email == email && u.Password == password);
            return isUserExist;
        }

        public bool isEmailUniq(string email)
        {
            var isEamilUniq = _context.ResUser.Any(u => u.Email == email);
            return isEamilUniq;
        }
    }
}
