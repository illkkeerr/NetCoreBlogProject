using BlogEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogData.Mappings
{
	public class RoleMap : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{

			// Primary key
			builder.HasKey(r => r.Id);

			// Index for "normalized" role name to allow efficient lookups
			builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

			// Maps to the AspNetRoles table
			builder.ToTable("AspNetRoles");

			// A concurrency token for use with the optimistic concurrency checking
			builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

			// Limit the size of columns to use efficient database types
			builder.Property(u => u.Name).HasMaxLength(256);
			builder.Property(u => u.NormalizedName).HasMaxLength(256);

			// The relationships between Role and other entity types
			// Note that these relationships are configured with no navigation properties

			// Each Role can have many entries in the UserRole join table
			builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

			// Each Role can have many associated RoleClaims
			builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

			builder.HasData(new AppRole
			{
				Id = Guid.Parse("F015A37A-BC1F-4155-A900-49F3C46B58CC"),
				Name = "SuperAdmin",
				NormalizedName = "SUPERADMIN",
				ConcurrencyStamp = Guid.NewGuid().ToString(),


			},
			new AppRole
			{
				Id = Guid.Parse("78FC7306-F8DE-40C7-94A6-549927879E5E"),
				Name = "Admin",
				NormalizedName = "ADMIN",
				ConcurrencyStamp = Guid.NewGuid().ToString(),
			},
			new AppRole
			{
				Id = Guid.Parse("20338605-FBE0-4A16-AAE4-2115BA236534"),
				Name = "User",
				NormalizedName = "USER",
				ConcurrencyStamp = Guid.NewGuid().ToString(),
			}) ;
		}
	}
}
