using CodeFirstHomework1.Core;

namespace CodeFirstHomework1.Entities
{
    public class Supplier : EntityBase
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
    }
}
