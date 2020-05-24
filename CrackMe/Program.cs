using Console = Colorful.Console;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;

namespace CrackMe
{
    class Program
    {


        public static void JustBecauseIWant(string text, int time)
        {
            Console.WriteLine(text);Thread.Sleep(time);
        }
        static void Main(string[] args)
        {
            Console.Title = "CrackMe";
            List<char> ask = new List<char>() { 'W', 'h', 'a', 't', ' ', 'i', 's', ' ', 't', 'h', 'e', ' ', 'p', 'a', 's', 's', 'w', 'o', 'r', 'd', '?',' '};
            JustBecauseIWant("Yeah a basic crack me", 500);
            JustBecauseIWant("And now?\n", 750);
            Console.WriteWithGradient(ask, Color.Blue, Color.Red, 14);
            if (Console.ReadLine() == "Choose a value?")
            {
                Console.WriteLine("You're a good reverser! :)", Color.Green);
            } else
            {
                Console.WriteLine("Bad password son! :(", Color.Red);
            }
            Console.ReadLine();
        }
    }
}
