using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Validation_Rules
{
    public class Sarkici_Validation : AbstractValidator<Sarkicilar>
    {
        public Sarkici_Validation()
        {
            RuleFor(x => x.Sarkici_Ad).NotEmpty().WithMessage("ŞARKICI ADI BOŞ GEÇİLEMEZ...");
            RuleFor(x => x.Sarkici_Soyad).NotEmpty().WithMessage("ŞARKICI SOYAD  BOŞ OLAMAZ...");
            RuleFor(x => x.Sarkici_Dogum_Yili).NotEmpty().WithMessage("DOĞUM YILI BOŞ OLAMAZ...");
            RuleFor(x => x.Sarkici_Fotograf_Yolu).NotEmpty().WithMessage("FOTOGRAF YOLU BOŞ OLAMAZ...");
        }
    }
}
