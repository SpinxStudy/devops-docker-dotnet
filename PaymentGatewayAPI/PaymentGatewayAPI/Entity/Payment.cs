using PaymentGatewayAPI.Enum;

namespace PaymentGatewayAPI.Entity;

public class Payment
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public PaymentCurrency Currency { get; set; }
    public string CardNumber { get; set; } = string.Empty;
    public PaymentStatus Status { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
