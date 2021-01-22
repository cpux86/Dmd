using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class CreateValidator : AbstractValidator<CreateCategoryRequest>
    {
        public CreateValidator()
        {
            RuleFor(s => s.Title)
                .NotEmpty()
                .MinimumLength(5);
        }
    }
}
