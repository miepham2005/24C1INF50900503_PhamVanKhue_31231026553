using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_8
    { 
        //Baitap 1: in mang rang cua 
        public static void Main81()
        {
            //1. Cho nguoi dung tu nhap hang va cot
            int column;
            Console.WriteLine("Nhap so hang cua mang: ");
            int row = int.Parse(Console.ReadLine());
            int[][] matran = new int[row][];
            //2. Nhap du lieu cho tung hang
            for (int i = 0; i < row; i++)
            {
                Console.Write($"Nhap so phan tu cua hang {i}:  ");
                column = int.Parse(Console.ReadLine());
                matran[i] = new int[column];//khoi tao mang con voi so cot cu the
                Console.WriteLine($"Nhap {column} phan tu cho hang {i}: ");
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matran[i][j]}: ");
                    matran[i][j] = int.Parse(Console.ReadLine());
                }
            } 
            Inmang(matran);
        }
        static void Inmang(int[][] matran)
        {
            Console.WriteLine("Ma tran duoc nhap vao: ");
            for (int i = 0;i < matran.GetLength(0);i++)
            {
                for(int j = 0;j < matran[i].Length;j++)
                {
                    Console.Write( matran[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //Baitap2.Tao mang rang cua voi cac phan tu ngau nhien
        public static void Main()
        {
            //1. Cho nguoi dung tu nhap hang va cot
            int column;
            Console.Write("Nhap so hang cua mang: ");
            int row = int.Parse(Console.ReadLine());
            int[][] matran = new int[row][];
            //2. Nhap du lieu cho tung hang
            for (int i = 0; i < row; i++)
            {
                Console.Write($"Nhap so phan tu cua hang {i}:  ");
                column = int.Parse(Console.ReadLine());
                matran[i] = new int[column];//khoi tao mang con voi so cot cu the
                Random random = new Random();
                for (int j = 0;j<column;j++)
                { 
                    matran[i][j] = random.Next(0,100);
                }
            }
            Inmang(matran);
            //3.Tim so lon nhat cua tung hang va toan bo ma tran
            Findmax(matran);
            //4.sap xep hang theo thu tu tang dan
            Sortrow(matran);
            //5.In ra cac phan tu trong mang la so nguyen to 
            Printprime(matran);
            Console.WriteLine();
            //6.Tim va in ra vi tri cua mot so co trong mang
            Timvitri(matran);
        }
        
        static void Findmax(int[][] a)
        {
            int globalmax = int.MinValue;
            for (int i = 0;i < a.Length;i++)
            {
                int rowmax = a[i].Max();
                Console.WriteLine($"So lon nhat o hang {i} la: {rowmax}");
                globalmax = Math.Max(rowmax,globalmax);
            }
            Console.WriteLine("So lon nhat trong ma tran la " +  globalmax);
        }
        static void Sortrow(int[][] a)
        {
            for (int i = 0;i<a.Length;i++)
            {
                Array.Sort(a[i]);
            }
            Console.WriteLine("Mang sau khi sap xep theo thu tu tang dan: ");
            Inmang(a);
        }
        static void Printprime(int[][] a)
        {
            Console.WriteLine("Nhung so nguyen to co trong ma tran la: ");
            foreach (var row in a)
            {
                foreach (var num in row)
                {
                    if (Isprime(num)) {Console.Write(num + " "); }
                }
            }
        }
        static bool Isprime(int num)
        { 
            if (num <2) return false;
            if (num == 2 ) return true;
            for(int i = 2;i*i<=num;i++)
                {
                    if(num%i==0) return false;
                }
            return true;      
        }
        static void Timvitri(int[][] a)
        {
            Console.Write("Nhap so can tim trong mang: ");
            int socantim = int.Parse(Console.ReadLine());
            for (int i = 0; i<a.Length;i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                { 
                if(socantim==a[i][j])
                    {
                        Console.Write($"{socantim} xuat hien o hang {i} cot {j}");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}