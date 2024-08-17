using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("D568E8E1-E3F5-41C4-AFDD-677445B91B20"),
                RoleId = Guid.Parse("D83CDBF8-D903-41FB-91BF-221792EAA54C")
            }, 
            new AppUserRole
            {
                UserId = Guid.Parse("D2A617B6-190A-4002-819E-F9DC38AB71D6"),
                RoleId = Guid.Parse("C69373E3-FCB3-466D-80CB-2F425D5A71F3")
            });
        }
    }
}
