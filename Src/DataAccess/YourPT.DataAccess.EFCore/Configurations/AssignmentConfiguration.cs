﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YourPT.Shared.Entities;

namespace YourPT.DataAccess.EFCore.Configurations;

public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
{
	public void Configure(EntityTypeBuilder<Assignment> builder)
	{
		builder.ToTable("Assignments");

		builder.HasKey(a => a.Id);
		builder.Property(a => a.Id).HasColumnName("Id").ValueGeneratedOnAdd();

		builder.Property(a => a.Name).HasColumnName("Name").IsUnicode().HasMaxLength(200).IsRequired();
		builder.Property(a => a.Description).HasColumnName("Description").IsUnicode().HasMaxLength(5000).IsRequired(false);
		builder.Property(a => a.Complete).HasColumnName("Complete").IsRequired();

		builder.Property(a => a.CreatedAt).HasColumnName("CreatedAt").IsRequired();
		builder.Property(a => a.UpdatedAt).HasColumnName("UpdatedAt").IsRequired(false);

		builder.HasOne(a => a.User).WithMany(u => u.Assignments).HasForeignKey(a => a.UserId).IsRequired(false);

		builder.HasOne(a => a.Goal).WithMany(g => g.Assignments).HasForeignKey(a => a.GoalId).OnDelete(DeleteBehavior.Cascade).IsRequired(); // TODO ADJUST FKs!!! for all ?
		builder.HasMany(a => a.Reflections).WithOne(r => r.Assignment).HasForeignKey(r => r.AssignmentId).OnDelete(DeleteBehavior.Cascade).IsRequired();
	}
}