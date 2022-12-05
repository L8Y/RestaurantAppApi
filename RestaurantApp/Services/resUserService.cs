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

    }
}
