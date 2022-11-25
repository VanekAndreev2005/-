using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            /*метод ParseExact()
             string a = "2022-11-25 15:25";
             DateTime oDate = DateTime.ParseExact(a, "yyyy-MM-dd HH:mm tt", null);
             Console.WriteLine(oDate.ToString());
             Console.ReadLine();*/

            /*метод Parse()
            string a = "2022-11-25";
            string b = DateTime.Parse(a).ToShortDateString();
            Console.WriteLine(b);
            Console.ReadLine();*/

            /*метод TryParse
            string a = "25/11/2022";
            DateTime dateTime;
            Console.WriteLine(DateTime.TryParse(a, out dateTime));
            Console.ReadLine();*/

            /*метод TryParseExact()
              string a = "Mon 16 Jun 8:30 AM 2008";
            string b = "ddd dd MMM h:mm tt yyyy";
            DateTime dateTime;
            if (DateTime.TryParseExact(a, b, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime))
            {
                Console.WriteLine(dateTime);
            }
            Console.ReadLine();
             */
                
        }
    }
}
