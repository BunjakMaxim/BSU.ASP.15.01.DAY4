using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortLibrary
{
    public interface IKey
    {
        void UpdateKey(ref int i, int j);
    }
}
