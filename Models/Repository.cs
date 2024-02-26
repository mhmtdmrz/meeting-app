namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();

        static Repository()
        {
            _users.Add(new UserInfo(){Id = 1, Name = "Ali", Email = "Ali@Ali.com", Phone = "1111111", WillAttend = true});
            _users.Add(new UserInfo(){Id = 2, Name = "Ahmet", Email = "Ahmet@Ahmet.com", Phone = "222222", WillAttend = false});
            _users.Add(new UserInfo(){Id = 3, Name = "Can", Email = "Can@Can.com", Phone = "333333", WillAttend = true});

        }

        public static List<UserInfo> Users {
            get => _users;
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetUserById(int id)
        {
            return _users.FirstOrDefault(x=>x.Id == id);
        }
    }
}