namespace ModernCS.Session3;

record Order
{
    public required int Quantity { get; init; }
    public required Product Product { get; init; }
}
