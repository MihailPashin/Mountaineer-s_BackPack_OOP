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
        public static bool all_its_fine;
        public BackPack(string item)
        { Item = item;}
        public static int Count =>  count;
        public static bool All_its_fine => all_its_fine;

        private string Item
        {
            set
            {
                bool SET_VALUE = false;
                string s = value;
                for (int i = 0; items[i] != null && i<items.Length;i++)
                { 
                    if (value == items[i]){SET_VALUE = true;}
                }
               
                switch(SET_VALUE)
                {
                    case true: Console.WriteLine("Не пытайтесь нас обмануть"); all_its_fine=false; 
                        break;
                    case false:
                        Proverochka_OnCorrect c= new Proverochka_OnCorrect(value);
                        if (c.Check_Playing() == 1)
                        {
                            items[count] = value;
                            Console.WriteLine("Значение прошло проверку");
                            all_its_fine = true;
                            count++;
                        }
                        else
                        {Console.WriteLine("Не пытайтесь нас обмануть"); all_its_fine = false;}
                        break;
                }
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
      
    }
}
