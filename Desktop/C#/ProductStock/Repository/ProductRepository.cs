using DataAccess;
using Entity;
using Entity.Extra;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(Context Context)
            : base(Context)
        {
        }

        public Product GetByCode(string Code)
        {
            var res = from p in Context.Products
                       where p.Active && p.Code == Code
                       orderby p.Name
                       select p;
            return res.FirstOrDefault();
        }

        public IQueryable<Product> GetByName(string Name, int Take)
        {
            var res = (from p in Context.Products
                       where p.Active && (p.Code + p.Name).Contains(Name)
                       orderby p.Name
                       select p).Take(Take);
            return res;
        }

        public IQueryable<ProductRow> FindAllProductRow(bool Active)
        {
            var result = from p in Context.Products
                         where p.Active == Active
                         orderby p.Name
                         select new ProductRow()
                         {
                             Id = p.Id,
                             Active = p.Active,
                             ProductName = p.Name,
                             ProductCode = p.Code,
                             SunatProductCode = p.SunatCode,
                             Perecible = p.Perecible,
                             MinStock = p.MinStock,
                             NominalValue = p.NominalValue,
                             AddOnElectronicDocument = p.AddOnElectronicDocument
                         };
            return result;
        }

        public override List<Product> FindDuplicate(Product Product)
        {
            var res = from p in Context.Products
                      where (p.Name == Product.Name ||
                      p.Code == Product.Code) &&
                      p.Id != Product.Id
                      select p;
            return res.ToList();
        }
    }
}
