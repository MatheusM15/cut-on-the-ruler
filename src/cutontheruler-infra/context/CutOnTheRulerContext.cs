using Microsoft.EntityFrameworkCore;

namespace cutontheruler_infra.context;

public class CutOnTheRulerContext : DbContext
{
    public CutOnTheRulerContext(DbContextOptions<CutOnTheRulerContext> context) : base(context)
    {
    }
    public DbSet<Schedule> Schedules { get; set; }
}
