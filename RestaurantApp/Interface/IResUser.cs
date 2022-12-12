using RestaurantApp.Models;


namespace RestaurantApp.Interface
{
    public interface IResUser
    {
        public IEnumerable<ResUser> isUserExist(string email, string password);

        public bool isEmailUniq(string email);
    }
}
