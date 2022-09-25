using Core.DataAccess.EntityFramework;
using GenericObjectMapper.DataAccess.Abstract;
using GenericObjectMapper.Entities.Concrete; 

namespace GenericObjectMapper.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindDbContext>, ICategoryDal
    { 
    }
}
