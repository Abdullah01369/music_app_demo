using Entity_Layer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness_Layer.Validation_Rules
{
    public class Kullanici_Validation : AbstractValidator<Kullanicilar>
    {
        public Kullanici_Validation()
        {

            RuleFor(x => x.Kullanıcı_Ad).NotEmpty().WithMessage("ADI BOŞ GEÇİLEMEZ...");
            RuleFor(x => x.Kullanıcı_Soyad).NotEmpty().WithMessage("SOYAD BOŞ OLAMAZ...");
            RuleFor(x => x.Kullanıcı_Mail).NotEmpty().WithMessage("MAIL BOŞ OLAMAZ...");
            RuleFor(x => x.Kullanıcı_Sifre).NotEmpty().WithMessage("ŞİFRE BOŞ OLAMAZ...");
            RuleFor(x => x.Kullanıcı_Dogum_Yil).NotEmpty().WithMessage("DOGUM YILI BOŞ OLAMAZ...");
        }
    }
}
