using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Albumler
    {

        [Key]
        public int Album_Id { get; set; }
        public string Album_Ad { get; set; }
        public DateTime Album_Cikis_Yil { get; set; }
        public int Album_Sanatci_Id { get; set; }
        public Guid Album_Kod { get; set; }
        public bool Album_Aktiflik { get; set; }
    }
}



