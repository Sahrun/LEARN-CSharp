namespace Chapter_21_O_n__Algorithm_for_circular
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Section 21.1: Example of a generic method that rotates an array by a given shift");

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int shiftCount = 1;
            Rotate(ref array, shiftCount);
            Console.WriteLine(String.Join(',', array));

            array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            shiftCount = 15;
            Rotate(ref array, shiftCount);
            Console.WriteLine(string.Join(',', array));

            array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            shiftCount = -1;
            Rotate(ref array, shiftCount);
            Console.WriteLine(string.Join(',', array));

            array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            shiftCount = -35;
            Rotate(ref array, shiftCount);
            Console.WriteLine(string.Join(',', array));
        }


        private static void Rotate<T>(ref T[] array, int shiftCount)
        {
            T[] backupArray = new T[array.Length];
            for (int index = 0; index < array.Length; index++)
            {
                backupArray[(index + array.Length + shiftCount % array.Length) % array.Length] =
               array[index];
            }
            array = backupArray;
        }
    }
}