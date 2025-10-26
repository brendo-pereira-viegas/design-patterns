PaymentMethodFactory
    .Create(PaymentType.DEBIT_CARD)?
    .Execute();

PaymentMethodFactory
    .Create(PaymentType.CREDIT_CARD)?
    .Execute();

Console.ReadKey();