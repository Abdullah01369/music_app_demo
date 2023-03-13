using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Sarkicilar
    {
        [Key]
        public int Sarkici_Id { get; set; }
        public string Sarkici_Ad { get; set; }
        public string Sarkici_Soyad { get; set; }
        public string Sarkici_Unvan { get; set; }
        public bool Sarkici_Aktiflik { get; set; }
        public Guid Sarkici_Kod { get; set; }
        public DateTime Sarkici_Dogum_Yili { get; set; }
        public string Sarkici_Fotograf_Yolu { get; set; }


    }
}
