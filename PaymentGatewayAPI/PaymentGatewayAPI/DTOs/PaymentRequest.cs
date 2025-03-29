namespace PaymentGatewayAPI.DTOs;

public record PaymentRequest(decimal Amount, string CardNumber)
{
    public string Last4() => CardNumber.Length >= 4 ? CardNumber[^4..] : CardNumber;
}
