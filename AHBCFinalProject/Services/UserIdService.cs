using AHBCFinalProject.DAL;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public class UserIdService : IUserIdService
    {
        private readonly IUserIDStore _userIDStore;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserIdService(IUserIDStore userIdStore, IHttpContextAccessor httpContextAccessor)
        {
            _userIDStore = userIdStore;
            _httpContextAccessor = httpContextAccessor;
        }

        public int UserId { get; set; }

        public void getUserId(string email)
        {
            UserId = _userIDStore.getUserId(email);

        }
    }
}
