using System.Collections.Generic;
using Market.Business.Abstract;
using Market.DataAccess.Abstract;
using Market.Entity.Concrete;

namespace Market.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
