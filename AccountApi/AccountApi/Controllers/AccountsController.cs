using AccountApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AccountsController : Controller
    {
        private readonly AccountsDbContext _context;
        public AccountsController(AccountsDbContext context)
        {
            _context = context;
        }
        [ActionName("getusers")]
        [HttpGet()]
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
        [ActionName("signup")]
        [HttpPost()]
        public String SignUp([FromBody]User user)
        {
            if (user.UserName == null || user.Password == null)
            {
                return "Username and Password must not be empty";
            }
            else
            {
                var q = from r in _context.Users
                        where r.UserName == user.UserName
                        select r;
                if (q.Count() > 0)
                {
                    return "user already exists";
                }
            }
            _context.Users.Add(user);
            _context.SaveChanges();

            return "Created: " + user.ToString();
        }
        [ActionName("signin")]
        [HttpPost()]
        public bool SignIn([FromBody]User user)
        {

            var q = from r in _context.Users
                    where r.UserName == user.UserName
                    && r.Password == user.Password
                    select r;
            if (q.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
