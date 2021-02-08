using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<ProductDetailDto> GetProductDetails();
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
