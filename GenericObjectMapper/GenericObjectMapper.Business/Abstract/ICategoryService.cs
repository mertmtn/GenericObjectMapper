using Core.Utilities.Results;
using GenericObjectMapper.Entities.Concrete;

namespace GenericObjectMapper.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryId);
        IDataResult<List<Category>> GetAll();  
    }
}
