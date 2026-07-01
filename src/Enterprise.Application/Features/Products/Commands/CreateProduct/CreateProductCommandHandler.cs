using Enterprise.Application.Interfaces.Repositories;
using Enterprise.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler: IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _repository;

        public CreateProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price);

            await _repository.AddAsync(product);

            return product.Id;
        }
    }
}
