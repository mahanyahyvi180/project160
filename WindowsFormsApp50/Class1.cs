using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp50
{
   public class cGarbage
    {
        public static int count;

        public cGarbage()
        {
            count += 1;
        }
        ~cGarbage()
        {
            count -= 1;
        }
    }
}
