using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Classes
{
    public class Method
    {
        public static int[] MnojChisel(int[] arrary)
        {

            for (int i = 0; i < arrary.Length; i++)
            {
                arrary[i] = arrary[i] * 2;
            }

            return arrary;
        }
    }
}
