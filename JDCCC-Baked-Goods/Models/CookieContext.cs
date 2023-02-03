using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace JDCCC_Baked_Goods.Models
{
    public class CookieContext : DbContext
    {
        public CookieContext(DbContextOptions<CookieContext> options) : base(options) { }
        public DbSet<CookieItem> CookieItems { get; set; } = null!;
    }
}
