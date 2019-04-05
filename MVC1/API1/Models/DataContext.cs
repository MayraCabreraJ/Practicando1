using System.Data.Entity;

namespace API1.Models
{
    public class DataContext:DbContext
    {
       
            public DataContext():base("DefaultConnection")
            {

            }

        public System.Data.Entity.DbSet<API1.Models.Product> Products { get; set; }
    }
}