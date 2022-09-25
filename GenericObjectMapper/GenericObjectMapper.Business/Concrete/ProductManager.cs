
using Core.Utilities.Results;
using Core.Utilities.Results.Success;
using GenericObjectMapper.Business.Abstract;
using GenericObjectMapper.DataAccess.Abstract;
using GenericObjectMapper.Entities.Concrete;
using GenericObjectMapper.Entities.DTOs;

namespace GenericObjectMapper.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<Product> GetProductDetail(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<ProductDetailDTO>> GetProductDetailList()
        {
            return new SuccessDataResult<List<ProductDetailDTO>>(_productDal.GetProductDetailList());
        }
    }
}
