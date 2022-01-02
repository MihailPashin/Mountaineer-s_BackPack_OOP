using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Mountainer_s_BackPack_OOP
{

    class Program
    {   
        static void Main(string[] args)
        {   bool s;
            do
            {
                string start = "Рюкзак альпинста";
                Console.SetCursorPosition((Console.WindowWidth - start.Length) / 2, Console.CursorTop);
                Console.WriteLine(start);
                s = Question();
                if (s)
                {
                    Console.WriteLine("Тогда начнём собирать снаряжение");
                    Thread.Sleep(1200);
                    Sequence_Of_Actions();
                }
                else
                {
                    Console.WriteLine("Давай по новой, что-то не так ");
                    Thread.Sleep(1200);
                    Console.Clear();
                }
            }
            while (!s);
        }
        static void Sequence_Of_Actions()
        {
            Actions_With_Items newPack;
            Clothes_ cl = new Clothes_();
            newPack = cl;
            newPack.Choose_And_Put();
            newPack.checkItems();
            Tools_ t1 = new Tools_();
            newPack = t1;
            newPack.Choose_And_Put();
            newPack.checkItems();
            AdditionalItems it1 = new AdditionalItems();
            newPack = it1;
            newPack.Choose_And_Put();
            newPack.checkItems();

        }
        static bool Question()
        {
            string russian_letters = @"^([а-яА-Я \-]*)$";
            string input;
                Console.WriteLine("Вы готовы пойти в горы?");
                input = Console.ReadLine();
                if (Regex.Match(input, russian_letters).Success && input!="")
                {
                input = input.ToLower();
                      if (char.ToUpper(input[0]) + input.Substring(1) == "Да")
                      {return true;}
                      
                       else { Console.WriteLine("Вы неверно ввели ответ на вопрос");
                             return false;  }
               
                }

                else
                {
                    Console.WriteLine("Пишите на русском");
                   
                    Console.WriteLine("Пробуйте еще раз");
                    return false;
                }
            }
    }
 }