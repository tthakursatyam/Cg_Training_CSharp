using System;

public interface IUserRepository
{
    string GetUserName(int id);
}

public class UserRepository : IUserRepository
{
    public string GetUserName(int id)
    {
        if (id == 1)
            return "Real User";

        return "Unknown User";
    }
}