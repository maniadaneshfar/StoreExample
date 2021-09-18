using StoreExample.Application.Interfaces.Context;
using StoreExample.Common;
using System.Collections.Generic;
using System.Linq;

namespace StoreExample.Application.Services.Queries.GetUsers
{
    public class GetUserService : IGetUserService
    {
        private readonly IDataBaseContext _context;
        public GetUserService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultGetUserServiceDto Execute(RequestGetUserDto request)
        {
            var users = _context.Users.AsQueryable();
            if (! string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
            }
            int rowsCount = 0;
            var userList= users.ToPaged(request.Page, 20, out rowsCount).Select(p => new GetUserServiceDto
            {
                Id = p.Id,
                FullName = p.FullName,
                Email = p.Email,
                Password = p.Password
            }).ToList();

            return new ResultGetUserServiceDto
            {
                Rows = rowsCount,
                Users = userList
            };
        }
    }

}
