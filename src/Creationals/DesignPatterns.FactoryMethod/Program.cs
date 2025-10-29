Console.WriteLine(PaymentMethodFactory
    .Create(PaymentType.DEBIT_CARD)?
    .Execute()
);

Console.WriteLine(PaymentMethodFactory
    .Create(PaymentType.CREDIT_CARD)?
    .Execute()
);

Console.ReadKey();