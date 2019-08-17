using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TEST_170819.Models;

namespace TEST_170819.Configuration
{
    public class FixRequestsConfiguration : IEntityTypeConfiguration<FixRequest>
    {
        public void Configure(EntityTypeBuilder<FixRequest> builder)
        {
            builder.ToTable("FixRequests");

            builder.HasKey(_ => _.Id);
        }
    }
}