using System;

namespace karar_yapilari_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız.");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız.");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız.");
                    break;
                case 5:
                    Console.WriteLine("Mayıs ayındasınız.");
                    break;
                case 6:
                    Console.WriteLine("Haziran ayındasınız.");
                    break;
                case 7:
                    Console.WriteLine("Temmuz ayındasınız.");
                    break;
                case 8:
                    Console.WriteLine("Ağustos ayındasınız.");
                    break;
                case 9:
                    Console.WriteLine("Eylül ayındasınız.");
                    break;
                case 10:
                    Console.WriteLine("Ekim ayındasınız.");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayındasınız.");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındasınız.");
                    break;
                
                
                default:
                    Console.WriteLine("Yalnış giriş yaptınız.");
                break;
            }

            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Kış aylarındasınız.");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("İlkbahar aylarındasınız.");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Yaz aylarındasınız.");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Sonbahar aylarındasınız.");
                    break;
                default:
                    Console.WriteLine("Yalnış giriş yaptınız.");
                break;
            }
        }
    }
}

