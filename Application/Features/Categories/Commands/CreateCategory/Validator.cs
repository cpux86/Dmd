using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Categories.Commands.CreateCategory
{
    public class Validator : AbstractValidator<CreateCategoryDTO>
    {
        public Validator()
        {
            RuleFor(s => s.Title)
                .NotEmpty()
                .MinimumLength(5);

            //RuleFor(s => s.ParentId)
            //    .NotNull().When(s => s.ParentId != 2);


        }
    }
}
