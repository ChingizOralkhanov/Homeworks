using System;
using System.Collections.Generic;
using System.Text;

namespace UsernameShared
{
    public class HelloUsername
    {
        public static string GetUsername(string username)
        {
            return ($"{DateTime.Now.ToShortDateString()}, Hello, {username}!");
        }
    }
}
