using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreExample.Application.Services.Queries.GetUsers
{
    public interface IGetUserService
    {
        ResultGetUserServiceDto Execute(RequestGetUserDto request);
    } 

}
