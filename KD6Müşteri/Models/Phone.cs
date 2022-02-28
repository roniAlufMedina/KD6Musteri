using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KD6Müşteri.Models
{
    public enum PhoneTypes { Ev, İş, Cep }

    public class Phone
    {
        [Required(ErrorMessage ="Bu alan Zorunludur.")]
        public int PhoneID { get; set; }
        //Telefon
        public PhoneTypes PhoneType { get; set; }

        [Required(ErrorMessage ="Telefon Numarası girmek zorunludur" )]
        [DataType(DataType.PhoneNumber,ErrorMessage ="telefon için girilen veri uygun değil.")]
        public string PhoneNumber { get; set; }
    }
}
