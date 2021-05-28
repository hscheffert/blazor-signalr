using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorSignalR.Shared
{
    public class UsersResult
    {
        public IEnumerable<UserInfo> Results { get; set; }
    }

    public class UserInfo
    {
        public Name Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        [JsonIgnore]
        public string FullName => Name.First + " " + Name.Last;
    }

    public class Name
    {
        public string First { get; set; }
        public string Last { get; set; }
    }
}
