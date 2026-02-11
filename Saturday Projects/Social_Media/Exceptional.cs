using System;
using System.Text.RegularExpressions;
using System.Text;
namespace MiniSocialMedia
{
    class SocialException : Exception
    {
        public SocialException(string message) : base(message) { }
        public SocialException(string message, Exception innerException): base(message, innerException) { }

    }
    class Post
    {
        public User Author { get; init; }
        public string Content { get; init; }
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public Post(User author, string content)
        {
            if (author==null)
            {
                throw new ArgumentNullException(nameof(author));
            }
            Content = content;
            Author = author;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Author} • {CreatedAt:MMM dd HH:mm}");
            sb.AppendLine(Content);

            var hashtags = Regex.Matches(Content, @"#[A-Za-z]+");

            if (hashtags.Count > 0)
            {
                sb.Append("Tags: ");
                sb.AppendJoin(", ", hashtags.Cast<Match>().Select(m => m.Value));
            }

            return sb.ToString().TrimEnd();
        }
    }
    interface IPostable
    {
        void AddPost(string content);
        IReadOnlyList<Post> GetPosts();
    }
    partial class User : IPostable, IComparable<User>
    {
        public string Username { get; init; }
        public string Email { get; init; }
        private List<Post> _posts;
        private HashSet<string> _following;

        public User(string username, string email)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be null or empty.");
            }
            string pattern = @"^[\w.-]+@[\w-]+(\.[\w]{2,})+$";
            if (!Regex.IsMatch(email, pattern))
            {
                throw new SocialException("Invalid email format");
            }
            username = username.Trim();
            username = char.ToUpper(username[0]) + username.Substring(1).ToLower();
            email = email.Trim().ToLower();
            Username = username;
            Email = email;
            _posts = new List<Post>();
            _following = new HashSet<string>(StringComparer.OrdinalIgnoreCase);  

        }
        public void Follow(string TargetUserName)
        {
            if (string.Equals(Username, TargetUserName, StringComparison.OrdinalIgnoreCase))
            {
                throw new SocialException("Cannot follow yourself");
            }
            if (_following.Contains(TargetUserName))
            {
                Console.WriteLine("User is already followed!");

            }
            else
            {
                _following.Add(TargetUserName);
            }
        }

        Func<string, bool> IsFollowing => username => _following.Contains(username);

        public event Action<Post>? OnNewPost;

        public void AddPost(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Post content cannot be empty");
            }
            if (content.Length > 280)
            {
                throw new SocialException("Post too long (max 280 characters)");
            }
            content = content.Trim();
            Post newpost = new Post(this, content);
            _posts.Add(newpost);
            OnNewPost?.Invoke(newpost);
        }

        public IReadOnlyList<Post> GetPosts()
        {
            return _posts.AsReadOnly();
        }
        public int CompareTo(User other)
        {
            if (other==null) return 1;
            return string.Compare(this.Username, other.Username, StringComparison.OrdinalIgnoreCase);

           
        }
        public override string ToString()
        {
            return $"@{Username}";
        }
    }
    partial class User
    {
        public string GetDisplayName()
        {
            return $"User: {Username} <{Email}>";
        }
    }
    class Repository<T> where T : class
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T item)=>_items.Add(item);
        public IReadOnlyList<T> GetAll()=>_items;
        public T? Find(Predicate<T> match) =>_items.Find(match);
    }
    static class SocialUtils
    {
        public static string FormatTimeAgo(this DateTime ago)
        {
            TimeSpan diff = DateTime.UtcNow - ago;
            if (diff.TotalMinutes < 1)
            {
                return "just now";
            }
            else if (diff.TotalMinutes < 60)
            {
                return $"{(int)diff.TotalMinutes} min ago";
            }
            else if (diff.TotalHours < 24)
            {
                return $"{(int)diff.TotalHours} h ago";
            }
            else
            {
                return ago.ToString("MMM dd");
            }
        }
        
    }
    static class UserExtensions
    {
    public static IEnumerable<string> GetFollowingNames(this User user)
        {
            return user.GetType().GetField("_following",
                           System.Reflection.BindingFlags.NonPublic |
                           System.Reflection.BindingFlags.Instance)!
                       .GetValue(user) as IEnumerable<string>;
        }
    }
}