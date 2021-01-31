using Application.Features.Categories.Commands.CreateCategory;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
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

            RuleFor(s => s.Parent)
                .InclusiveBetween(1, Int32.MaxValue).WithMessage("Не верный запрос");
        }
    }

}
