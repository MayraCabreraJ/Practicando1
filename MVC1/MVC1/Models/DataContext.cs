using System.Data.Entity;

namespace MVC1.Models
{
    public class DataContext:DbContext
    {
       
            public DataContext():base("DefaultConnection")
            {

            }

        public System.Data.Entity.DbSet<MVC1.Models.Product> Products { get; set; }
    }
}