using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace problem_solving
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));

        }
        public static string BreakCamelCase(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    str.Replace();
                }
            }
            return str;
        }

        
    }
}
