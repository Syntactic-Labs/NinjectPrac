using Ninject;
using System;
using System.Reflection;

namespace NinjectPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new ConsoleNotification();
            var user1 = new User("Tim", notificationService);
            user1.ChangeUsername("Robert");
            
        }
    }
}
