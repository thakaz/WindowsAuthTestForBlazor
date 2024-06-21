using Microsoft.EntityFrameworkCore;
using Windows認証テスト.Model;

namespace Windows認証テスト.DB
{
    public class TestDBContext  : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users{ get; set; }
    }
}
