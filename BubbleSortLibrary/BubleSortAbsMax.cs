using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortLibrary
{
    public class BubleSortAbsMax : IKey
    {
        public void UpdateKey(ref int i, int j)
        {
            if (i < Math.Abs(j))
                i = j;
        }
    }
}
