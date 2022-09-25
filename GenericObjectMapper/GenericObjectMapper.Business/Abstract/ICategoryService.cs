using Core.Utilities.Results;
using GenericObjectMapper.Entities.Concrete;
using GenericObjectMapper.Entities.DTOs;

namespace GenericObjectMapper.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<CategoryDTO> GetById(int categoryId);
        IDataResult<List<Category>> GetAll();  
    }
}
