using System;

namespace Entity.Extra
{
    public class ProductRow : BaseEntity<Guid>
    {
        public override Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string SunatProductCode { get; set; }
        public bool Perecible { get; set; }
        public decimal MinStock { get; set; }
        public decimal? NominalValue { get; set; }
        public bool AddOnElectronicDocument { get; set; }
    }
}
