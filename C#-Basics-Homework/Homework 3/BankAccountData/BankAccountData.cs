using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string holderFirstName = "Amanda";
        string holderMiddleName = "Paul";
        string holderLastName = "Jonson";
        decimal balance = 20000.85m;
        string bankName = "United Bank";
        string iban = "BG IOUB 8306112507";
        long creditCardNumber1 = 34675765879673543;
        long creditCardNumber2 = 57823523568578958;
        long creditCardNumber3 = 41234665475685653;

        Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", holderFirstName, holderMiddleName, holderLastName, balance, bankName, iban, creditCardNumber1, creditCardNumber2, creditCardNumber3);

    }
}
