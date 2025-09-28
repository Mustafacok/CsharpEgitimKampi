using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degişkenler
            ////double number;
            ////number = 3.14;
            ////Console.WriteLine(number);
            ////Console.ReadLine();


            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();

            //double applePrice,orangePrice,strawberyPrice,potatoPrice,tomatoPrice;

            //applePrice = 15.99;
            //orangePrice = 20.99;
            //strawberyPrice = 45.99;
            //potatoPrice = 10.99;
            //tomatoPrice = 5.99;

            //Console.WriteLine("Elma Birim Fiyatı : " + applePrice+ " TL");
            //Console.WriteLine("Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("Çilek Birim Fiyatı : " + strawberyPrice + " TL");
            //Console.WriteLine("Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("Domates Birim Fiyatı : " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram,orangeGram, strawberyGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.500;
            //strawberyGram = 0.750;
            //potatoGram = 3.455;
            //tomatoGram = 1.750;

            //double appleTotalPrice=appleGram*applePrice;
            //double orangeTotalPrice=orangeGram*orangePrice;
            //double strawberyTotalPrice=strawberyGram*strawberyPrice;
            //double potatoTotalPrice=potatoGram*potatoPrice;
            //double tomatoTotalPrice=tomatoGram*tomatoPrice;


            ////Console.WriteLine("Elmanın Toplam Fiyatı : " + appleTotalPrice + " TL");
            ////Console.WriteLine("Portakalın Toplam Fiyatı : " + orangeTotalPrice + " TL");
            ////Console.WriteLine("Çileğin Toplam Fiyatı : " + strawberyTotalPrice + " TL");
            ////Console.WriteLine("Patatesin Toplam Fiyatı : " + potatoTotalPrice + " TL");
            ////Console.WriteLine("Domatesin Toplam Fiyatı : " + tomatoTotalPrice + " TL");

            //Console.WriteLine("Alınan Ürün: Elma - "+"Birim fiyat: "+applePrice+" - Gramaj: "+ appleGram+ " - Toplam tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim fiyat: " + strawberyPrice + " - Gramaj: " + strawberyGram + " - Toplam tutar: " + strawberyTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam tutar: " + tomatoTotalPrice);

            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberyTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();

            //Console.WriteLine("*** Toplam Alınan Ürünlerin Tutarı:" + totalPrice + " TL");



            //Console.Read();
            #endregion

            #region Char Değişkenler
            //char character = 'A';
            //Console.WriteLine(character);

            //char symbol = 'a';

            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişi String Değişkenler

            Console.WriteLine("*** Csharp Hava Yolları Yolcu Bilgisi ***");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity,passengerAge,passengerIdentityNumber;

            Console.Write("Yolcu Adı : ");
            passengerName= Console.ReadLine();

            Console.Write("Yolcu Soyadı : ");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu İlçe : ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcu İl : ");
            passengerCity = Console.ReadLine();
            
            Console.Write("Yolcu Yaş : ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No : ");
            passengerIdentityNumber = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("Yolcu: " + passengerName+" "+ passengerSurname);
            Console.WriteLine("Yolcu İlçesi - İli: " + passengerDistrict+" "+ passengerCity);
            Console.WriteLine("Yolcu Yaşı - TC Kimlik Numarası:" + passengerAge+" "+ passengerIdentityNumber);


            #endregion

            Console.Read();
        }
    }
}
