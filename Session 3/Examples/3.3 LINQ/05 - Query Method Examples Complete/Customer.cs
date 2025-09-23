using ModernCS.Session3;

record Customer
{
    public required string Name { get; init; }
    public required string City { get; init; }
    public required List<Order> Orders { get; init; }
}
