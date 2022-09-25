using Core.Utilities.Results;
using GenericObjectMapper.Entities.Concrete;
using GenericObjectMapper.Entities.DTOs;
namespace GenericObjectMapper.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<ProductDTO> GetProductDetail(int productId);
        IDataResult<List<ProductDetailDTO>> GetProductDetailList(); 
    }
}
