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

        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Invitations> Invitations { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}