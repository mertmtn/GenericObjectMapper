
using Core.Utilities.Results;
using Core.Utilities.Results.Success;
using GenericObjectMapper.Business.Abstract;
using GenericObjectMapper.Core.Entities;
using GenericObjectMapper.DataAccess.Abstract;
using GenericObjectMapper.Entities.Concrete;
using GenericObjectMapper.Entities.DTOs;

namespace GenericObjectMapper.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public IDataResult<ProductDTO> GetProductDetail(int productId)
        {
            return new SuccessDataResult<ProductDTO>(_mapper.Map<Product,ProductDTO>(_productDal.Get(p => p.ProductId == productId)));
        }

        public IDataResult<List<ProductDetailDTO>> GetProductDetailList()
        {
            return new SuccessDataResult<List<ProductDetailDTO>>(_productDal.GetProductDetailList());
        }
    }
}
