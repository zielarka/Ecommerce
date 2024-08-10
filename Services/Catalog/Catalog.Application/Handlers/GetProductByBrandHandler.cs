using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetProductByBrandHandler : IRequestHandler<GetProductByBrandQuery, IList<ProductResponse>>
    {
        public IProductRepository _productRepository;
        public GetProductByBrandHandler(IProductRepository productRepository)
        {
            productRepository = _productRepository;
        }
        public async Task<IList<ProductResponse>> Handle(GetProductByBrandQuery request, CancellationToken cancellationToken)
        {
            var brandList = await _productRepository.GetProductsByBrand(request.BrandName);
            var brandResponseList = ProductMapper.Mapper.Map<IList<ProductResponse>>(brandList);
            return brandResponseList;
        }
    }
}
