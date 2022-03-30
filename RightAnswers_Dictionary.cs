using System;
using System.Collections.Generic;
using System.Text;

namespace Mountainer_s_BackPack_OOP
{
    struct RightAnswers_Dictionary
    {
        
            static List<string> clothes = new List<string>() { "свитер", "кофта"};
            static List<string> tools = new List<string>() { "страховочная обвязка", "веревка", "каска", 
                "фонарик", "верёвка","фонарь", "обвязка", "страховочная" };
            static List<string> additional_items = new List<string>() { "бутерброды", "бутерброд", "шоколад","шоколадка",
            "бутеры","бутер" };
            static  Dictionary<int,List<string>> dict = new Dictionary<int, List<string>>
            {
                {1, clothes},
                {2,tools },
                {3, additional_items }
            };
     
        public int CheckValues(int level,string user_input)
        {
            int count=0;
            foreach(string s in dict[level])
            {
                if(user_input == s)
                {
                    count++;
                }
            }
            return count;
            
        }
    }
}
