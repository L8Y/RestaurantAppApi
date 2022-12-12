using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Interface;
using RestaurantApp.Models;

namespace RestaurantApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResUserController : ControllerBase
    {
        private readonly IResUser _resUserService;
        public ResUserController(IResUser resUserService)
        {
            _resUserService = resUserService;
        }

        [HttpGet]
        public IEnumerable<ResUser> isResturantExist(string email, string password)
        {
             var isExist = _resUserService.isUserExist(email, password);
             return isExist;
        }

        [HttpGet("{email}")]
        public bool isEmailUniq(string email)
        {
            var isEmailNotUniq = _resUserService.isEmailUniq(email);
            return isEmailNotUniq;
        }
    }
}
