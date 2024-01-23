using BlogProject.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("{6445F48B-373C-4FDE-A5F3-1425FAF7F5DA}"),
                FileName = "images/KediFotosu",
                FileType = "png",
                CreatedBy = "Talha Tan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Image
            {
                Id = Guid.Parse("{EE4C53F9-5201-4002-A639-9BBCE2CEE833}"),
                FileName = "images/HippoFotosu",
                FileType = "jpg",
                CreatedBy = "Talha Tan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
