
using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Validation_Rules
{
    public class Albumler_Validation : AbstractValidator<Albumler>
    {
        public Albumler_Validation()
        {
            RuleFor(x => x.Album_Ad).NotEmpty().WithMessage("ALBÜM ADI SOYADI BOŞ GEÇİLEMEZ...");
            RuleFor(x => x.Album_Sanatci_Id).NotEmpty().WithMessage("SANATCI ID BOŞ OLAMAZ...");
           // RuleFor(x => x.Album_Cikis_Yil).NotEmpty().WithMessage("ÇIKIŞ YILI BOŞ OLAMAZ...");
            


        }
    }
}
