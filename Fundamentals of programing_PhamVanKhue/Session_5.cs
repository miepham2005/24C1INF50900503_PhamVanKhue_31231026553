using System.Security.Cryptography.X509Certificates;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_5

    {
        public static void swap (ref int a, ref int b)
            { int temp = a;  a = b; b = a; }
        public static void Main1(string[] args)
        {
            int a = 0; int b = 0;
            Console.WriteLine($"Before call: a = {a}, b = {b}");
            Console.WriteLine($"After call: a = {a}, b = {b}");
            Console.ReadKey();
        }
        
        //ex.01:finding the maximum of three numbers_improve the next version that accept at least 1 parameter
        public static int Max_of_three(int num_1,int num_2,int num_3)
        { 
         return Math.Max(Math.Max(num_1,num_2),num_3);    
        }
        public static void Main2(string[] number )
        {
            Console.Write("Nhap so dau tien: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int m = Max_of_three(a,b,c);
            Console.WriteLine("So lon nhat trong ba so duoc nhap vao la" + m);
            Console.ReadKey();  
        }
    }
}