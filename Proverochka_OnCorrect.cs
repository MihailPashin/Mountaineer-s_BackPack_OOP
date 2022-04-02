using System;
using System.Collections.Generic;
using System.Text;

namespace Mountainer_s_BackPack_OOP
{
    struct Proverochka_OnCorrect
    {
        
        int index_for_check;
        string user_input;
        
        public Proverochka_OnCorrect( string inpt)
        {
            this.user_input = inpt;
            this.index_for_check = Writing_Answers.Asking_ForIndex();
        }
        public int Check_Playing()
        {
            RightAnswers_Dictionary c = new RightAnswers_Dictionary();
            return c.CheckValues(index_for_check, user_input);
        }
    }
}
