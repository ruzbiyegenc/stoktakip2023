using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<UserTable>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Email field cannot be empty.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field cannot be empty.");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Please enter at least 6 characters.");
            RuleFor(x => x.Password).MaximumLength(12).WithMessage("Please enter data of up to 12 characters.");
        }

    }
}
