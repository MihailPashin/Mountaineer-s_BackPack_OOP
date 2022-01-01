﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Mountainer_s_BackPack_OOP
{
    class Writing_Answers : Right_Answers
    {
        static string proverka_for_cyrrilic = @"^([а-яА-Я \-]*)$";
        public Writing_Answers(string[] variants, int index_of_level)
        {
            Index_of_level = index_of_level;
          Variants = variants;
           
        }
        static int index_of_level;
        static string[] strocka;
        static string input;
        private int Index_of_level
        {
            set { if (!(value > 3 && value < 1))
                {
                    index_of_level = value;
                }

            } get { return index_of_level; }
        }
        private string[] Variants
        {
            set
            {
                Array.Resize(ref strocka, value.Length);
                for (int i = 0; i < value.Length; i++)
                {
                    if (Regex.Match(value[i], proverka_for_cyrrilic).Success && value[i] != "")
                    {
                        strocka[i] = value[i];

                    }
                    else
                    {
                        Console.WriteLine("Не пытайтесь нас обмануть");
                    }
                }
            }
            get { return strocka; }

        }
        public bool Osnova()
        {       input = Console.ReadLine();
                if (input != "") input = char.ToUpper(input[0]) + input.Substring(1);

                List<int> result = Right_Answers.right_answers.Select((s, index) => new { s, index })
                        .Where(x => x.s == input)
                        .Select(x => x.index)
                        .ToList();

                if (result.Count == 1)
                {
                    BackPack f1 = new BackPack($"{input}");
                    Console.WriteLine($"Вы положили в рюкзак {input}");
                    
                    switch (index_of_level)
                    {
                     
                        case 2:
                            if (BackPack.Count!=5)
                            {
                            Console.WriteLine("Собери пожалуйста до конца");
                                break;
                            }
                            else { Console.WriteLine("Теперь осталось лишь разобраться с едой"); //index_of_level++;
                            }
                            break;
                        case 3: Console.WriteLine("Отличный выбор! Респект!"); break;
                    }
                    Thread.Sleep(2000);
                    return true;
                }
                else
                {
                    
                    switch (index_of_level)
                    {
                        case 1: Console.WriteLine("Не хочу чтобы ты превратился в ледышку когда шел к горе.Давай по новой"); break;
                        case 2:
                        if(input== "Навигатор")
                        Console.WriteLine($"Вы положили в рюкзак {input} и это не подходит");
                        Console.WriteLine("Это не верно.Попробуйте еще раз");

                        break;
                    case 3: Console.WriteLine("Выберите что-то более сытное иначе проголодаетесь"); 
                        Console.WriteLine("Это не верно"); break;

                    }
                    Console.WriteLine("Попробуйте еще раз");
                    Thread.Sleep(1700);
                    return false;
                }
        }
    }
}
