using RestaurantApp.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class resOrderService : IResOrder
    {
        private readonly resturentContext _context;
        public resOrderService(resturentContext context)
        {
            _context = context;
        }
    }
}
