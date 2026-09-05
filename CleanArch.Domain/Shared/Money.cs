namespace CleanArch.Domain.Shared;

public class Money:BaseValueObject
{
    /// <summary>
    /// Rial
    /// </summary>
    public Money(int rialValue)
    {
        if (rialValue < 0)
            throw new ArgumentOutOfRangeException(nameof(rialValue));
        Value = rialValue;
    }
    public int Value { get; }


    public static Money FromRial(int value) => new Money(value);
    public static Money FromTooman(int value) => new Money(value * 10);

    public static Money operator +(Money firstMoney, Money secondMoney)
        => new Money(firstMoney.Value + secondMoney.Value);

    public static Money operator -(Money firstMoney, Money secondMoney)
        => new Money(firstMoney.Value - secondMoney.Value);

    public override string ToString()
        => Value.ToString("N0");

}