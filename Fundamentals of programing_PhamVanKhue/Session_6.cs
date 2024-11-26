namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_6

    {
        //bai 1
        /*static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua day: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1} cua day: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            //in day ban dau
            Console.Write(" Cac phan tu cua day: ");
            Console.Write(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                { Console.Write(", " + array[i]); }
            }
            Console.WriteLine();
            //in day sau khi cong them hai
            IncreasesingArrayValue(array);
            Console.WriteLine("Cac phan tu cua day sau khi cong 2: ");
            Console.Write(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                Console.Write($", " + array[i]);
            }

        }*/
        static void IncreasesingArrayValue(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 2;
            }
        }
        static void Printarray(int[] array)
        {
            Console.Write("Cac phan tu cua day : ");
            Console.Write((int)array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);

            }
            Console.WriteLine();
        }
        static void Main6(string[] args)
        {
            Console.Write("Nhap so phan tu cua day: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1} cua day: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            //1. in day ban dau
            Printarray(array);
            //2. cong hai cho moi phan tu
            IncreasesingArrayValue(array);
            Console.WriteLine("Sau khi cong them hai cho moi phan tu trong day");
            Printarray(array);
            //3.
        }
    }
}