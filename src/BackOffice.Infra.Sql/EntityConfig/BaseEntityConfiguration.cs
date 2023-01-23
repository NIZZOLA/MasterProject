using BackOffice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice.Infra.Sql.EntityConfig;

public class BaseEntityConfiguration<T> where T : BaseModel
{
    public void ConfigureBase(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();

        builder.Property(e => e.CreateDate).HasColumnType("datetime").HasColumnName("Register");
        builder.Property(e => e.UpdateDate).HasColumnType("datetime").HasColumnName("LastUpdate");
    }
}