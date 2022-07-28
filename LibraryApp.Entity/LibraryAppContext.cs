using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Entity
{
    public class LibraryAppContext : DbContext // взаимодействие с БД
    {
        public LibraryAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<BookGenre> BookGenres { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<IssueLog> IssueLogs { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;


    }
}
