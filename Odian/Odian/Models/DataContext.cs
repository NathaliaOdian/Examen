using System.Data.Entity;

namespace Odian.Models
{
    public class DataContext:DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Odian.Models.Clown> Clowns { get; set; }
    }
}