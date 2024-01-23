using BlogProject.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("{504052C0-A5C6-4738-B668-3D7E088D6334}"),
                Name = "Hayvan",
                CreatedBy = "Talha Tan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("{800C5BE4-0448-4E66-A96A-CCC8CC0D65E1}"),
                Name = "Hayvan",
                CreatedBy = "Talha Tan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
