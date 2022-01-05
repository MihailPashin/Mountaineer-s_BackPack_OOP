using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Mountainer_s_BackPack_OOP
{
    class BackPack
    {
        static int count;
        static string[] items = new string[6];
        public static int error = 0;
        static List<string> glitches = new List<string>();
        public BackPack(string item)
        {
            Item = item;
            count++;
        }
        public static int Count
        {
            get { return count; }
        }
        private string Item
        {
            set
            {
                items[count] = value;

            }
        }
        public static void Viewing_Ranets()
        {

            Console.WriteLine("Набор Альпиниста");

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1} :  " + items[i]);
            }
            if (count == 6) Congratulations();
            Thread.Sleep(1000);
        }
        static void Congratulations()
        {
            
            Console.WriteLine("Рад помочь собрать рюкзак в дорогу");
            Console.WriteLine("Спасибо за игру!");
            Thread.Sleep(2000);
        }
        public static void Checker()
        {
            error++;
            switch(error)
            {
                case 1: case 2: Console.WriteLine($"Ой, у вас осталась только {3-error} ошибки"); break;
                case 3:
                    glitches.Add(" Три ошибки это много");
                    Console.Clear();
                    Viewing_Ranets();
                    //GameOver();
                    throw new Exception_Exit(glitches, "Игра окончена!");
                   
            }
        }
        //static void GameOver()
        //{
        //    Console.WriteLine("Игра закончена. Постарайтесь не расстроить в следующий раз ");
        //    Thread.Sleep(1800);
        //}
    }
}
