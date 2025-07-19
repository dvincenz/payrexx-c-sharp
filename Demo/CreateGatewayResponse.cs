namespace Demo;

/// <summary>
/// Represents a response from creating a Payrexx payment gateway
/// </summary>
public record CreateGatewayResponse
{
    /// <summary>
    /// Status of the API request
    /// </summary>
    public string Status { get; init; }

    /// <summary>
    /// The gateway data returned from the API
    /// </summary>
    public List<GatewayData> Data { get; init; }

    /// <summary>
    /// Creates a new instance of CreateGatewayResponse
    /// </summary>
    public CreateGatewayResponse(string status, List<GatewayData> data)
    {
        Status = status;
        Data = data;
    }
}

/// <summary>
/// Represents the data of a created gateway
/// </summary>
public record GatewayData
{
    /// <summary>
    /// The unique ID of the created gateway
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// The status of the gateway
    /// </summary>
    public string Status { get; init; }

    /// <summary>
    /// The hash of the gateway
    /// </summary>
    public string Hash { get; init; }

    /// <summary>
    /// The reference ID provided during creation
    /// </summary>
    public string ReferenceId { get; init; }

    /// <summary>
    /// The link to the payment page
    /// </summary>
    public string Link { get; init; }

    /// <summary>
    /// The creation date of the gateway
    /// </summary>
    public long CreatedAt { get; init; }

    /// <summary>
    /// The request ID
    /// </summary>
    public int RequestId { get; init; }

    /// <summary>
    /// The amount in cents
    /// </summary>
    public int Amount { get; init; }

    /// <summary>
    /// The currency of the payment
    /// </summary>
    public string Currency { get; init; }

    /// <summary>
    /// The VAT rate in percentage
    /// </summary>
    public decimal VatRate { get; init; }

    /// <summary>
    /// The application fee
    /// </summary>
    public int ApplicationFee { get; init; }

    /// <summary>
    /// Creates a new instance of GatewayData
    /// </summary>
    public GatewayData(
        int id,
        string status,
        string hash,
        string referenceId,
        string link,
        long createdAt,
        int requestId,
        int amount,
        string currency,
        decimal vatRate,
        int applicationFee)
    {
        Id = id;
        Status = status;
        Hash = hash;
        ReferenceId = referenceId;
        Link = link;
        CreatedAt = createdAt;
        RequestId = requestId;
        Amount = amount;
        Currency = currency;
        VatRate = vatRate;
        ApplicationFee = applicationFee;
    }
}