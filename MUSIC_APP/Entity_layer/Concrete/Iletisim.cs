using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Iletisim
    {
        [Key]
        public int Iletisim_Id { get; set; }

        public string Iletisim_Tel { get; set; }

        public string Iletisim_Adres { get; set; }

        public string Iletisim_Mail { get; set; }

    }
}
