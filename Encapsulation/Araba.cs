using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    // Araba sınıfı oluştu
    public class Araba
    {
        // Brand özelliği: Arabanın markası
        public string Brand {  get; set; }

        // Model özelliği: Arabanın modeli
        public string Model { get; set; }


        // Color özelliği: Arabanın rengi
        public string Color { get; set; }

        // Kapı sayısı için kapsülleme kullandığım alan
        int _doorCount;
        
        // DoorCount özelliği: dışarıdan erişilen kapsüllenmiş property
        public int DoorCount  {

            get
            {
                // Kapı sayısı dışarıdan okunduğunda bu blok çalışır
                return _doorCount;

            }
            set
            {
                // Eğer 2 veya 4 girilirse değer kabul edilir
             if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }
             else
                {
                    // 2 veya 4 dışında bir sayı girildiğinde kullanıcıyı uyarır ve değeri -1 olarak atar
                    Console.WriteLine("Kapı sayısı 2 veya 4 dışında bir değer alamaz, hatalı giriş yaptınız. Kapı değeri -1 olarak güncellendi.");
                    _doorCount = -1;
                }
            }
        }
    }
}
