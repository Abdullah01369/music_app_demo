using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Sarkilar
    {
        [Key]
        public int Sarki_Id { get; set; }
        public string Sarki_Ad { get; set; }
        public int Sarkı_Album_Id { get; set; }
        public int Sarki_Dinlenme_Sayi { get; set; }
        public int Sarki_Sanatci_Id { get; set; }
        public DateTime Sarki_Cikis_Yılı { get; set; }
        public bool Sarki_Aktiflik { get; set; }
        public Guid Sarki_Kod { get; set; }
        public string Sarki_Dosya_Yolu { get; set; }
    }
}
