using System;
using System.Collections.Generic;
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
        //Baitap2.Tao mang rang cua vơi cac phan tu ngau nhien
    }
}