using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_of_programing_PhamVanKhue
{
    internal class Session_3
    {
        public static void Question_02()
        {
            Console.WriteLine("Tinh toan ket qua ham sau: x = y^2 + 2y + 1 ");
            for (int y = -5; y <= 5; y++) 
              {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"For y = {y}; x = {x}"); }
        }
        public static void Question_03()
        {
            Console.Write("Enter the distance (in km): ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time (hours): ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time (minutes): ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time (seconds): ");
            double s = Convert.ToDouble(Console.ReadLine());
            double totaltime = h + m / 60 + s / 3600;
            double speedkmh = km / totaltime;
            double speedmh = speedkmh / 0.621371;
            Console.WriteLine($" Result v(km/h): {speedkmh}");
            Console.WriteLine($" Result v(mile/h): {speedmh}");
        }
        public static void Question_04()
        {
            Console.Write("Enter one character: ");
            char letter = Convert.ToChar(Console.ReadLine());
            // check if the entered symbol is the vowel 
            char symbol = char.ToLower(letter);
            if ((symbol == 'u') || (symbol == 'e') || (symbol == 'o') || (symbol == 'a') || (symbol == 'i'))
            { Console.WriteLine($" {letter} is a vowel "); }
            // check if the entered symbol í a digit, using asscii 
            else if ((symbol >= '0') && (symbol <= '9')) { Console.WriteLine(" The entered symbol is a digit"); }
            else { Console.WriteLine(" That is another symbol"); }
        }
        
    }
}
