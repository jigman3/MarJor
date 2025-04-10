using System.ComponentModel.DataAnnotations;

public class UpdateProductDto
{
    [StringLength(100)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Range(0.01, 10000)]
    public decimal? Price { get; set; }

    public bool? IsAvailable { get; set; }
}