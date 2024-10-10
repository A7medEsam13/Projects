using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Training_Apps.Converting_Numeric_System
{
    internal class App
    {
        static void Main(string[] argu)
        {
            //Binary(25);
            //Octal(25);
            //Hexa(25);
            Console.WriteLine(Rot13("test"));
        }


        public static string Rot13(string message)
        {
            char[] MChar = message.ToCharArray();
            
            for(int i=0; i< MChar.Length; i++)
            {
                MChar[i] = Convert.ToChar(Convert.ToUInt32(MChar[i]) + 13);
            }
            message = MChar.ToString();
            return new string (MChar);
        }

        static void Binary(int num)
        {
            StringBuilder Bin = new StringBuilder();
            while(num > 0) 
            {
                Bin.Append((num % 2).ToString());
                num /= 2;
            }
            Console.WriteLine(Bin.ToString().Reverse().ToArray());
        }

        static void Octal(int num)
        {
            StringBuilder oct = new StringBuilder();
            while(num > 0)
            {
                oct.Append((num % 8).ToString());
                num /= 8;
            }
            Console.WriteLine(oct.ToString().Reverse().ToArray());
        }

        static void Hexa(int num)
        {
            StringBuilder hexa = new StringBuilder();
            while(num > 0)
            {
                if (num % 16 > 9)
                {
                    if(num % 16 == 10)
                    {
                        hexa.Append('A');
                    }
                    else if(num % 16 == 11)
                    {
                        hexa.Append('B');
                    }
                    else if (num % 16 == 12)
                    {
                        hexa.Append('C');
                    }
                    else if (num % 16 == 13)
                    {
                        hexa.Append('D');
                    }
                    else if (num % 16 == 14)
                    {
                        hexa.Append('E');
                    }
                    else if (num % 16 == 15)
                    {
                        hexa.Append('F');
                    }
                }
                else
                {
                    hexa.Append((num%16).ToString());
                }
                num /= 16;
            }
            Console.WriteLine(hexa.ToString().Reverse().ToArray());
        }
    }
}
