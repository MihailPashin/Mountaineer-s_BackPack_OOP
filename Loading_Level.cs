using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Mountainer_s_BackPack_OOP
{
    class Loading_Level
    {
        static string proverka_for_cyrrilic = @"^([а-яА-Я \-]*)$";
        string begin_stroka;
        static string[] strocka = new string[0];
        public Loading_Level(string beginning, string[] variants)
        {
            Beginning = beginning;
            Variants = variants;

        }
        private string Beginning
        {
            set
            {
                if(Regex.Match(value, proverka_for_cyrrilic).Success && value != "")
                {
                    begin_stroka = value;
                }
                else
                {
                    Console.WriteLine("Не пытайтесь нас обмануть");
                }
            }
            get { return begin_stroka; }
        }
        private string[] Variants
        {
            set
            {
                Array.Resize(ref strocka, value.Length);
                for (int i =0;i<value.Length;i++)
                {
                    if (Regex.Match(value[i], proverka_for_cyrrilic).Success && value[i] != "")
                    {
                        strocka[i]= value[i];

                    }
                    else
                    {
                        Console.WriteLine("Не пытайтесь нас обмануть");
                    }
                }
            }
            get { return strocka; }

        }
        public void Print_Message_And_Array()
        {
            Console.Clear();
            BackPack.Viewing_Ranets();
            Console.WriteLine();
            Console.WriteLine(begin_stroka);
            Console.WriteLine("\n");
            for (int i = 0; i < strocka.Length; i++)
            {
                Console.WriteLine($"{strocka[i]}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Впишите её");
        }
    }
}
