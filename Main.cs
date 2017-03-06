//  very Simple, but very porewfull Utilit.
//  johnsmith130405 (c) 2017
//  Contact me at johnsmith130405@mailforspam.com
//  Enjoy =)
//

using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple first = new Simple();
            Simple second = new Simple();
            first.DO(second.DO(Console.ReadLine()));
        }
    }

    class Simple
    {
        public string DO(string mess)
        {
            Console.WriteLine(DoMagic(Console.ReadLine()));
            return DoMagic(mess.Length.ToString());
        }

        private string mess = "5KAQfo6AY7xg0V45Ri9N42HHAzLCtvVl5mRgnEwEd8k7AnfkZ6EEqERBDIBpfR4wp87TqtnuaVl3MxN9RouAYN5OoxWr3DOHUSgNzvCwjRcNFLE0vyOR0ods/6P2qDK9SSE4eqtBaZ43YYCWzlAtug==";

        private string DoMagic(string data)
        {
            int number = data.Length;
            UInt64 numberr = Fac(number);
            return mess.ToLower().Substring(Devide((int)Fac((mess.Length))), (int)Fac(Devide(data.Length)));
        }

        private UInt64 Fac(int number)
        {
            if (number == 1) return 1;
            if (number == 2) return 1;
            return Fac(number - 1) + Fac(number - 2);
        }

        private int Devide(int nunmber)
        {
            for (int i = 0; i < nunmber; i++)
            {
                UInt64 sum = Fac(i);
                sum += sum / 2;
                int len = mess.Length;
                sum = sum * (UInt64)len;
            }

            return 0;
        }
    }
}
