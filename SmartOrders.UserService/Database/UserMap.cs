using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartOrders.UserService.Model;

namespace SmartOrders.UserService.Database;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
        builder.Property(x => x.Password).IsRequired().HasMaxLength(250);
        builder.Property(x => x.Active).IsRequired().HasColumnType("bit");
        builder.Property(x => x.BirthDate).HasColumnType("date");
        builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("datetime2(7)").HasDefaultValueSql("getutcdate()");
        builder.Property(x => x.UpdatedAt).HasColumnType("datetime2(7)");
    }
}