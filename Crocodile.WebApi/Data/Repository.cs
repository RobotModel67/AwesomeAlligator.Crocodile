using Microsoft.EntityFrameworkCore;
using Crocodile.WebApi.Models;

namespace Crocodile.WebApi.Data
{
    public class Repository : DbContext
    {
        public Repository(DbContextOptions<Repository> options) : base(options) {

        }

        public DbSet<Value> Values {get; set;}
    }
}