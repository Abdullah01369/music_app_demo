using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class About
    {
        [Key]
        public int Anasayfa_Bilgi_Id { get; set; }
        public string Anasayfa_Bilgi_Icerik_About_Uzun { get; set; }
        public string Anasayfa_Bilgi_Icerik_About { get; set; }
        public string Anasayfa_Bilgi_Icerik_Sarkilar { get; set; }
        public string Anasayfa_Bilgi_Icerik_Albumler { get; set; }
        

        
        public string Anasayfa_Bilgi_Resim1_Adres { get; set; }
        public string Anasayfa_Bilgi_Resim2_Adres { get; set; }
        public string Anasayfa_Bilgi_Resim3_Adres { get; set; }
        public string Anasayfa_Bilgi_Resim4_Adres { get; set; }

    }
}
