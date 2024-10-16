using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared.Entities;

namespace DataAccess.EFCore.Configurations;

public class GoalReflectionConfiguration : IEntityTypeConfiguration<GoalReflection>
{
	public void Configure(EntityTypeBuilder<GoalReflection> builder)
	{
		builder.ToTable("GoalReflections");

		builder.HasKey(g => g.Id);
		builder.Property(g => g.Id).HasColumnName("Id").ValueGeneratedOnAdd();

		builder.Property(g => g.Name).HasColumnName("Name").IsUnicode().HasMaxLength(200).IsRequired();
		builder.Property(g => g.Description).HasColumnName("Description").IsUnicode().HasMaxLength(5000).IsRequired(false);

		builder.Property(g => g.CreatedAt).HasColumnName("CreatedAt").IsRequired();
		builder.Property(g => g.UpdatedAt).HasColumnName("UpdatedAt").IsRequired(false);

		builder.HasOne(g => g.User).WithMany(u => u.GoalReflections).HasForeignKey(a => a.UserId).IsRequired(false);

		builder.HasOne(g => g.Goal).WithMany(g => g.Reflections).HasForeignKey(r => r.GoalId).OnDelete(DeleteBehavior.Cascade).IsRequired();
	}
}