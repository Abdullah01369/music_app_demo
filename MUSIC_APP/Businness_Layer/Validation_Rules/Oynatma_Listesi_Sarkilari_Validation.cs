using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Validation_Rules
{
    public class Oynatma_Listesi_Sarkilari_Validation : AbstractValidator<Oynatma_Listesi_Sarkilari>
    {
        public Oynatma_Listesi_Sarkilari_Validation()
        {
            RuleFor(x => x.Liste_OL_Id).NotEmpty().WithMessage("Oynatma liste ID  BOŞ GEÇİLEMEZ...");
            RuleFor(x => x.Liste_Sarki_ID).NotEmpty().WithMessage("ŞARKI ID  BOŞ OLAMAZ...");

        }
    }
}
