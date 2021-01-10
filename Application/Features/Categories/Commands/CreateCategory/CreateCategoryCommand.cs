using MediatR;
using Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Dmd.Domain.Interfaces.Repository;
using AutoMapper;
using Dmd.Domain.Entities;

namespace Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<Response<int>>
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
    }

    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Response<int>>
    {
        private readonly ICategoryRepositoryAsync _categoryRepo;
        private readonly IMapper _mapper;

        public CreateCategoryHandler(ICategoryRepositoryAsync categoryRepo, IMapper mapper)
        {
            _mapper = mapper;
            _categoryRepo = categoryRepo;
        }

        public async Task<Response<int>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            await _categoryRepo.AddAsync(category);
            return new Response<int>(category.Id, "done");
        }
    }
}
