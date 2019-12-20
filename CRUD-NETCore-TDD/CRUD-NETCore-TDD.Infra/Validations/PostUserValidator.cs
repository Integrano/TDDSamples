using CRUD_NETCore_TDD.Infra.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_NETCore_TDD.Infra.Validations
{
    public class PostUserValidator: AbstractValidator<User>
    {
        public PostUserValidator()
        {
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithErrorCode("100")
                .MaximumLength(20)
                .WithErrorCode("101");
        }
    }
}
