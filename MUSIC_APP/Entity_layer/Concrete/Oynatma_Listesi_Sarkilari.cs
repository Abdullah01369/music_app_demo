using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class Oynatma_Listesi_Sarkilari
    {
        [Key]
        public int Liste_Id { get; set; }
        public int Liste_OL_Id { get; set; }
        public int Liste_Sarki_ID { get; set; }



    }
}
