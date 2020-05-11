using System;

namespace inheritance
{

    class Group
    {
        public string groupName = "Hikers R Us";
        public void greet()
        {
            Console.WriteLine("Welcome back!");
        }
    }
    class User : Group
    {
        public string userName = "jsmith14";
    }
    class Program
    {
        static void MainInheritance(string[] args)
        {
            User newUser = new User();
            newUser.greet();
            Console.WriteLine(newUser.userName + " is a member of " + newUser.groupName);
        }
    }
}
