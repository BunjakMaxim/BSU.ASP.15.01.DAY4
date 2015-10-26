using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortLibrary
{
    public class BubbleSort
    {
        public IKey Key{private get; set;}

        public BubbleSort(IKey k)
        {
            Key = k;
        }

        public string Sort(int[][] array, bool flag = false)
        {
            int[] keys = SetKeys(array, flag);
            int iEnd = keys.Length - 1;

            while (iEnd > 0)
            {
                for (int j = 0; j < iEnd; j++)
                    if (keys[j] > keys[j + 1])
                    {
                        int m = keys[j];
                        keys[j] = keys[j + 1];
                        keys[j + 1] = m;

                        int[] a = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = a;
                    }
                iEnd--;
            }

            return KeyToString(keys);
        }

        private int[] SetKeys(int[][] array, bool flag)
        {
            int[] keys = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 0)
                {
                    keys[i] = array[i][0];

                    for (int j = 1; j < array[i].Length; j++)
                        Key.UpdateKey(ref keys[i], array[i][j]);
                }
                else
                    keys[i] = int.MinValue;
            }

            if (flag)
                Invert(keys);

            return keys;
        }

        private void Invert(int[] keys)
        {
            int max = keys.Max();

            for (int i = 0; i < keys.Length; i++)
                unchecked
                {
                    keys[i] = max - keys[i];
                }
        }

        public string KeyToString(int[] keys)
        {
            string s = "";
            
            for (int i = 0; i < keys.Length; i++)
                s += keys[i] + " ";
       
            return s;
        }
    }
}
