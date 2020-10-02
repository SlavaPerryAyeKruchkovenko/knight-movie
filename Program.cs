using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.IO;

namespace textwritter
{
    
    class Program
    {
        static void Rebuild(string text,int sleep)
        {
            Random color = new Random();
            int rndColor;
            while (text != "")
            {
                Thread.Sleep(sleep);
                rndColor = color.Next(0, 3);

                if (rndColor == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (rndColor == 1)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else if (rndColor == 2)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else if (rndColor == 3)
                    Console.ForegroundColor = ConsoleColor.Green;

                text = text.Substring(0, text.Length - 1);

                Console.Clear();
                Console.WriteLine(text);
            }
        }
        static void Main(string[] args)
        {
            string text="";
            int sleep;

            ConsoleKeyInfo newStr = new ConsoleKeyInfo();
            Console.WriteLine("Введите Задержку");

            sleep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите текст");
            Console.WriteLine("Нажмите esc, чтоб закончить");

            while(newStr.Key!=ConsoleKey.Escape)
            {
                while (newStr.Key != ConsoleKey.Enter)
                {
                    newStr = Console.ReadKey();
                    text=text+(newStr.KeyChar.ToString());                   
                }
                File.AppendAllText(@"C:\Program Files\yu\File.txt", text);
                Rebuild(text,sleep);

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Введите текст");
                Console.WriteLine("Нажмите esc, чтоб закончить");

                newStr = Console.ReadKey();
            }          
        }
    }
}
