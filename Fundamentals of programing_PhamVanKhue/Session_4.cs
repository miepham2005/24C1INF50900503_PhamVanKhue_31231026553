using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_4

    {
        public static void Question_01()/// tao game doan so
        {
            ///may cho 1 so ngau nhien
            Console.WriteLine("Chao mung ban den voi tro choi doan so.");
            do
            {
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                int count = 0;
                bool isContinue = true;
                do
                {

                    count++;
                    Console.Write("Ban doan so may? <1..10>: ");
                    int user_num = int.Parse(Console.ReadLine());
                    if (user_num == comp_num)
                    {
                        Console.Write($"Ban doan trung sau {count} lan");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("so ban doan lon hon so may nghi");
                        else
                            Console.WriteLine("so ban doan nho hon so may nghi");
                    }
                } while (isContinue);
                Console.WriteLine("==================");
                Console.Write("choi nua khong?<C/K>:");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.Write("OK");
                    return;
                }
            } while (true);
        }
        public static void Question_02()/// xet xem so duoc nhap vao la le hay chan
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine($"{a} this number is even.");
            else Console.WriteLine($" {a} this number is odd. ");
        }
        public static void Question_03()///find the largest of three numbers
        {
            Console.WriteLine("Nhap 3 so tu ban phim cach nhau bang dau cach: ");
            string input = Console.ReadLine();
            string[] part = input.Split(' ');
            int a = int.Parse((string)part[0]);
            int b = int.Parse((string)part[1]);
            int c = int.Parse((string)part[2]);
            int max = Math.Max(Math.Max(a, b), c);
            Console.WriteLine(" So lon nhat trong ba so la:" + max);
        }
        public static void Question_04()
        {
            Console.WriteLine("Nhap gia tri cua x: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri cua y: ");
            float y = float.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            { Console.WriteLine($"Diem toa do ({x}) {y}) nam o goc phan tu thu nhat"); }
            else if (x < 0 && y > 0) { Console.WriteLine($"Diem toa do ({x};{y}) nam o goc phan tu thu hai"); }
            else if (x < 0 && y < 0) { Console.WriteLine($"Diem toa do ({x};{y}) nam o goc phan tu thu ba"); }
            else if (x > 0 && y < 0) { Console.WriteLine($"Diem toa do ({x};{y}) nam o goc phan tu thu tu"); }
            else if (x != 0 && y == 0) { Console.WriteLine($"Diem toa do ({x};{y}) nam tren truc Ox"); }
            else if (x == 0 && y != 0) { Console.WriteLine($"Diem toa do ({x};{y}) nam tren truc Oy"); }
            else { Console.WriteLine($"Diem toa do ({x};{y}) nam tai O"); }
        }
        public static void Question_05()
        {
            Console.Write("Nhap do dai canh a cua tam giac: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh b cua tam giac: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh c cua tam giac: ");
            double c = double.Parse(Console.ReadLine());
            // Kiem tra xem day co phai tam giac khong 
            if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
            {
                // kiem tra co phai tam giac deu khong 
                if (a == b && a == c) { Console.WriteLine("Day la tam giac deu"); }
                else if ((a == b) || (a == c) || (b == c)) { Console.WriteLine("Day la tam giac can"); }
                else { Console.WriteLine("Day la loai tam giac khac"); }
            }
            else { Console.WriteLine("Day khong phai tam giac"); }
        }
        public static void Question_06()// doc 10 so, tinh tong va trung binh
        {
            int i = 0;
            double n, sum = 0;
            double avg = 0;
            Console.WriteLine("Chuong trinh doc 10 so va tinh tong, trung binh cua chung");
            Console.WriteLine("\n\n");
            Console.WriteLine("Nhap 10 so vao chuong trinh");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Nhap so thu {0}: ", i);
                n = Convert.ToDouble(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.WriteLine("Tong cua 10 so duoc nhap vao tu ban phim la:" + sum);
            Console.WriteLine("Trung binh cong cua 10 so do la:", avg);
        }
        public static void Question_07()// hien thi bang cuu chuong cua mot so nguyen cho truoc
        {
            int b;
            Console.Write("Nhap vao mot so nguyen: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Bang cuu chuong {a} ");
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                b = a * i;
                Console.WriteLine($"{a} * {i} = {b}");
            }
        }
        public static void Question_08()//hien thi mot mau hinh dang tam giac bang cac so
        {
            Console.Write("Nhap vao chieu cao cua tam giac: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); //in ra man hinh tu 1 den i
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int b = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(b + " "); //in ra tu j so tu so tiep theo cua so uoi cung o hang tren 
                    b++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            b = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int k = n - i; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
            }
        }
        public static void Question_09()// cac so hang cua chuoi ham so va tong cua chung
        {
            double sum = 0.0;
            Console.WriteLine("Chuong trinh hien thi so hang cua chuoi ham so va tong cua chung");
            Console.Write("Nhap so luong so hang n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}");
                if (i < n) Console.Write(" + ");
                double term = 1.0 / i;
                sum += term;
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua chuoi ham so: {sum}");
        }
        public static void Question_10()//tim so hoan hao trong mot khoang so da cho truoc 
        {   int count = 0;int start,end;
            do
            {
                Console.Write("Nhap so bat dau: ");
                start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap so ket thuc: ");
                end = Convert.ToInt32(Console.ReadLine());
                if (start == 0) { Console.WriteLine("So bat dau khong duoc phep bang khong"); }
            } while (start == 0);
                for (int i = start; i <= end; i++)
                {
                    int sum = 0;
                    for (int j = 1; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            sum += j; // neu j la uoc thi cong them
                        }
                    }
                    if (sum == i)
                    {
                        count++;
                        if (count == 1) { Console.Write($"Nhung so hoan hao trong khoang so da cho bao gom: {i}"); }
                        if (count > 1)// neu co so tiep theo thi hien them
                        {
                            Console.Write($", {i}");
                        }
                    }
            }
            if (count == 0) { Console.Write("Khong co so hoan hao trong khoang da cho."); }
        }
        public static void Question_11()//kiem tra so da cho co phai so nguyen to hay khong
        {
            int count = 0;int a;
            do
            {
                Console.Write("Nhap vao mot so: ");
                a = int.Parse(Console.ReadLine());
            }while (a <= 1);
            for (int i = 1; i*i < a; i++)
            {
                if (a % i == 0) count++;
            }
             if (count == 1)
                {
                Console.WriteLine($"{a} la so nguyen to");
                }
             else { Console.WriteLine($"{a} khong phai so nguyen to"); }
        }
    }
}
    


