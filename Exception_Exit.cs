using System;
using System.Collections.Generic;
using System.Text;

namespace Mountainer_s_BackPack_OOP
{
    class Exception_Exit :Exception
    {
        public List<string> glitches_2 = new List<string>();

        public Exception_Exit(List<string> glitches, string message = "") : base(message)
        {

            if (glitches.Count != 0)
            {
                glitches_2 = glitches;

            }
        }


    }
}
