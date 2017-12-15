using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TemperatureConverter
{
    class User
    {
        private String Value;
        
        public void setValue(String Value)
        {
            this.Value = Value;
        }

        public String getValue()
        {
            return this.Value;
        }
    }
}
