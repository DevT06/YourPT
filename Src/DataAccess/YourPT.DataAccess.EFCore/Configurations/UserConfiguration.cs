using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YourPT.Shared.Entities;

namespace YourPT.DataAccess.EFCore.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.ToTable("Users");

		builder.HasKey(u => u.Id);
		builder.Property(u => u.Id).HasColumnName("Id").ValueGeneratedOnAdd();

		builder.Property(u => u.Username).HasColumnName("Username").IsUnicode(false).HasMaxLength(255).IsRequired();
		builder.Property(u => u.Email).HasColumnName("Email").IsUnicode(false).HasMaxLength(255).IsRequired();
		builder.Property(u => u.DisplayName).HasColumnName("DisplayName").IsUnicode().HasMaxLength(200).IsRequired(false);
		builder.Property(u => u.Password).HasColumnName("Password").IsUnicode(false).HasMaxLength(255).IsRequired();

		builder.HasMany(u => u.Assignments).WithOne(a => a.User).HasForeignKey(a => a.UserId).IsRequired(false);
		builder.HasMany(u => u.AssignmentReflections).WithOne(a => a.User).HasForeignKey(a => a.UserId).IsRequired(false);
		builder.HasMany(u => u.GoalReflections).WithOne(g => g.User).HasForeignKey(g => g.UserId).IsRequired(false);
		builder.HasMany(u => u.Goals).WithOne(g => g.User).HasForeignKey(g => g.UserId).IsRequired(false); // might change
		builder.HasMany(u => u.Notes).WithOne(n => n.User).HasForeignKey(n => n.UserId).IsRequired(false);
		builder.HasMany(u => u.Blogs).WithOne(b => b.User).HasForeignKey(b => b.UserId).IsRequired(false);

	}
}