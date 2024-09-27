using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shared.Entities;

namespace DataAccess.EFCore.Configurations;

public class NoteConfiguration : IEntityTypeConfiguration<Note>
{
	public void Configure(EntityTypeBuilder<Note> builder)
	{
		builder.ToTable("Notes");

		builder.HasKey(n => n.Id);
		builder.Property(n => n.Id).HasColumnName("Id").ValueGeneratedOnAdd();

		builder.Property(n => n.Title).HasColumnName("Title").IsUnicode().HasMaxLength(200).IsRequired();
		builder.Property(n => n.Text).HasColumnName("Text").IsUnicode().HasMaxLength(5000).IsRequired(false);

		builder.Property(n => n.CreatedAt).HasColumnName("CreatedAt").IsRequired();
		builder.Property(n => n.UpdatedAt).HasColumnName("UpdatedAt").IsRequired(false);

		builder.HasOne(n => n.User).WithMany(u => u.Notes).HasForeignKey(n => n.UserId).IsRequired(false);
	}
}