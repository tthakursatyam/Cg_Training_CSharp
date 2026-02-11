using System;
using System.Linq;
using System.Text.Json;
namespace MiniSocialMedia
{
    class Program
    {
        private static Repository<User> _users = new();
        public static User? _currentUser = null;
        public static readonly string _dataFile = "social-data.json";

        public static void Main()
        {
            Console.WriteLine("\t\t\t\t\tMiniSocial - Console Edition\t\t\n\t\t\t\t\t     === MiniSocial ===\t\t");

            LoadData();
            while (true)
            {
                try
                {
                    if (_currentUser is null)
                    {
                        ShowLoginMenu();
                    }
                    else
                    {
                        ShowMainMenu();
                    }
                }
                catch (SocialException ex)
                {
                    var originalColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Error: " + ex.Message);
                    if (ex.InnerException is not null)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }

                    Console.ForegroundColor = originalColor;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error!!");
                    LogException(ex);

                }
            }
        }
        public static void ShowLoginMenu()
        {
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("0. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Register();
                    break;
                case 2:
                    Login();
                    break;
                case 0:
                    SaveData();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static void LogException(Exception ex)
        {
            File.AppendAllText("error.log", DateTime.Now + " | " + ex.GetType() + " | " + ex.Message + Environment.NewLine);
        }
        static void Register()
        {
            string? username = "";
            string? email = "";
            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();

            if (username == "" || email == "")
            {
                Console.WriteLine("Username or Email cannot be empty");
                return;
            }
            User? user = _users.Find(u => string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
            if (user is not null)
            {
                Console.WriteLine("User already Added");
                return;
            }
            user = new User(username, email);
            _users.Add(user);
        }
        static void Login()
        {
            string? username = "";
            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            User? user = _users.Find(u => string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));
            if (user is null)
            {
                Console.WriteLine("User not found!");
                return;
            }
            _currentUser = user;
            _currentUser.OnNewPost += PostNotification;
            Console.WriteLine($"Logged in as {_currentUser.Username}");
        }
        static void PostNotification(Post post)
        {
            ConsoleColorWrite(ConsoleColor.Cyan,
                $"New post by {post.Author}: " +
                $"{(post.Content.Length > 40 ? post.Content[..40] + "..." : post.Content)}");
        }
        private static void ShowMainMenu()
        {
            Console.WriteLine($"Logged in as {_currentUser.Username}");
            Console.WriteLine("1. Post message");
            Console.WriteLine("2. View my posts");
            Console.WriteLine("3. View timeline");
            Console.WriteLine("4. Follow user");
            Console.WriteLine("5. List users");
            Console.WriteLine("6. Logout");
            Console.WriteLine("0. Exit and save");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PostMessage();
                    break;
                case 2:
                    ShowPosts(_currentUser!.GetPosts());
                    break;
                case 3:
                    ShowTimeline();
                    break;
                case 4:
                    FollowUser();
                    break;
                case 5:
                    ListUsers();
                    break;
                case 6:
                    _currentUser.OnNewPost -= PostNotification;
                    _currentUser = null;
                    break;
                case 0:
                    SaveData();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        static void PostMessage()
        {
            if (_currentUser is null)
            {
                Console.WriteLine("No user logged in");
                return;
            }
            Console.Write("Enter your post content(Max 280 char,Empty Post content are not allowed): ");
            string promt = Console.ReadLine();
            promt = promt.Trim();
            if (string.IsNullOrEmpty(promt))
            {
                Console.WriteLine("Post cancelled");
                return;
            }
            _currentUser.AddPost(promt);
        }
        static void ShowTimeline()
        {
            if (_currentUser is null)
            {
                Console.WriteLine("Timeline is accessible only to authenticated users.");
                return;
            }
            List<Post> timeline = new List<Post>();
            timeline.AddRange(_currentUser.GetPosts());
            foreach (var name in _currentUser.GetFollowingNames())
            {
                User user = _users.Find(u =>
                    string.Equals(u.Username, name, StringComparison.OrdinalIgnoreCase));
                if (user != null)
                    timeline.AddRange(user.GetPosts());
            }
            var ordered = timeline
                .OrderByDescending(p => p.CreatedAt).Take(20);
            Console.WriteLine("=== Your Timeline ===");
            ShowPosts(ordered);

        }
        private static void ShowPosts(IEnumerable<Post> posts)
        {
            int count = 1;
            foreach (var i in posts)
            {
                Console.WriteLine(i);
                Console.WriteLine(i.CreatedAt.FormatTimeAgo());
                Console.WriteLine(new string('-', 50));
                count++;
                if (count == 20) break;
            }
            if (count == 1) Console.WriteLine("No posts yet.");

        }
        static void FollowUser()
        {
            if (_currentUser is null)
            {
                Console.WriteLine("Only authenticated users can follow others.");
                return;
            }
            Console.Write("username they want to follow:");
            string target = Console.ReadLine();
            target = target.Trim();
            if (string.IsNullOrEmpty(target)) 
            {
                Console.WriteLine("Cancelled.");
                return;
            }
            if (_currentUser.Username == target) 
            {
                Console.WriteLine("You cannot follow yourself.");
                return;
            }

            User user = _users.Find(u =>
            string.Equals(u.Username, target, StringComparison.OrdinalIgnoreCase));
            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }
            _currentUser.Follow(target);
            Console.WriteLine($"Now following @{target}");
        }
        static void ListUsers()
        {
            Console.WriteLine("\t\t\t=======Registered users=======");
            foreach (var user in _users.GetAll().OrderBy(u => u.Username))
            {
                Console.WriteLine(user.Username + "    " + user.Email);
            }
        }
        static void SaveData()
        {
            try
            {
                var json = JsonSerializer.Serialize(_users.GetAll());
                File.WriteAllText(_dataFile, json);
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }

        static void LoadData()
        {
            try
            {
                if (!File.Exists(_dataFile)) return;
                var json = File.ReadAllText(_dataFile);
                var users = JsonSerializer.Deserialize<List<User>>(json);
                if (users != null)
                    foreach (var u in users)
                    {
                        _users.Add(u);
                        Console.WriteLine(u.GetDisplayName);
                    }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
        }
        static void LogError(Exception ex)
        {
            try
            {
                File.AppendAllText("error.log",
                    $"{DateTime.Now}\n{ex.Message}\n{ex.StackTrace}\n\n");
            }
            catch { }
        }
        static void ConsoleColorWrite(ConsoleColor color, string message)
        {
            var old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = old;
        }

    }
}
