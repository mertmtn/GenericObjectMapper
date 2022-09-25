using Core.DataAccess.EntityFramework;
using GenericObjectMapper.DataAccess.Abstract;
using GenericObjectMapper.Entities.Concrete;
using GenericObjectMapper.Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace GenericObjectMapper.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindDbContext>, IProductDal
    {
        public List<ProductDetailDTO> GetProductDetailList()
        {
            using var context = new NorthwindDbContext();
            //context.Database.EnsureCreated();
            var result = from c in context.Products

                         join b in context.Categories on c.CategoryId equals b.CategoryId
                         select new ProductDetailDTO
                         {
                             ProductName = c.ProductName, 
                             Price = c.UnitPrice,
                             CategoryName = b.CategoryName 
                         };

            return result.ToList();
        }
    }
}
