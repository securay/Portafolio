using DataAccess;
using Entity;
using Entity.Extra;
using System.Data.SqlClient;
using System.Linq;

namespace Repository
{
    public class ComponentRepository : BaseRepository<Component>
    {
        public ComponentRepository(Context Context)
            : base(Context)
        {
        }

        public IQueryable<ComponentRow> GetByStoredProductAndName(StoredProduct StoredProduct, string Name)
        {
            var res = from sp in Context.Components
                      where sp.Active && 
                      sp.StoredProduct.Id == StoredProduct.Id &&
                      sp.Product.Active && 
                      (sp.Product.Code + sp.Product.Name).Contains(Name)
                      select new ComponentRow()
                      {
                          Id = sp.Id,
                          Active = sp.Active,
                          Buyed = sp.Buyed,
                          Stock = sp.Stock,
                          ProductName = sp.Product.Name,
                          SerialNumber = sp.SerialNumber
                      };
            return res;
        }
    }
}
