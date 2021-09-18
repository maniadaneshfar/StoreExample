using Microsoft.AspNetCore.Mvc;
using StoreExample.Application.Services.Queries.GetUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGetUserService _getUserService;
        public UsersController(IGetUserService getUserService )
        {
            _getUserService = getUserService;
        }
        [Area("Admin")]
        public IActionResult Index(string searchkey, int page)
        {
            return View(_getUserService.Execute(new RequestGetUserDto 
            {
                SearchKey= searchkey,
                Page=page
            }));
        }
    }
}
