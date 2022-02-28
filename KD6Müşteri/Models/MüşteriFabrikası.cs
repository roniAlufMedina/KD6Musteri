using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KD6Müşteri.Models
{
    public class MüşteriFabrikası
    {
        private static MüşteriFabrikası _müşteriFabrikası;

        public List<Customer> MüşteriListesi { get; set; }

        public static MüşteriFabrikası Fabrika 
        {
            get 
            {
                if (_müşteriFabrikası == null)
                    _müşteriFabrikası = new MüşteriFabrikası();
                return _müşteriFabrikası;            
            }  
        
        }

        private MüşteriFabrikası()
        {
            MüşteriListesi = new List<Customer>();
            MüşteriListesi.Add(
                    new Customer()
                    {
                        ID = 1,
                        Name = "Tahincioğlu Ltd.",
                        EMail = "tahinci@hotmail.com",
                        Notes = "Şirketimiz Manisadadır",
                        CreatedDate=DateTime.Now,
                        Phone=new Phone() {PhoneID=1,PhoneType=PhoneTypes.İş,PhoneNumber="04588957878" }
                    }
                    ) ;

        }
    }
}
