﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YourPT.Shared.Entities;

namespace YourPT.DataAccess.EFCore.Configurations;

public class AssignmentReflectionConfiguration : IEntityTypeConfiguration<AssignmentReflection>
{
	public void Configure(EntityTypeBuilder<AssignmentReflection> builder)
	{
		builder.ToTable("AssignmentReflections");

		builder.HasKey(a => a.Id);
		builder.Property(a => a.Id).HasColumnName("Id").ValueGeneratedOnAdd();

		builder.Property(a => a.Name).HasColumnName("Name").IsUnicode().HasMaxLength(200).IsRequired();
		builder.Property(a => a.Description).HasColumnName("Description").IsUnicode().HasMaxLength(5000).IsRequired(false);

		builder.Property(a => a.CreatedAt).HasColumnName("CreatedAt").IsRequired();
		builder.Property(a => a.UpdatedAt).HasColumnName("UpdatedAt").IsRequired(false);

		builder.HasOne(a => a.User).WithMany(u => u.AssignmentReflections).HasForeignKey(a => a.UserId).IsRequired(false);

		builder.HasOne(a => a.Assignment).WithMany(a => a.Reflections).HasForeignKey(r => r.AssignmentId).OnDelete(DeleteBehavior.Cascade).IsRequired();
	}
}