using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region if else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if(password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            string capital,country;
            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();

            if(capital=="Ankara" && country=="Türkiye")
            {
                Console.WriteLine("Veriler Doğru");
            }
            else
            {
                Console.WriteLine("Veriler Yanlış");
            }

            Console.Read();
            #endregion
        }
    }
}
