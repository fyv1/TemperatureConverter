using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Engine e = new Engine();

            user.setValue(Console.ReadLine());
            e.Converter(user);

            Console.ReadKey();
        }
    }
}
