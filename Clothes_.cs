using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Mountainer_s_BackPack_OOP
{
    class Clothes_:Actions_With_Items
    {
        string[] clothes = new string[] { "Свитер", "Панама", "Сандалии", "Шорты", "Кепка" };
        void Actions_With_Items.Choose_And_Put()
        {
            bool checker;
          
            do
            {

                Console.Clear();
                Loading_Level c = new Loading_Level("Возьмите подходящую одежду", clothes);
                c.Print_Message_And_Array();
                Writing_Answers c2 = new Writing_Answers(clothes,1);
                 checker = c2.Osnova();

            }
            while (!checker && BackPack.error!=3);
            Console.Clear();
        }

        void Actions_With_Items.checkItems()
        {

            if (BackPack.Count == 6)
            {
                Console.WriteLine("Красавчик");
                Console.WriteLine("Пора собираться в путь");
                BackPack.Viewing_Ranets();
            }
            else { Console.WriteLine("Осталось еще немного"); }
            Thread.Sleep(2000);
        }
    }
}
