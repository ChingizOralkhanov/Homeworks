using System;

namespace MultiTargeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string hello = UsernameShared.HelloUsername.GetUsername(name);
            Console.WriteLine(hello);
        }
    }
}
