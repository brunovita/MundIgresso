using MundIgresso.Domain;
using System.Data.Entity.ModelConfiguration;

namespace MundIngresso.Data.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");
            HasKey(x => x.CategoryID);
            Property(x => x.Title).HasMaxLength(60).IsRequired();
        }
    }
}
