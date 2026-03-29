using Web1.Enums;

namespace Web1.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public ProductCatalog ProductType { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}