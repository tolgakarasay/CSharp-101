using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;
            sbyte c = 5;

            short s = 5;
            ushort us = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 2;
            long l = 4;
            ulong ul = 4;

            //Reel sayılar
            float f = 5;
            double d = 5;
            decimal de = 5;

            char ch = '2';
            string str = "Tolga";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = "4";
            object o4 = "4.3";

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Ad";
            string str2 = "Soyad";
            string tamIsim = str1 + " " + str2;

            // integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            // boolean
            bool bool1 = 10 > 2;

            // Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();

            Console.WriteLine(yeniDeger);

            int yeniDeger2 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(yeniDeger2);


            int yeniDeger3 = int20 + Int32.Parse(str20);
            Console.WriteLine(yeniDeger3);

            // datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            // saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}