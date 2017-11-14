using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int i = 1000;
                //byte b = (byte)i;
                //Console.WriteLine(b);
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception worked");
            }

        }
    }
}
