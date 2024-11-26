using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_9
    {
        public static void Main9()
        {
            int count = 0;
            //1.To input a string and print it
            Console.Write("Nhap vao ban phim mot cau: ");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1);
            //2.Find the length of a string
            for (int i = 0; i < s1.Length; i++)
            {
                count += 1;
            }
            Console.WriteLine($"Do dai cua chuoi ky tu la: {count}");
            //3.Separate individual characters from a string
            foreach (char c in s1)
            {
                Console.WriteLine(c);
            }
            //4.to print individual characters of the string in reverse order
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s1[i]);
            }
            //5.to count the total number of words in a string 
            int dem = 0;
            //bo khoang trang thua co o dau va cuoi chuoi
            s1 = s1.Trim();
            while (s1.IndexOf(" ") != -1)
            {

            }
        }
        static int CountWords(string s1)
        {
                int count = 0;
                //bo khoang trang thua co trong chuoi
                s1 = s1.Trim();//bo khoang trang dau va cuoi chuoi
                while(s1.IndexOf(" ") != -1)
                {
                    s1 = s1.Replace("  ", " ");
                }
                return count;
        }
    }
}
