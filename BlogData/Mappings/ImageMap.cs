using BlogEntity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogData.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    Id = Guid.Parse("3F2E9ACB-6AE5-47D0-9D08-A24120068307"),
                    FileName = "Image/testImage",
                    FileType = "jpg",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    isDeleted = false,
                },
                 new Image
                 {
                     Id = Guid.Parse("DC03ADDB-368F-467D-B9EE-44B3FF55690C"),
                     FileName = "Image/studioTestImage",
                     FileType = "png",
                     CreatedBy = "Admin Test",
                     CreatedDate = DateTime.Now,
                     isDeleted = false,
                 });
        }
    }
}
