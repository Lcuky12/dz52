using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            char userInputySbool;
            int nameCharacters;
            string numberLines;
            string characters = "";

            Console.Write(" Введите имя ");
            userName = Console.ReadLine();
            Console.Write(" Введите символ ");
            userInputySbool = Convert.ToChar(Console.ReadLine());

            nameCharacters = userName.Length;
            numberLines = userInputySbool + userName + userInputySbool;

            for (int i = 0; i < nameCharacters; i++)
            {
                characters += userInputySbool;
            }

            Console.WriteLine(characters);
            Console.WriteLine(numberLines);
            Console.WriteLine(characters);
        }
    }
}