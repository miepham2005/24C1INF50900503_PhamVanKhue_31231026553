using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_5

    {
        public static void swap(ref int a, ref int b)
        { int temp = a; a = b; b = a; }
        public static void Main1(string[] args)
        {
            int a = 0; int b = 0;
            Console.WriteLine($"Before call: a = {a}, b = {b}");
            Console.WriteLine($"After call: a = {a}, b = {b}");
            Console.ReadKey();
        }

        //ex.01:finding the maximum of three numbers_improve the next version that accept at least 1 parameter
        public static int Max_of_three(int num_1, int num_2, int num_3)
        {
            return Math.Max(Math.Max(num_1, num_2), num_3);
        }
        public static void Main2(string[] number)
        {
            Console.Write("Nhap so dau tien: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int m = Max_of_three(a, b, c);
            Console.WriteLine("So lon nhat trong ba so duoc nhap vao la" + m);
            Console.ReadKey();
        }
        //ex.02: to calculate the factorial of a number 
        static int Factorial(int a)
        {
            if (a < 0)
                throw new ArgumentException("Input must be non-negative integer"); //bao loi          
            if (a == 0 || a == 1)
                return 1;
            return a * Factorial(a - 1);
            /*int result;
             for(int i = 1; i < a;i++) { result *= i; }
             return result; */
        }
        static void Main51(string[] args)
        {
            Console.Write("Enter an integer: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(b);
            Console.WriteLine($"{b}! = {result}");
            Console.ReadKey();
        }
        //ex.03 taking a number as a parameter and checking wether the number is prime or not
        public static void Songuyento()
        {
            Console.Write("Nhap vao mot so nguyen ban muon kiem tra: ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool result = Kiemtrasonguyen(a);
            Console.WriteLine("Ket qua kiem tra: " + result);
        }
        private static bool Kiemtrasonguyen(int a)
        {
            if (a <= 1) Console.WriteLine("Nhap so nguyen duong lon hon 1.");
            else if (a == 2) { return true; }
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        //ex.03 print all prime less than a number and the first n prime numbers
        public static void Main53()
        {
            Console.WriteLine("Ban muon tim cac so nguyen to nho hon so bao nhieu?");
            Console.Write("Nhap so: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0) throw new ArgumentException("Nhap so nguyen duong");
            Cacsonguyentoduoctimthay(number);
            Console.WriteLine();
            Console.Write("Ban muon hien thi bao nhieu so nguyen to dau tien? ");
            int b = Convert.ToInt32(Console.ReadLine());   
            ThefirstNprimenumber(ref b);
        }
        static void Cacsonguyentoduoctimthay(int a)
        {
            Console.Write($"Cac so nguyen to nho hon {a} la: ");
            for(int i = 2; i < a; i++)
            {
                if(Kiemtrasonguyen(i))
                { Console.Write($"{i}, "); }
            }
        }
        static void ThefirstNprimenumber(ref int a)//hien thi n so nguyen to dau tien
        {
            int c = 2;
            int count = 0;
            Console.Write($"{a} so nguyen to dau tien bao gom: ");
            while (count < a)
            { 
                    if (Kiemtrasonguyen(c))
                    {
                        Console.Write($" {c}, "); count++;
                    }
                c++;
            }
        }
        //ex.04 check a number is "perfect" or not, then print all perfect number that less than 1000
        static void Main54()
        {
            Console.Write("Nhap vao so nguyen can kiem tra: ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool result = Isperfect(a);
            Console.WriteLine($"Ket qua kiem tra: {result} ");
            Printperfectnumber(1000);
        }
        static bool Isperfect(int number)
        {
            if (number == 0) Console.WriteLine("  khong phai so hoan hao");
            int sum = 0;  
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0) sum += i;
            }
            if (sum == number) return true;
            else return false;
        }
        static void Printperfectnumber(int a)
        {
            
            Console.Write("Cac so hoan hao nho hon 1000 bao gom: ");
            for (int i = 2; i <= a; i++)
            {
                if (Isperfect(i)) Console.Write($"{i}, ");
            }    
        }
        //ex.05: checking wether a string is a pangram or not
        //check xem co phai pangram hay khong
        static bool Ispangram(string input)
        {
            //bien cau duoc nhap vao thanh chu thuong
            input = input.ToLower();
            //tao mot tap hop cac phan tu duy nhat, khong lap lai
            HashSet<char> letters = new HashSet<char>();
            //kiem tra tung ki tu trong chuoi
            foreach (char c in input)
            {
                if (c >= 'a' && c <= 'z')
                    letters.Add(c);
            }
            return letters.Count == 26; //true if letter.count = 26 va false neu khong du
            

        }
        static string Nhapcau()
        {
            Console.Write("Enter a sentence: ");
            return Console.ReadLine();
        }
        /// <summary>
        /// chay thu xem vi du va cau do nguoi dung nhap co phai pangram hay khong
        /// </summary>
        static void Main55()
        {
            Console.WriteLine("example: The quick brown fox jumps over the lazy dog");
            string example = "example: The quick brown fox jumps over the lazy dog";
            if (Ispangram(example))
            { Console.WriteLine("This string is a pangram"); }
            else { Console.WriteLine("This string is not a pangram"); }
            string sentence = Nhapcau();
            if (Ispangram(sentence))
            { Console.WriteLine("This string is a pangram"); }
            else { Console.WriteLine("This string is not a pangram"); }
        }
     }
    }
