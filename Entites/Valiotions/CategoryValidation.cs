using Entites.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Valiotions
{
    public class CategoryValidation: AbstractValidator<CategoryDto>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("لطفا نام را وارد کنید");
            RuleFor(x => x.Name).NotNull().WithMessage("لطفا قالب نام را صحیح وارد کنید");
            //RuleFor(x => x.Name).Must((model, cancellation) =>
            //{
            //    if (model.Name.Length != 10)
            //    {
            //        return false;
            //    }

            //    return true;
            //}).WithMessage("باید 10 کارکتر باشد");

        }
        

    }
}
