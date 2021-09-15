using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using BookReadingEvent1.Common;

namespace BookReadingEvent1.Basic2
{
    public class BookReadingContext : DbContext
    {
        public BookReadingContext() : base("BookReadingContext")
        {
            Database.SetInitializer(new EventInitializer());
        }
    }
}