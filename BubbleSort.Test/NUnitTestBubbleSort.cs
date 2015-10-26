using System;
using BubbleSortLibrary;
using NUnit.Framework;

namespace BubbleSort.Test
{
    [TestFixture]
    public class NUnitTestBubbleSort
    {
        [Test]
        public void TestBubbleSort()
        {
            int[][] array = {
                                new int[]{11,33,5,15,64},
                                new int[]{22,99,7,32},
                                new int[]{2,55,1},
                                new int[]{11,55,87,3,6,99,312}
                            };
            
            BubbleSortLibrary.BubbleSort bs = new BubbleSortLibrary.BubbleSort(new BubbleSortSumm());
            Assert.AreEqual(bs.Sort(array), KeyToString(new int[] {58,128,160,573}));

            bs.Key = new BubleSortAbsMax();
            Assert.AreEqual(bs.Sort(array), KeyToString(new int[] {55, 64, 99, 312 }));
        }

        [Test]
        public void TestBubbleSortNullAray()
        {
            int[][] array = {
                                new int[]{11,33,5,15,64},
                                new int[]{},
                                new int[]{2,55,1},
                                new int[]{11,55,87,3,6,99,312}
                            };

            BubbleSortLibrary.BubbleSort bs = new BubbleSortLibrary.BubbleSort(new BubbleSortSumm());
            Assert.AreEqual(bs.Sort(array), KeyToString(new int[] { int.MinValue, 58, 128, 573 }));

            bs.Key = new BubleSortAbsMax();
            Assert.AreEqual(bs.Sort(array), KeyToString(new int[] { -2147483648, 55, 64, 312 }));
        }

        [Test]
        public void TestBubbleSortNullArayNullElement()
        {
            int[][] array = {
                                new int[]{11,33,5,15,64},//128
                                new int[]{},
                                new int[]{0},
                                new int[]{11,55,87,3,6,99,312}//573
                            };

            BubbleSortLibrary.BubbleSort bs = new BubbleSortLibrary.BubbleSort(new BubbleSortSumm());
            Assert.AreEqual(bs.Sort(array), KeyToString(new int[] { int.MinValue, 0, 128, 573 }));

            bs.Key = new BubleSortAbsMax();
            Assert.AreEqual(bs.Sort(array), KeyToString(new int[] { -2147483648, 0, 64, 312 }));
        }

        [Test]
        public void TestBubbleSortRevets()
        {
            int[][] array = {
                                new int[]{11,33,5,15,64},
                                new int[]{22,99,7,32},
                                new int[]{2,55,1},
                                new int[]{11,55,87,3,6,99,312}
                            };

            BubbleSortLibrary.BubbleSort bs = new BubbleSortLibrary.BubbleSort(new BubbleSortSumm());
            Assert.AreEqual(bs.Sort(array, true), KeyToString(new int[] { 0, 413, 445, 515 }));

            bs.Key = new BubleSortAbsMax();
            Assert.AreEqual(bs.Sort(array, true), KeyToString(new int[] { 0, 213, 248, 257 }));
        }

        public static string KeyToString(int[] a)
        {
            string s = "";
            
            for (int j = 0; j < a.Length; j++)
                    s += a[j] + " ";
             
            return s;
        }
    }
}