using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Kullanicilar
    {
        [Key]
        public int Kullanici_Id { get; set; }
        public string Kullanıcı_Ad { get; set; }
        public string Kullanıcı_Soyad { get; set; }
        public Guid Kullanıcı_Kod { get; set; }
        public bool Kullanıcı_Aktiflik { get; set; }
        public DateTime Kullanıcı_Dogum_Yil { get; set; }
        public string Kullanıcı_Mail { get; set; }
        public string Kullanıcı_Sifre { get; set; }



    }
}
