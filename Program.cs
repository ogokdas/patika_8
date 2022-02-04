using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patikaHomework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "";
            string sifre = "";

            Console.Write("Lütfen kullanıcı adınızı giriniz : ");
            kullaniciAdi = Console.ReadLine();

            Console.Write("Lütfen şifrenizi giriniz : ");
            sifre = Console.ReadLine();

            if (kullaniciAdi.ToUpper() == "DEMO" && sifre == "1234")
            {
                Console.WriteLine("Giriş yaptınız tebrikler ");
                
            }
            
            else
            {
                Console.WriteLine("Hatalı kullanıcı girişi");

            }
            Console.ReadLine();
        }
    }
}
