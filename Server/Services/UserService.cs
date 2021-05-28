using BlazorSignalR.Shared;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorSignalR.Server.Services
{
    public class UserService
    {
        private readonly HttpClient _client;
        
        public UserService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<UserInfo>> GetUsersAsync()
        {
            // Call the external REST API
            var result = await _client.GetJsonAsync<UsersResult>("?seed=20");

            return result.Results;
        }
    }
}
