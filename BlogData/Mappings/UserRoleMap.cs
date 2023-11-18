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
	public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
	{
		public void Configure(EntityTypeBuilder<AppUserRole> builder)
		{
			// Primary key
			builder.HasKey(r => new { r.UserId, r.RoleId });

			// Maps to the AspNetUserRoles table
			builder.ToTable("AspNetUserRoles");

			builder.HasData(new AppUserRole
			{
				UserId = Guid.Parse("70D1ACAE-20A4-41BF-A054-A7B9B8B4EA5F"),
				RoleId = Guid.Parse("F015A37A-BC1F-4155-A900-49F3C46B58CC")

			},
			new AppUserRole
			{
				UserId= Guid.Parse("DBB6F4E2-16E7-4F92-908F-BBEE39C524F9"),
				RoleId= Guid.Parse("78FC7306-F8DE-40C7-94A6-549927879E5E")

			});

		}
	}
}
