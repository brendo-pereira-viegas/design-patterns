IPaymentMethod? debitCardPayment = PaymentMethodFactory.Create(PaymentType.DEBIT_CARD);
IPaymentMethod? creditCardPayment = PaymentMethodFactory.Create(PaymentType.CREDIT_CARD);
debitCardPayment?.Execute();
creditCardPayment?.Execute();
Console.ReadKey();