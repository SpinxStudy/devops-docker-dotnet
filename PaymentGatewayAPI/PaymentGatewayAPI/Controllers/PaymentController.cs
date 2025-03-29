using Microsoft.AspNetCore.Mvc;
using PaymentGatewayAPI.DTOs;
using PaymentGatewayAPI.Entity;
using PaymentGatewayAPI.Enum;

namespace PaymentGatewayAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentController : ControllerBase
{
    private static readonly List<Payment> _payments = new();

    [HttpPost]
    public IActionResult CreatePayment([FromBody] PaymentRequest paymentRequest)
    {
        var payment = new Payment
        {
            Id = Guid.NewGuid(),
            Amount = paymentRequest.Amount,
            Currency = PaymentCurrency.BRL,
            CardNumber = paymentRequest.CardNumber,
            Status = PaymentStatus.Pending
        };
        _payments.Add(payment);

        return Ok(new { PaymentId = payment.Id, Status = payment.Status });
    }

    [HttpGet("{id}")]
    public IActionResult GetPayment(Guid id)
    {
        var payment = _payments.FirstOrDefault(p => p.Id == id);
        if (payment == null)
            return NotFound();

        return Ok(payment);
    }
}