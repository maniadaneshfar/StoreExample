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
        public IActionResult Index()
        {
            return View();
        }
    }
}
