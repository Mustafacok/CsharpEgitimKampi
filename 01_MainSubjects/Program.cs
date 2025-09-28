using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları   
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Merhaba");

            //Console.WriteLine("*** Yemek Kategorileri ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*** Yemek Kategorileri ***");
            #endregion

            #region StringDegiskenler

            ////string 
            ////degisken_türü degisken_Adi

            ////string name;

            ////name = "Mustafa";
            ////Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Mustafa";
            //customerSurname = "Çok";
            //customerPhone = "+90 531 649 4745";
            //customerEmail = "mustafacok06@gmail.com";
            //district = "Çankaya";
            //city = "Ankara";

            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: "+ customerName+" "+customerSurname );
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("Email Adresi: "+customerEmail);
            //Console.WriteLine("Adres: "+district+ "/"+city);
            //Console.WriteLine("-----------------------------------");

            //customerName = "Merve";
            //customerSurname = "Çok";
            //customerPhone = "+90 531 649 4745";
            //customerEmail = "test@gmail.com";
            //district = "Çankaya";
            //city = "Ankara";

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");
            #endregion

            #region Int Degıskenler

            //int
            //int number = 45;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 30;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 20;

            Console.WriteLine("*** Restoran menü fiyatı ***");
            Console.WriteLine();
            Console.WriteLine("--- Hamburger: "+hamburgerPrice+" TL");
            Console.WriteLine("--- Pizza: "+pizzaPrice+" TL");
            Console.WriteLine("--- Kola: "+cokePrice+" TL");
            Console.WriteLine("--- Limonata: "+lemonadePrice+" TL");
            Console.WriteLine("--- Kızartma: "+friesPrice+" TL");
            Console.WriteLine("--- Su: "+waterPrice+" TL");
            Console.WriteLine();
            Console.WriteLine("*** Restoran menü fiyatı ***");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 3;

            totalHamburgerPrice=hamburgerCount*hamburgerPrice;
            totalLemonadePrice=lemonadeCount*lemonadePrice;
            totalPizzaPrice=pizzaCount*pizzaPrice;
            totalWaterPrice=waterCount*waterPrice;
            totalFriesPrice=friesCount*friesPrice;
            totalCokePrice=cokeCount*cokePrice;


            Console.WriteLine("----------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            
            Console.WriteLine();

            int totalPrice = totalCokePrice + totalFriesPrice + totalLemonadePrice + totalHamburgerPrice + totalPizzaPrice+totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");


            
            
            #endregion






            Console.Read();
        }
    }
}
