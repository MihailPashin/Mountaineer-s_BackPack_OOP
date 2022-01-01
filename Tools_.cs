using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Mountainer_s_BackPack_OOP
{
    class Tools_:Actions_With_Items
    {
        string[] tools = new string[] { "Страховочная обвязка", "Веревка", "Каска", "Фонарик", "Навигатор" };
        void Actions_With_Items.Choose_And_Put()
        {
            bool checker;
            int needed_items_for_second_level = 0 ;
            do
            {

                Console.Clear();
                Loading_Level c = new Loading_Level("Возьмите подходящие инструменты", tools);
                c.Print_Message_And_Array();
                Writing_Answers c2 = new Writing_Answers(tools, 2);
                checker = c2.Osnova();
                if (checker) needed_items_for_second_level++;

            }
            while (needed_items_for_second_level != 4);

        }

        void Actions_With_Items.checkItems()
        {

            if (BackPack.Count == 6)
            {
                Console.WriteLine("Красавчик");
                Console.WriteLine("Пора собираться в путь");
                BackPack.Viewing_Ranets();
            }
           
            Thread.Sleep(2000);
        }
    }
}
