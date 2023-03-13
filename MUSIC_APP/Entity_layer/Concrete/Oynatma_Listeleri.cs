using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Oynatma_Listeleri
    {
        [Key]
        public int Oynatma_Liste_Id { get; set; }
        public string Oynatma_Liste_Ad { get; set; }
        public DateTime Oynatma_Liste_Tarih { get; set; }
        public bool Oynatma_Liste_Aktiflik { get; set; }
        public Guid Oynatma_Liste_Kod { get; set; }
        public int Oynatma_Liste_Beğenme_Kullanici_ID { get; set; }

    }
}
