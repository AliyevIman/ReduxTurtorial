using Microsoft.EntityFrameworkCore;

namespace AdminPanelTest.Models
{
    public class TestContext : DbContext
    {
        public TestContext (DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Section1> Section1ss { get; set; }

    }
}
