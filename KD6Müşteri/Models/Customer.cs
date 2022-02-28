using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KD6Müşteri.Models
{

    public class Customer
    {

        //Müşteri Kodu
        [Display(Name="Müşteri Kodu:")]
        [Required(ErrorMessage ="Müşteri Kodunu Girmelisiniz")]
        public int ID { get; set; }
        
        //Müşteri Ünvanı
        [Required(ErrorMessage = "Müşteri Ünvanı Giriniz")]
        [Display(Name ="Müşteri ünvanı")]
        [MaxLength(120)]
        public string Name { get; set; }

        //EPosta Hesabı
        [Display(Name ="EPosta Hesabı")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Girmiş olduğunuz veri EPosta formatına uygun değil")]
        public string EMail { get; set; }
        [Display(Name="Telefon")]
        public Phone Phone { get; set; }

        //İlk Müşteri Olduğu Tarih
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }


        //Müşteri Notu
        [Display(Name="Müşteri Notu")]
        [MaxLength(300)]
        [MinLength(5,ErrorMessage ="Not alanına en az 5 karakter girmelisiniz")]

        //Alternatif
        [StringLength(300,MinimumLength =5)]
        public string Notes { get; set; }
    }
}
