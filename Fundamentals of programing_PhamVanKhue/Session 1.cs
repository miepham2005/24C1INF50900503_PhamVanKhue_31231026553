// See https://aka.ms/new-console-template for more information
using System.Collections;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class session1
    {
        public static void Main()
        {
            Session_4.Question_11();
            //Question_02();
            //Question_04();
            //Question_05();
            //Question_07();
            //Question_10();

            Console.ReadKey();
        }
        public static void Question_01()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }
        public static void Question_02()
        {
            Console.Write("Nhap a: ");
            object a = Console.ReadLine();
            Console.Write("Nhap b: ");
            object b = Console.ReadLine();
            object c = a;
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {c}");
        }
        public static void Question_03()
        {
            Console.Write("Nhap so a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Double c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");
        }
        public static void Question_04()
        {
            Console.Write("Nhap so feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double met = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {met} met");
        }
        public static void Question_05()
        {
            Console.Write("Nhap do c: ");
            double do_c1 = Convert.ToDouble(Console.ReadLine());
            double do_f1 = do_c1 * 9 / 5 + 32;
            Console.WriteLine($"ket qua doi thanh do f la {do_f1}");
            Console.Write("Nhap do f: ");
            double do_f2 = Convert.ToDouble(Console.ReadLine());
            double do_c2 = (do_f2 - 32) * 5 / 9;
            Console.WriteLine($"ket qua doi thanh do c la {do_c2}");
        }
        public static void Question_06()
        {
            Console.Write($"{sizeof(int)}");
        }
        public static void Question_07()
        {
            Console.Write("Nhap 1 ki tu: ");
            char a = Convert.ToChar(Console.ReadLine());
            int b = (int)a;
            Console.WriteLine($"Gia tri ASCII cua {a} la {b}");
        }
        public static void Question_08()
        {
            Console.Write("Nhap ban kinh duong tron: ");
            double r = double.Parse(Console.ReadLine());
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Dien tich duong tron la {s}");
        }
        public static void Question_09()
        {
            Console.WriteLine("Nhap chieu dai canh hinh vuong: ");
            double a = double.Parse(Console.ReadLine());
            double s = Math.Pow(a, 2);
            Console.WriteLine($"Dien tich hinh vuong la {s}");
        }
        public static void Question_10()
        {
            Console.WriteLine("Nhap so ngay can chuyen doi: ");
            int ngaycanchuyen = int.Parse(Console.ReadLine());
            int nam = ngaycanchuyen / 365;
            int tuan = ngaycanchuyen % 365 / 7;
            int ngay = ngaycanchuyen % 365 % 7;
            Console.WriteLine($"Ket qua chuyen doi {nam} nam {tuan} tuan {ngay} ngay");

        }
       
    }
    }

