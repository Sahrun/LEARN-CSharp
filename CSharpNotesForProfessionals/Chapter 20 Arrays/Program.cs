using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Chapter_20_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 20: Arrays");
            Console.WriteLine("Section 20.1: Declaring an array");

            int[] arr = new int[10];

            int[] arr1 = new int[3] { 7, 9, 4 };
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr1[1]);

            int[] arr2 = null;
            //int first = arr2[0];

            int[] arr3 = new int[] { 24, 2, 13, 47, 45 };

            int[] arr4 = { 24, 2, 13, 47, 45 }; //Ok
            int[] arr5;
            // arr5 = { 24,2,13,47,45 }; // Won't compile

            // Implicitly typed arrays

            var arr7 = new[] { 1, 2, 3 };
            var arr8 = new[] { "one", "two", "three" };
            var arr9 = new[] { 1.0, 2.0, 3.0 };

            Console.WriteLine("Section 20.2: Initializing an array filled with a repeated nondefault value");
            bool[] booleanArray = Enumerable.Repeat(true, 10).ToArray();
            int[] intArray = Enumerable.Repeat(100, 5).ToArray();
            string[] strArray = Enumerable.Repeat("C#", 5).ToArray();


            Console.WriteLine("Section 20.3: Copying arrays");
            var sourceArray = new int[] { 11, 12, 3, 5, 2, 9, 28, 17 };
            var destinationArray = new int[3];
            Array.Copy(sourceArray, destinationArray, 3);

            sourceArray = new int[] { 11, 12, 7 };
            destinationArray = new int[6];

            sourceArray.CopyTo(destinationArray, 2);

            // clone

            destinationArray = (int[])sourceArray.Clone();


            Console.WriteLine("Section 20.4: Comparing arrays for equality");
            int[] arr10 = { 3, 5, 7 };
            int[] arr11 = new[] { 3, 5, 7 };
            bool result = arr10.SequenceEqual(arr11);
            Console.WriteLine("Array equals? {0}", result);


            Console.WriteLine("Section 20.5: Multi-dimantional arrays");
            int[,] dm_arr = new int[10, 10];
            int[,,] dm_arr1 = new int[10, 10, 10];

            int[,] dm_arr2 = new int[4, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 }, { 4, 4 } };

            // access 
            Console.Out.WriteLine(dm_arr2[3, 1]);


            Console.WriteLine("Section 20.6: Getting and setting array values");
            int[] gt_arr = new int[] { 0, 10, 20, 30 };

            Console.WriteLine(gt_arr[2]);

            gt_arr[2] = 100;

            Console.WriteLine(gt_arr[2]);

            Console.WriteLine("Section 20.7: Iterate over an array");

            int[] i_arr = new int[] { 1, 6, 3, 3, 9 };

            for (int i = 0; i < i_arr.Length; i++)
            {
                Console.WriteLine(i_arr[i]);
            }

            foreach (int element in i_arr)
            {
                Console.WriteLine(element);
            }


            unsafe
            {
                int length = i_arr.Length;

                fixed (int* p = i_arr)
                {
                    int* pInt = p;
                    while (length-- > 0)
                    {
                        Console.WriteLine(*pInt);
                        pInt++;
                    }
                }
            }


            Console.WriteLine("Section 20.8: Creating an array of sequential numbers");
            int[] sequence = Enumerable.Range(1, 100).ToArray();

            int[] squares1 = Enumerable.Range(2, 10).Select(x => x * x).ToArray();

            Console.WriteLine("");
            Console.WriteLine("Section 20.9: Jagged arrays");
            int[][] a = new int[8][];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new int[10];
            }

            for (int i = 0; i < a[2].Length; i++)
            {
                Console.WriteLine(a[2][i]);
            }

            Console.WriteLine("Array Multi dimantion");

            int[,,][,,,,][] arrM = new int[8, 10, 12][,,,,][];

            Console.WriteLine(arr.GetType().ToString());

            Console.WriteLine(typeof(int[,,][,,,,][]).ToString());

            Console.WriteLine("");
            Console.WriteLine("Section 20.10: Array covariance");
            string[] strings = new[] { "foo", "bar" };
            object[] objects = strings;
            string[] strings1 = new[] { "Foo" };
            object[] object1 = strings1;

            //object1[0] = new object();
            string str = strings1[0];


            Console.WriteLine("");
            Console.WriteLine("Section 20.11: Arrays as IEnumerable<> instances");

            int[] arr_1 = { 3, 5, 7 };
            IEnumerable<int> enumerableIntegrs = arr_1;
            List<int> listOfIntegers = new List<int>();
            listOfIntegers.AddRange(arr_1);

            IEnumerable<int> calculateList = listOfIntegers.Select(i => 10 * 1);

            Console.WriteLine("");
            Console.WriteLine("Section 20.12: Checking if one array contains another array");

            byte[] EndOfStream = Encoding.ASCII.GetBytes("---3141592---");
            byte[] FakeReceivedFromStream = Encoding.ASCII.GetBytes("Hello, Word!!!---13141592");
            if (FakeReceivedFromStream.Contains(EndOfStream))
            {
                Console.WriteLine("Message received");
            }



        }

    }

    public static class ArrayHelpers
    {
        public static bool Contains<T>(this T[] array, T[] candidate)
        {
            if (IsEmptyLocate(array, candidate))
                return false;

            if (candidate.Length > array.Length)
                return false;

            for (int a = 0; a <= array.Length - candidate.Length; a++)
            {
                if (array[a].Equals(candidate[0]))
                {
                    int i = 0;
                    for (; i < candidate.Length; i++)
                    {
                        if (false == array[a + i].Equals(candidate[i]))
                            break;
                    }
                    if (i == candidate.Length)
                        return true;
                }

            }
            return false;
        }

        static bool IsEmptyLocate<T>(T[] array, T[] candidate)
        {
            return array == null
                || candidate == null
                || array.Length == 0
                || candidate.Length == 0
                || candidate.Length > array.Length;
        }

    }
}