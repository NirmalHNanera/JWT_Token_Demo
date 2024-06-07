using JWT_Token_Demo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Token_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]

        public string GetData()
        {
            return "User Authenticated with JWT";
        }

        [HttpGet]
        [Route("Details")]

        public string Details()
        {
            return "User Authenticated with JWT";
        }

        [Authorize]
        [HttpGet]
        

        public string AddUser(Users user)
        {
            return "User Added with Name " + user.Username;
        }
    }
}
