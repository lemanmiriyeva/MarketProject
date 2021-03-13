using Core.DataAccess.Abstract;
using Market.Entity.Concrete;

namespace Market.DataAccess.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
   {
   }
}
