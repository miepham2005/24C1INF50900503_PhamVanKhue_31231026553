using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_2
    {
     
        public static void Question_01()
        {
            Console.Write("Nhap do c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double k = c + 273;
            double f = c * 18 / 10 + 32;
            Console.WriteLine($"ket qua chuyen doi sang do k: {k}");
            Console.WriteLine($"ket qua chuyen doi sang do f: {f}");
        }
        public static void Question_02()
        {
            Console.Write("Nhap ban kinh hinh cau: ");
            double r = double.Parse(Console.ReadLine());
            double s = 4 * Math.Pow(r, 2) * Math.PI;
            double v = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Dien tich hinh cau: {s}");
            Console.WriteLine($"The tich hinh cau: {v}");
        }
        public static void Question_03()
        {
            Console.Write("Nhap a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a + b;
            float t = a - b;
            float n = a * b;
            float ch = a / b;
            float mo = a % b;
            Console.WriteLine($"ketqua cong don: {a} + {b} = {c}");
            Console.WriteLine($"ket qua phep tru: {a} - {b} = t");
            Console.WriteLine($"Ket qua phep nhan: {a} * {b} = n");
            Console.WriteLine($"Ket qua phep chia: {a}/{b} = ch ");
            Console.WriteLine($"Ket qua phep chia lay du: {a} % {b} = {mo}");
        }
    }
}
