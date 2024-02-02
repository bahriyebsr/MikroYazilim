using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikroYazilim.Data.Entities
{
	public class ProductEntity:BaseEntity
	{ 
	public string Name { get; set; }
	public string Description { get; set; }
	public decimal? UnitPrice { get; set; }
	public int UnitsInStock { get; set; }
	public string ImagePath { get; set; }
	public int CategoryId { get; set; }
	public string İncele { get; set; }
	public CategoryEntity Category { get; set; }

	}
	public class ProductConfiguration : BaseConfiguration<ProductEntity>
	{
		public override void Configure(EntityTypeBuilder<ProductEntity> builder)
		{
			builder.Property(x => x.Name)
				.HasMaxLength(50);
			builder.Property(x => x.Description)
				.IsRequired(false);
			builder.Property(x => x.UnitPrice)
				.IsRequired(false);
			builder.Property(x => x.ImagePath)
				.IsRequired(false);
			builder.Property(x => x.İncele)
				.IsRequired(false);
			base.Configure(builder);
		}
	}
}
