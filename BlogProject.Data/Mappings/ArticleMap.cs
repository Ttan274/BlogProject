using BlogProject.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Kedi Özellikleri",
                Content = "Kedilerin su içtiği kaptan su içebilirsiniz çünkü kediler çok temiz hayvanlardır",
                ViewCount = 20,
                CategoryId = Guid.Parse("{504052C0-A5C6-4738-B668-3D7E088D6334}"),
                ImageId = Guid.Parse("{6445F48B-373C-4FDE-A5F3-1425FAF7F5DA}"),
                CreatedBy = "Talha Tan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Article{
                Id = Guid.NewGuid(),
                Title = "Hipopotam Özellikleri",
                Content = "Hipopotamların sütü pembe renktedir çünkü salgıladıkları kırmızı ve parlak turuncu renkteki asitlerin birleşimindes pembe renk oluşur",
                ViewCount = 100,
                CategoryId = Guid.Parse("{800C5BE4-0448-4E66-A96A-CCC8CC0D65E1}"),
                ImageId = Guid.Parse("{EE4C53F9-5201-4002-A639-9BBCE2CEE833}"),
                CreatedBy = "Talha Tan",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            }); 
        }
    }
}
