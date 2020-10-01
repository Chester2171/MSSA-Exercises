using System;
using System.Collections.Generic;

namespace PasswordEncryption
{
    class Program
    {
        
        static Dictionary<string, string> users = new Dictionary<string, string>();

        
        static void menu()
        {
            Console.Write("\nPASSWORD AUTHENTICATION SYSTEM \n" +
                "1. Establish an account\n" +
                "2. Authenticate a user\n" +
                "3. Exit the system \n\n" +
                "Enter selection:");
            int selction = int.Parse(Console.ReadLine());

            if (selction == 1) establishAccount();
            else if (selction == 2) authenticate();
            else if (selction == 3) exit();
        }

        
        static void establishAccount()
        {

            Console.Write("Enter a username:");
            string username = Console.ReadLine();

            if (users.ContainsKey(username))
            {
                Console.WriteLine("That username is already taken. Choose a different username.");
                establishAccount();
            }

            else
            {
                Console.Write("Enter your password:");
                users.Add(username, encrypt(Console.ReadLine()));
                Console.WriteLine("Account Created");
            }

            menu();
        }

        
        static void authenticate()
        {
            string username = "";
            string password = "";
            Console.Write("Enter your username:");
            username = Console.ReadLine();

            if (!users.ContainsKey(username))
            {
                Console.WriteLine("That username does not exist.");
                authenticate();
            }

            else
            {
                Console.Write("Enter your password:");
                password = encrypt(Console.ReadLine());
            }

            if (users[username] == password)
            {
                Console.WriteLine("Authenticated");
                menu();
            }
            else
            {
                Console.WriteLine("Your password was incorrect.");
                menu();
            }
        }

         
        static void exit()
        {
            Console.WriteLine("\n All users are:");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }

        
        static string encrypt(string input)
        {

            byte[] data = System.Text.Encoding.ASCII.GetBytes(input);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);

            return hash;
        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
