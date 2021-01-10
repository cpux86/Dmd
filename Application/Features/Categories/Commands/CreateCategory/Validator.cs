using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Categories.Commands.CreateCategory
{
    public class Validator : AbstractValidator<CreateCategoryCommand>
    {
        public Validator()
        {
            RuleFor(s => s.Title)
                .NotEmpty()
                .MinimumLength(5);
        }
    }
}
