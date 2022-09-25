using Core.Utilities.Results;
using Core.Utilities.Results.Success;
using GenericObjectMapper.Business.Abstract;
using GenericObjectMapper.Core.Entities;
using GenericObjectMapper.DataAccess.Abstract;
using GenericObjectMapper.Entities.Concrete;
using GenericObjectMapper.Entities.DTOs;

namespace GenericObjectMapper.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        private IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        IDataResult<CategoryDTO> ICategoryService.GetById(int categoryId)
        {
            return new SuccessDataResult<CategoryDTO>(_mapper.Map<Category, CategoryDTO>(_categoryDal.Get(c => c.CategoryId == categoryId)));
        }
    }
}
