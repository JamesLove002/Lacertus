using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LArchitecture.Definitions
{
    class Definitions
    {
        public struct Seasons
        {
            enum Season : byte
            {
                Summer = 1, December = Summer, January = Summer, Febuary = Summer,
                Autumn = 2, March = Autumn, April = Autumn, May = Autumn, Fall = Autumn,
                Winter = 3, June = Winter, July = Winter, August = Winter,
                Spring = 4, September = Spring, October = Spring, November = Spring
            }
            enum Month : byte
            {
                January = 1,
                Febuary = 2,
                March = 3,
                April = 4,
                May = 5,
                June = 6,
                July = 7,
                August = 8,
                September = 9,
                October = 10,
                November = 11,
                December = 12
            }
        }
    }
}
