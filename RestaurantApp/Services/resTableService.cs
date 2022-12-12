using RestaurantApp.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class resTableService : IResTable
    {
        private readonly resturentContext _context;
        public resTableService(resturentContext context)
        {
            _context = context;
        }
    }
}
