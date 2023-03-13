using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Validation_Rules
{
    public class Oynatma_Listeleri_Validation : AbstractValidator<Oynatma_Listeleri>
    {
        public Oynatma_Listeleri_Validation()
        {
            RuleFor(x => x.Oynatma_Liste_Ad).NotEmpty().WithMessage("ADI BOŞ GEÇİLEMEZ...");

        }
    }
}
