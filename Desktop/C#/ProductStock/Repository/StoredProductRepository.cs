using DataAccess;
using Entity;
using Entity.Extra;
using System.Data.SqlClient;
using System.Linq;

namespace Repository
{
    public class StoredProductRepository : BaseRepository<StoredProduct>
    {
        public StoredProductRepository(Context Context)
            : base(Context)
        {
        }

        public StoredProduct GetBySerial(string SerialNumber)
        {
            var res = from sp in Context.StoredProducts
                      where sp.Active &&
                      sp.SerialNumber == SerialNumber
                      select sp;

            return res.FirstOrDefault();
        }

        public IQueryable<StoredProductRow> GetByStoreAndName(Store Store, string Name)
        {
            var res = from sp in Context.StoredProducts
                      where sp.Active && sp.CurrentProduct &&
                      sp.StoreId == Store.Id &&
                      sp.Product.Active && 
                      (sp.Product.Code + sp.Product.Name).Contains(Name)
                      select new StoredProductRow()
                      {
                          Active = sp.Active,
                          Buyed = sp.Buyed,
                          CurrentProduct = sp.CurrentProduct,
                          Id = sp.Id,
                          ProductName = sp.Product.Name,
                          SerialNumber = sp.SerialNumber,
                          Stock = sp.Stock,
                          Store = sp.Store.Name
                      };
            return res;
        }
        
        public void CheckCurrent(StoredProduct StoredProduct)
        {
            var query = from sp in Context.StoredProducts
                        where sp.Active &&
                        sp.ProductId == StoredProduct.ProductId &&
                        sp.StoreId == StoredProduct.StoreId &&
                        sp.CurrentProduct
                        select sp;
            if (query.Count() == 0)
            {
                SetAsCurrentProduct(StoredProduct);
            }
        }

        public void SetNextCurrent(StoredProduct StoredProduct)
        {
            var res = from sp in Context.StoredProducts
                      where sp.Active &&
                      sp.ProductId == StoredProduct.ProductId &&
                      sp.StoreId == StoredProduct.StoreId &&
                      sp.Stock > 0 &&
                      !sp.CurrentProduct
                      orderby sp.DateInsert
                      select sp;
            StoredProduct spr = res.FirstOrDefault();
            if (spr != null)
            {
                CheckCurrent(spr);
            }
        }

        public void SetAsCurrentProduct(StoredProduct StoredProduct)
        {
            Context.Database.ExecuteSqlCommand("UPDATE StoredProduct SET CurrentProduct = 0 WHERE ProductId = @product_id AND StoreId = @store_id",
                new SqlParameter("@product_id", StoredProduct.ProductId),
                new SqlParameter("@store_id", StoredProduct.StoreId));

            StoredProduct.CurrentProduct = true;
            Update(StoredProduct);
        }
    }
}
