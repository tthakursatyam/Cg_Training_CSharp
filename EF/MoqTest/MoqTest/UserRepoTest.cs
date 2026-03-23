using Moq;
using System;
using System.Timers;

public class UserRepositoryTests
{
    public static void RunTest()
    {
        // Create mock
        var mockRepo = new Mock<IUserRepository>();

        // Setup fake data
        mockRepo.Setup(x => x.GetUserName(1))
                .Returns("Mock User");

        // Use mock object
        var repo = mockRepo.Object;

        string result = repo.GetUserName(1);

        Console.WriteLine("User from mock repository: " + result);

        // Verify method call
        mockRepo.Verify(x => x.GetUserName(1), Times.Once);

        Console.WriteLine("Moq test passed.");
    }
}