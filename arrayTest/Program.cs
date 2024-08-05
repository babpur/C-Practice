namespace arrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열 선언(1)
            // 선언과 초기화를 따로
            int[] array1 = new int[3];
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;

            Console.WriteLine("array1: " + array1[0]);

            Console.WriteLine("array1: " + array1[1]);

            Console.WriteLine("array1: " + array1[2]);

            // 배열 선언(2)
            int[] array2 = new int[] { 1, 2, 3 };

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            // 배열 선언(3)
            int[] array3 = { 4, 5, 6 };
            Console.WriteLine("array3: " + array3);

           /* Console.WriteLine(array3.Length);

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }*/

            foreach (int i in array3)
                Console.WriteLine(i); // 값을 직접 출력
            Console.ReadLine();

        }
    }
}
