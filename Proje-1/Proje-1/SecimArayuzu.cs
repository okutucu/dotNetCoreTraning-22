using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_1
{
    public static class SecimArayuzu
    {

        public static void SecimArayuzunuGetir()
        {

            Console.WriteLine(
                "Lütfen yapmak istediğiniz işlemi seçiniz :) :) " +
                "\n ********************************" + 
                "\n(1)-Yeni Numara Eklemek" +
                "\n(2)-Varolan Numarayı Silmek" +
                "\n(3)-Varolan Numarayı Güncellemek" +
                "\n(4)-Rehberi Listelemek" +
                "\n(5)-Rehberde Arama Yapmak" +
                "\n(6)-Çıkış"
                );
        }
    }
}
