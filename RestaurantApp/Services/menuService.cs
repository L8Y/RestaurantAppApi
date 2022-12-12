using RestaurantApp.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class menuService : IMenu
    {
        private readonly resturentContext _context;
        public menuService(resturentContext context)
        {
            _context = context;
        }
    }
}
