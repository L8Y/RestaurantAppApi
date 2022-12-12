using RestaurantApp.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class resEmployeeService : IResEmployee
    {
        private readonly resturentContext _context;
        public resEmployeeService(resturentContext context)
        {
            _context = context;
        }

    }
}
