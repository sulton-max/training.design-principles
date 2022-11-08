namespace PrinciplesExamples;

// Prefer Composition over Inheritance when Children expected to have more features than Parent
public class PaymentService
{
    public virtual void Pay(int senderId, int receiverId)
    {
        // Make transaction
    }
}

public class PaypalPaymentService : PaymentService
{
    public override void
        Pay(int senderId, int receiverId) // ... Here is a problem, we need to create it before executing
}

public class PaypalPaymentService2
{
    public int CreatePayment(int senderId, int receiverId)
    {
        // Create payment record with pending status
        return 1;
    }

    public void ExecutePayment(int paymentid)
    {
        // Execute payment
    }
}

public enum PaymentProvider
{
    PayPal,
}

public class PaymentService2
{
    private PaypalPaymentService2 _paypalPaymentService = new PaypalPaymentService2();
    
    public void Pay(PaymentProvider provider, int senderId, int receiverId)
    {
        var result = provider switch
        {
            PaymentProvider.PayPal => PayWithPayPal(receiverId, receiverId)
        };
        // Delegate to specific method
    }

    public bool PayWithPayPal(int senderId, int receiverId)
    {
        var paymentId = _paypalPaymentService.CreatePayment(senderId, receiverId);
        _paypalPaymentService.ExecutePayment(paymentId);

        return true;
    }
}