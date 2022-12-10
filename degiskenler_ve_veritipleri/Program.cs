using System;

namespace degiskenler_ve_veritipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("");

            byte b = 5;//0-255 arası deger alır.1 byte yer kaplar
            sbyte c = 5;//-128 le 127 arasında deger alabilir.1 byte yer kaplar

            short s = 5;//bellekte 2 byte -32768 +32768 deger alabilir
            ushort us = 5;//bellekte 2 byte yer kaplar 0-65365 arasındaki degerleri alabilir.
            Int16 i16 = 2; //bellekte 2 byte yer kaplar 
            int i = 2;//bellekte 4 byte yer kaplar
            Int32 i32 = 2;//bellekte 4 byte yer kaplar
            Int64 i64 = 2;//bellekte 8 byte yer kaplar

            uint ui=2;//bellekte 4 byte yer kaplar
            long l=4;//bellekte 8 byte yer kaplar.
            ulong ul=4;//8 byte longtan farkı - deger alamaz
            
            //reel sayılar için kullanılır.
            float f=5;//bellekte 4 byte yer kaplar.
            double d=5;//bellkete 8 byte yer kaplar.
            decimal de=5;// bellekte 16 byte yer kaplar.

            char ch ='a';//bellekte 2 byte yer kaplar
            string str="cem";//sınırsız

            bool b1=true;
            bool b2=false;

            DateTime dt=DateTime.Now;//anlık tarih saat 
            Console.WriteLine(dt);

            object o1 = "x";//string
            object o2 = "y";//char
            object o3 = 4;//int
            object o4 = 4.3;//decimal

            //string ifadeler
            string str1 = string.Empty;
            str1 = "cem Kunduz";
            string ad="Cem";
            string soyad="Kunduz";
            string tamisim= ad + " " + soyad;

            //integer tanımlama şekilleri
            int integer1 =5;
            int integer2=3;
            int integer3=integer1*integer2;

            //Boolean

            bool bool1=10>2;
            
            //degisken dönüsümleri
            string str20="20";
            int int20=20;
            
            string yeniDeger=str20+int20.ToString();
            Console.WriteLine(yeniDeger);
            
            //int dönüşümleri
            int int21=int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);
            
            //farklı bir Parse dönüşümü(stringten dönüşüm)
            int int22=int20+int.Parse(str20);

            //datetime

            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);
            
            //saat
            string hour=DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
