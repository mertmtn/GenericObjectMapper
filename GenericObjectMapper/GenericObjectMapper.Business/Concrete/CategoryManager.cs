using Core.Utilities.Results;
using GenericObjectMapper.Business.Abstract;
using GenericObjectMapper.Entities.Concrete;

namespace GenericObjectMapper.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            return _categoryService.GetAll();
        }

        IDataResult<Category> ICategoryService.GetById(int categoryId)
        {
            return _categoryService.GetById(categoryId);
        }
    }
}
