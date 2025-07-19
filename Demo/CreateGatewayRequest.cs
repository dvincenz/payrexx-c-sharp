
namespace Demo;
/// <summary>
/// Represents a request to create a Payrexx payment gateway
/// </summary>
public record CreateGatewayRequest
{

    /// <summary>
    /// The amount in cents (e.g., 1000 for 10.00)
    /// </summary>
    public required int Amount { get; init; }

    /// <summary>
    /// The currency of the payment (e.g., CHF, EUR, USD)
    /// </summary>
    public required string Currency { get; init; }

}