using RestaurantApp.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Services
{
    public class orderItemsService : IOrderItems
    {
        private readonly resturentContext _context;
        public orderItemsService(resturentContext context)
        {
            _context = context;
        }
    }
}
