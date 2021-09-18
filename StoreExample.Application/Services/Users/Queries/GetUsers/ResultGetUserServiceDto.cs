using System.Collections.Generic;

namespace StoreExample.Application.Services.Queries.GetUsers
{
    public class ResultGetUserServiceDto
    {
        public List<GetUserServiceDto> Users { get; set; }
        public int Rows  { get; set; }
    }

}
