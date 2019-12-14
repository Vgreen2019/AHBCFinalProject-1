using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IUserIdService
    {
        int UserId { get; set; }
        void getUserId(string email);
    }
}
