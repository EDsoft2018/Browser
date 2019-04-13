using EDSoft.Models;
using System.Data.Entity;
namespace EDSoft.DLL
{
    /// <summary>
    /// SQLService 操作类
    /// </summary>
    public class MyDbContext:DbContext
    {
        public MyDbContext() : base("name = EFContext")
        {
        }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<T_TYXX> T_TYXX { get; set; }

    }
}
