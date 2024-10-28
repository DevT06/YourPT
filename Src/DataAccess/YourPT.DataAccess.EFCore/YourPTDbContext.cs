using YourPT.DataAccess.EFCore.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using YourPT.Shared.Entities;

namespace YourPT.DataAccess.EFCore;

public class YourPTDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    #region DbSets

    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<AssignmentReflection> AssignmentReflections { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Goal> Goals { get; set; }
    public DbSet<GoalReflection> GoalReflections { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<User> Users { get; set; }

	#endregion

	public YourPTDbContext(IConfiguration configuration)
	{
        _configuration = configuration;
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new AssignmentConfiguration());
		modelBuilder.ApplyConfiguration(new AssignmentReflectionConfiguration());
		modelBuilder.ApplyConfiguration(new BlogConfiguration());
		modelBuilder.ApplyConfiguration(new GoalConfiguration());
		modelBuilder.ApplyConfiguration(new GoalReflectionConfiguration());
		modelBuilder.ApplyConfiguration(new NoteConfiguration());
		modelBuilder.ApplyConfiguration(new UserConfiguration());

		//base.OnModelCreating(modelBuilder);
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"))
			.EnableDetailedErrors();

		//base.OnConfiguring(optionsBuilder);
	}
}