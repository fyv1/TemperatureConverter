using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TemperatureConverter
{
    class Engine
    {
        public void Converter(User u)
        {
            String T = getType(u); double N = getNumber(u);
            if(T.Equals("C"))
            {
                Console.Write("{0}*C = ", N);
                Console.Write(N * 1.8 + 32); Console.Write("*F\n");
                Console.Write("{0}*C = ", N);
                Console.Write(N + 273.15); Console.Write("*K\n");
            }

            if(T.Equals("F"))
            {
                Console.Write("{0}*F = ", N);
                Console.Write((N-32)/1.8); Console.Write("*C\n");
                Console.Write("{0}*F = ", N);
                Console.Write((N + 459.67) *(5/9)); Console.Write("*K\n");
            }
            if(T.Equals("K"))
            {
                Console.Write("{0}*K = ", N);
                Console.Write(N - 273.15); Console.Write("*C\n");
                Console.Write("{0}*K = ", N);
                Console.Write(N * 1.8 - 459.67); Console.Write("*F\n");
            }
        }
        public String getType(User u)
        {
            String Value = u.getValue();
            String Type = Convert.ToString(Value[Value.Length - 1]);
            return Type;
        }
        public double getNumber(User u)
        {
            String Value = u.getValue();
            double Number = Convert.ToDouble(Value.Remove(Value.Length - 1));
            return Number;
        }
    }
}
