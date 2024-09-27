using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared.Entities;

namespace DataAccess.EFCore.Configurations;

public class GoalConfiguration
{
	public void Configure(EntityTypeBuilder<Goal> builder)
	{
		builder.ToTable("Goals");

		builder.HasKey(g => g.Id);
		builder.Property(g => g.Id).HasColumnName("Id").ValueGeneratedOnAdd();

		builder.Property(g => g.Name).HasColumnName("Name").IsUnicode().HasMaxLength(200).IsRequired();
		builder.Property(g => g.Description).HasColumnName("Description").IsUnicode().HasMaxLength(5000).IsRequired(false);
		builder.Property(g => g.Complete).HasColumnName("Complete").IsRequired();

		builder.Property(g => g.CreatedAt).HasColumnName("CreatedAt").IsRequired();
		builder.Property(g => g.UpdatedAt).HasColumnName("UpdatedAt").IsRequired(false);

		builder.HasOne(g => g.User).WithMany(u => u.Goals).HasForeignKey(g => g.UserId).IsRequired(false);
		builder.HasOne(g => g.Reflection).WithOne(g => g.Goal).IsRequired(false);

		builder.HasMany(g => g.Assignments).WithOne(a => a.Goal).IsRequired(false);
	}
}