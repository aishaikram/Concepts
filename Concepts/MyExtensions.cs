using System;
using System.Collections.Generic;
using System.Text;

namespace Concepts
{
    public static class MyExtensions
    {

        //extension method for type string to convert it to double
        public static double ToDouble(this string data)
        {
            return double.Parse(data);
        }
    }
}
