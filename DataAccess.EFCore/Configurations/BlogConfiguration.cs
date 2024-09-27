using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared.Entities;

namespace DataAccess.EFCore.Configurations;

public class BlogConfiguration
{
	public void Configure(EntityTypeBuilder<Blog> builder)
	{
		builder.ToTable("Blogs");

		builder.HasKey(b => b.Id);
		builder.Property(b => b.Id).HasColumnName("Id").ValueGeneratedOnAdd();

		builder.Property(b => b.Title).HasColumnName("Title").IsUnicode().HasMaxLength(200).IsRequired();
		builder.Property(b => b.Content).HasColumnName("Content").IsUnicode().HasMaxLength(5000).IsRequired(false);

		builder.Property(b => b.CreatedAt).HasColumnName("CreatedAt").IsRequired();
		builder.Property(b => b.UpdatedAt).HasColumnName("UpdatedAt").IsRequired(false);

		builder.HasOne(b => b.User).WithMany(u => u.Blogs).HasForeignKey(b => b.UserId).IsRequired(false);
	}
}