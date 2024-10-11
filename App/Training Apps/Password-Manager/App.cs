using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Training_Apps.Password_Manager
{
    public static class App
    {
        private static readonly Dictionary<string, string> _PasswordEntries = new();
        public static void Run(string[] args)
        {
            ReadPasswords();
            while (true)
            {
                
                Console.WriteLine("Please, select an option: ");
                Console.WriteLine("1. List all passwords.");
                Console.WriteLine("2. Add/Change password.");
                Console.WriteLine("3. Get password.");
                Console.WriteLine("4. Delete password.");

                var selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                {
                    ListAllPasswords();
                }
                    else if (selectedOption == "2") 
                    {
                        AddOrChangePassword();
                    }
                    else if (selectedOption == "3") 
                    {
                        GetPassword();
                    }
                    else
                    {
                        DeletePassword();
                    }

                    Console.WriteLine("--------------------------------------------------");
                }
            }

            private static void ListAllPasswords()
            {
                
                foreach (var entry in _PasswordEntries)
                {
                    Console.WriteLine($"{entry.Key} = {entry.Value}");
                }
            }

            private static void AddOrChangePassword()
            {
                Console.Write("Enter the Web site Name: ");
                var key = Console.ReadLine();
                Console.Write("Enter the Password : ");
                var pass = Console.ReadLine();

                if (_PasswordEntries.ContainsKey(key))
                {
                    _PasswordEntries[key] = pass;
                }
                else
                {
                    _PasswordEntries.Add(key, pass);    
                }
                SavePasswords();
            }

            private static void GetPassword()
            {
                Console.Write("Enter The Web site name: ");
                var siteName = Console.ReadLine();
            if(_PasswordEntries.ContainsKey(siteName))
                Console.WriteLine($"Password of {siteName} = {_PasswordEntries[siteName]}");
            else
            {
                Console.WriteLine("Password Of this site name doesn't exist");
            }
            }

            private static void DeletePassword()
            {
                Console.Write("Enter The name of web site: ");
                var siteName = Console.ReadLine();
                _PasswordEntries.Remove(siteName);
                SavePasswords();
                Console.WriteLine($"Password of {siteName} has been deleted :)");
            }


        private static void ReadPasswords()
        {
            if (File.Exists("Passwords.txt"))
            {
                var PasswordLines = File.ReadAllText("Passwords.txt");
                foreach (var line in PasswordLines.Split(Environment.NewLine))
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        var EqualIndex = line.IndexOf('=');
                        var AppName = line.Substring(0, EqualIndex);
                        var password = line.Substring(EqualIndex + 1);
                        _PasswordEntries.Add(AppName, password);
                    }
                }
            }
            
        }

        private static void SavePasswords()
        {
            var sb = new StringBuilder();
            foreach(var entry in _PasswordEntries)
            {
                sb.AppendLine($"{entry.Key} = {entry.Value}");
            }
            File.WriteAllText("Passwords.txt" , sb.ToString());
        }
    }
}
