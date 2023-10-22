using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;

namespace EasyCashIdentityProject.BusinnesLayer.ValidationRules.AppUserValidationRules
{
	public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
	{
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez..");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez..");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez..");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez..");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez..");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Doğrulanacak Şifre alanı boş geçilemez..");

			RuleFor(x => x.Name).MaximumLength(30).WithMessage("Ad alanına 30 karakterden fazla veri girişi yapmayınız..");
			RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ad alanına 3 karakterden az veri girişi yapmayınız..");

            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalarınız birbirine eşleşmedi..");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir mail adresi giriniz..");
		}
    }
}
