namespace MyFiirstStudiV.V.V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * i;
                Console.WriteLine(array[i]);
                if (i == 9)
                {
                    Console.WriteLine("*********\n");
                }
            }

            int[] array1 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i * i * i;
                Console.WriteLine(array1[i]);
                if (i == 9)
                {
                    Console.WriteLine("*********\n");
                }
            }

            int[] array2 = new int[10];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i] + array1[i];
                Console.WriteLine(array2[i]);
            }

        }
    }
}