using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Validation_Rules
{
    public class Sarkilar_Validation : AbstractValidator<Sarkilar>
    {
        public Sarkilar_Validation()
        {
            RuleFor(x => x.Sarki_Ad).NotEmpty().WithMessage("ŞARKI ADI BOŞ GEÇİLEMEZ...");
            RuleFor(x => x.Sarki_Dosya_Yolu).NotEmpty().WithMessage("ŞARKI DOSYA YOLU BOŞ OLAMAZ...");
            RuleFor(x => x.Sarkı_Album_Id).NotEmpty().WithMessage("ALBÜM ID BOŞ OLAMAZ...");
            RuleFor(x => x.Sarki_Sanatci_Id).NotEmpty().WithMessage("SANATÇI ID BOŞ OLAMAZ...");

        }
    }
}
