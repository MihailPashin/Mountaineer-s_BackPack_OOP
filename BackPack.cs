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

    }
}
