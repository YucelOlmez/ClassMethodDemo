using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class customerManager
    {
        public void customerList(Musteri cList)
        {
            Console.WriteLine("Kredi Müşterisi Eklendi !"+cList.tc+":"+cList.adi+" "+cList.soyadi+" "+cList.yas);
        }

        public void customerDelete(Musteri cDelete) 
        {
          
        }


    }
 }
