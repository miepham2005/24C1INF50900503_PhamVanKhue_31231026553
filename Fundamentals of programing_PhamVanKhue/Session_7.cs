using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_7
    {
         static void Nhapmangngaunhien(int[,] a, int rows, int columns)
        {
            Random rnd = new Random();  
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(0, 100);
                }
            }
        }
        static void XuatMang(int [,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Timvitri(int[,] a, int val)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == val)
                    {
                     Console.WriteLine($"{val} nam o dong {i} cot {j}");
                    }
                }
            }
        }
        //function to print i-th row or column 
        static void Inhanghoaccot(int[,] a, bool hang, int index)
        { //in hang
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            if (hang)
            {
                if (index >= 0 && index < m)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"{a[index, i]}");
                    }
                }
                else { Console.WriteLine("Gia tri hang khong hop le"); }
            }
            else
            {
                if (index >= 0 && index < n)
                {
                    for (int i = 0; i < m; i++)
                    {
                        Console.WriteLine($"{a[i, index]}");
                    }
                }
                else { Console.WriteLine("Gia tri hang khong hop le"); }
            }
        }
        static void Findmax(int[,] a)
        {
            //int maxValue = matrix.Cast<int>().Max();
            //cach khac: chuyen ma tran thanh IEnumerable<int> va tim max
            int max = a[0,0];
            foreach (int i in a)
            {
                if (i > max)
                    max = i;
            }   
            Console.WriteLine("Gia tri lon nhat trong ma tran la " + max);
        }
        static void Findmin(int[,] a, bool tronghang, int chiso)
        {
                int min;
                int m = a.GetLength(0);
                int n = a.GetLength(1);
                if(tronghang)
                {
                  min = a[chiso, 0];
                  for (int i = 0;i < n;i++)
                        { 
                          if (a[chiso, i] < min) min = a[chiso, i]; 
                        }
                    Console.WriteLine($"Gia tri nho nhat trong hang {chiso} la {min}");     
                }
                else
            {
                min = a[0, chiso];
                for (int i = 0; i < n; i++)
                {
                    if (a[chiso, i] < min) min = a[i,chiso];
                }
                Console.WriteLine($"Gia tri nho nhat trong cot {chiso} la {min}");
            }
        }                    
        static int [,] Tranposematrix(int[,] a)
        {
            int[,] matranchuyenvi;
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            matranchuyenvi = new int[n,m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matranchuyenvi[j, i] = a[i,j];// phai de bien can duoc gan o phia truoc
                }
            }
            return matranchuyenvi;
        }
        static void Induongcheochinh(int[,] a)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            int mindimension = Math.Min(m,n);
            Console.WriteLine("Day la duong cheo chinh cua ma tran: ");
            for (int i = 0;i < mindimension;i++)
            {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("    ");
                    }
                
                Console.WriteLine($"{a[i,i]}");
            }    
        }
        static void Induongcheophu(int[,] a)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            int midimension = Math.Min(m,n);
            Console.WriteLine("Day la duong cheo phu cua ma tran: ");
            for (int i = 0;i < midimension;i++)
            {
                for (int j = 0; j < midimension - i - 1; j++)
                {
                    Console.Write("    ");
                }
                Console.WriteLine(a[i,n-i-1]);
            }    

        }
        public static void Main7()
        {
            int[,] a;
            Console.Write("Nhap so dong: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int columns = int.Parse(Console.ReadLine());
            a = new int[rows, columns];
            Nhapmangngaunhien(a, rows, columns);
            XuatMang(a);
            Console.WriteLine();
            //in mot hang hoac mot cot cua ma tran
            Console.Write("Ban muon in mot hang (r) hay in mot cot (c): ");
            string choice = Console.ReadLine().ToLower();
            bool hang = choice == "r";
            Console.Write("\n Nhap chi so cua hang/cot ma ban muon in:  ");
            int index = int.Parse(Console.ReadLine());
            Inhanghoaccot(a,hang, index);
            Findmax(a);
            Console.Write("Ban muon tim gia tri nho nhat cua hang (r) hay cot (c): ");
            string luachon = Console.ReadLine().ToLower();
            bool tronghang = luachon == "r";
            Console.Write("\n Nhap chi so cua hang/cot ma ban muon tim gia tri nho nhat:  ");
            int chiso = int.Parse(Console.ReadLine());
            Findmin(a, tronghang, chiso);
            int [,] matranchuyenvi = Tranposematrix(a);
            XuatMang(matranchuyenvi);
            Induongcheochinh(a);
            Induongcheophu(a);
        }
    }
}
    
